using System;
using System.Drawing;
using System.Windows.Forms;
using VetClinic; // Обов'язково для доступу до AppointmentExtended

namespace Kursowa
{
    public partial class Info : Form
    {
        private int appointmentId;
        private Database db = new Database();
        public Info()
        {
            InitializeComponent();

        }

        // 2. Виправлений конструктор для отримання даних
        public Info(Database.AppointmentExtended app)
        {
            InitializeComponent();
            this.appointmentId = app.Id;

            lblClient.Text = app.Klient;
            lblDoctor.Text = app.Doctor;
            lblTime.Text = app.Time;

            labelNumber.Text = app.Phone;        // Номер телефону
            labelDate.Text = app.Date;           // Дата 
            labelAnimalInfo.Text = app.AnimalInfo; // Інформація про тварину

            if (app.Status == 0)
            {
                lblStatus.Text = "Очікується";
                lblStatus.ForeColor = Color.Orange;
            }
            else
            {
                lblStatus.Text = "Завершено";
                lblStatus.ForeColor = Color.Green;
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            // Викликаємо метод оновлення в БД
            bool success = db.UpdateAppointmentStatus(appointmentId);

            if (success)
            {
                // Оновлюємо інтерфейс без перезавантаження вікна
                lblStatus.Text = "Статус: Завершено";
                lblStatus.ForeColor = Color.Green;

                MessageBox.Show("Статус успішно змінено на 'Завершено'!");

                // Можна заблокувати кнопку, щоб не тиснути двічі
                btnChangeStatus.Enabled = false;
                this.Close();
            }
        }

    }
}