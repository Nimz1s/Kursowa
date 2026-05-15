using System;
using System.Windows.Forms;
using VetClinic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Kursowa
{
    public partial class AddZapus : Form
    {
        private Database db;
        private bool isLoaded = false;
        private Zapus _parentForm;

        public AddZapus(Zapus parent)
        {
            InitializeComponent();

            db = new Database();

            // 3. Зберігаємо посилання на головну форму
            _parentForm = parent;

            comboBoxDoctors.Enabled = false;
            comboTime.Enabled = false;

            LoadDoctors();

            isLoaded = true;
        }

        // =====================
        // LOAD DOCTORS ONCE
        // =====================

        private void LoadDoctors()
        {
            var doctors = db.GetDoctors();

            if (doctors != null)
            {
                // 1. Очищуємо DataSource
                comboBoxDoctors.DataSource = null;

                // 2. СПОЧАТКУ вказуємо імена властивостей
                comboBoxDoctors.DisplayMember = "Name";
                comboBoxDoctors.ValueMember = "Id";

                // 3. ТІЛЬКИ ПОТІМ прив'язуємо список
                comboBoxDoctors.DataSource = doctors;

                // Скидаємо вибір, щоб користувач сам обрав лікаря
                comboBoxDoctors.SelectedIndex = -1;
                comboBoxDoctors.Enabled = true;
            }
        }

        // =====================
        // DATE CHANGE
        // =====================
        private void datePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!isLoaded) return;

            // Якщо лікар уже обраний, то при зміні дати відразу оновлюємо години
            if (comboBoxDoctors.SelectedIndex != -1)
            {
                comboBoxDoctors_SelectedIndexChanged(null, null); // Викликаємо оновлення годин
            }
            else
            {
                comboTime.Items.Clear();
                comboTime.Enabled = false;
            }
        }



        // =====================
        // DOCTOR CHANGE
        // =====================
        private void comboBoxDoctors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Додаємо перевірку SelectedValue на null та коректність типу
            if (!isLoaded || comboBoxDoctors.SelectedIndex == -1 || comboBoxDoctors.SelectedValue == null)
                return;

            // Безпечне отримання ID (SelectedValue повертає object, тому Convert або cast обов'язкові)
            if (int.TryParse(comboBoxDoctors.SelectedValue.ToString(), out int doctorId))
            {
                comboTime.Items.Clear();
                string date = datePicker.Value.ToString("yyyy-MM-dd");

                var freeHours = db.GetFreeHours(doctorId, date);

                if (freeHours != null && freeHours.Count > 0)
                {
                    foreach (var h in freeHours)
                    {
                        comboTime.Items.Add($"{h}:00");
                    }
                    comboTime.Enabled = true;
                }
                else
                {
                    comboTime.Enabled = false;
                }
            }
        }

        private void btnZapus_Click(object sender, EventArgs e)
        {
            // 1. Перевіряємо, чи посилання на батьківську форму взагалі існує
            if (_parentForm != null)
            {
                // 2. Робимо головну форму знову видимою
                _parentForm.Show();

                // 3. Закриваємо поточне допоміжне вікно
                this.Close();
            }
            else
            {
                // Якщо раптом форма відкрита не з головної, 
                // створюємо нову, щоб користувач не залишився з пустим екраном
                Zapus mainForm = new Zapus();
                mainForm.Show();
                this.Close();
            }
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            ourDoktor form = new ourDoktor();
            form.Show();

            // Якщо ви хочете повністю закрити це вікно:
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            historyZapusiv form = new historyZapusiv();

            // Підписуємось на подію закриття нової форми, 
            // щоб при її закритті завершувався весь процес програми
            form.FormClosed += (s, args) => Application.Exit();

            form.Show();
            this.Hide(); // Використовуй Hide, щоб уникнути закриття головного потоку
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string pib = inputPIB.Text.Trim();
            string phone = textNubmer.Text.Trim();
            string date = datePicker.Value.ToString("yyyy-MM-dd");

            // Зчитуємо нове поле
            string animalInfo = textBoxAnimalInfo.Text.Trim();

            if (string.IsNullOrEmpty(pib) || comboBoxDoctors.SelectedItem == null || comboTime.SelectedItem == null)
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }

            string doctorPIB = comboBoxDoctors.Text;
            int time = int.Parse(comboTime.SelectedItem.ToString().Replace(":00", ""));

            // Передаємо animalInfo як шостий аргумент
            bool success = db.SaveAppointment(pib, phone, date, time, doctorPIB, animalInfo);

            if (success)
            {
                MessageBox.Show("Запис успішно створено!");
                if (_parentForm != null)
                {
                    _parentForm.RefreshAppointmentsList();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Помилка при збереженні в базу даних.");
            }
        }

        private void textBoxAnimalInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoctors_Click_1(object sender, EventArgs e)
        {

        }
    }
}