using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;

namespace VetClinic
{
    public class DoctorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int StartWork { get; set; }
        public int EndWork { get; set; }
    }

    public class Database
    {
        private string connectionString = "Data Source=clinic.db";

        public Database()
        {
            CreateTables();
        }

        public void CreateTables()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS Doctors (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    doctorPIB TEXT NOT NULL,
                    startHour INTEGER NOT NULL,
                    endHour INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS KlientsAppointments (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    klientPIB TEXT NOT NULL,
                    phone TEXT NOT NULL,
                    date TEXT NOT NULL,
                    time INTEGER NOT NULL,
                    doctorPIB TEXT NOT NULL,
                    status INTEGER NOT NULL,
                    animalInfo TEXT
                );

                CREATE TABLE IF NOT EXISTS Appointments(
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    doctorPIB TEXT NOT NULL,
                    timeAppointments TEXT NOT NULL,
                    klientPIB TEXT NOT NULL  
                );";

                using (var cmd = new SqliteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<DoctorModel> GetDoctors()
        {
            var list = new List<DoctorModel>();
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                string sql = "SELECT id, doctorPIB FROM Doctors";
                using (var cmd = new SqliteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new DoctorModel
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1)
                        });
                    }
                }
            }
            return list;
        }

        public List<Doctor> GetDoctorsFullInfo()
        {
            List<Doctor> list = new List<Doctor>();
            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id, doctorPIB, startHour, endHour FROM Doctors";

                using (var command = new SqliteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Doctor
                        {
                            Id = reader.GetInt32(0),
                            Name = reader["doctorPIB"].ToString(),
                            StartWork = reader["startHour"] != DBNull.Value ? Convert.ToInt32(reader["startHour"]) : 9,
                            EndWork = reader["endHour"] != DBNull.Value ? Convert.ToInt32(reader["endHour"]) : 18
                        });
                    }
                }
            }
            return list;
        }

        public List<int> GetFreeHours(int doctorId, string date)
        {
            List<int> freeHours = new List<int>();

            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                // 1. Отримуємо робочі години лікаря
                int startHour = 9;
                int endHour = 18;
                string doctorName = "";

                var docCmd = new SqliteCommand("SELECT startHour, endHour, doctorPIB FROM Doctors WHERE id = @id", conn);
                docCmd.Parameters.AddWithValue("@id", doctorId);

                using (var reader = docCmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        startHour = reader.GetInt32(0);
                        endHour = reader.GetInt32(1);
                        doctorName = reader.GetString(2);
                    }
                }

                // 2. Отримуємо список годин, які вже ЗАЙНЯТІ на цю дату у цього лікаря
                List<int> busyHours = new List<int>();
                string sqlBusy = "SELECT time FROM KlientsAppointments WHERE doctorPIB = @docName AND date = @date";

                using (var bCmd = new SqliteCommand(sqlBusy, conn))
                {
                    bCmd.Parameters.AddWithValue("@docName", doctorName);
                    bCmd.Parameters.AddWithValue("@date", date);

                    using (var reader = bCmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            busyHours.Add(reader.GetInt32(0));
                        }
                    }
                }

                // 3. Формуємо список вільних годин (тільки ті, яких немає в busyHours)
                for (int h = startHour; h < endHour; h++)
                {
                    if (!busyHours.Contains(h))
                    {
                        freeHours.Add(h);
                    }
                }
            }
            return freeHours;
        }

        public bool SaveAppointment(string pib, string phone, string date, int time, string doctor, string animalInfo)
        {
            try
            {
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();

                    // КРОК 1: Додаємо в KlientsAppointments
                    string sqlKlients = @"
                        INSERT INTO KlientsAppointments (klientPIB, phone, date, time, doctorPIB, status, animalInfo)
                        VALUES (@pib, @phone, @date, @time, @doctor, @status, @animalInfo)";

                    using (var cmd = new SqliteCommand(sqlKlients, connection))
                    {
                        cmd.Parameters.AddWithValue("@pib", pib);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@date", date);
                        cmd.Parameters.AddWithValue("@time", time);
                        cmd.Parameters.AddWithValue("@doctor", doctor);
                        cmd.Parameters.AddWithValue("@status", 0);
                        cmd.Parameters.AddWithValue("@animalInfo", animalInfo ?? (object)DBNull.Value);
                        cmd.ExecuteNonQuery();
                    }

                    // КРОК 2: Додаємо в Appointments (щоб GetFullAppointments бачив цей запис)
                    string sqlApp = @"
                        INSERT INTO Appointments (doctorPIB, timeAppointments, klientPIB)
                        VALUES (@doctor, @timeText, @pib)";

                    using (var cmd = new SqliteCommand(sqlApp, connection))
                    {
                        cmd.Parameters.AddWithValue("@doctor", doctor);
                        cmd.Parameters.AddWithValue("@timeText", $"{time}:00");
                        cmd.Parameters.AddWithValue("@pib", pib);
                        cmd.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Помилка БД: " + ex.Message);
                return false;
            }
        }

        public List<AppointmentExtended> GetFullAppointments()
        {
            var list = new List<AppointmentExtended>();
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                // Додав K.animalInfo в SELECT
                string sql = @"
                    SELECT A.id, A.doctorPIB, A.timeAppointments, A.klientPIB, K.status, K.animalInfo, K.phone, K.date
                    FROM Appointments A
                    JOIN KlientsAppointments K ON A.klientPIB = K.klientPIB AND A.doctorPIB = K.doctorPIB";

                using (var cmd = new SqliteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new AppointmentExtended
                        {
                            Id = reader.GetInt32(0),
                            Doctor = reader.GetString(1),
                            Time = reader.GetString(2),
                            Klient = reader.GetString(3),
                            Status = reader.GetInt32(4),
                            AnimalInfo = reader.IsDBNull(5) ? "" : reader.GetString(5),
                            Phone = reader.GetString(6), // Додайте це в модель
                            Date = reader.GetString(7)   // Додайте це в модель
                        });
                    }
                }
            }
            return list;
        }

        public class AppointmentExtended
        {
            public int Id { get; set; }
            public string Doctor { get; set; }
            public string Time { get; set; }
            public string Klient { get; set; }
            public int Status { get; set; }
            public string AnimalInfo { get; set; }
            public string Phone { get; set; } // Додано
            public string Date { get; set; }  // Додано
        }


        public bool UpdateAppointmentStatus(int id)
        {
            try
            {
                using (var conn = new SqliteConnection(connectionString))
                {
                    conn.Open();
                    // Оновлюємо статус у таблиці KlientsAppointments
                    // Оскільки id у таблицях може відрізнятися, краще оновлювати за логікою вашого JOIN
                    string sql = "UPDATE KlientsAppointments SET status = 1 WHERE id = @id";

                    using (var cmd = new SqliteCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Помилка оновлення: " + ex.Message);
                return false;
            }
        }
    }
}