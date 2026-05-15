using VetClinic;

namespace Kursowa
{
    public partial class Zapus : Form
    {
        private Database db;
        public Zapus()
        {
            InitializeComponent();
            db = new Database();
            RefreshAppointmentsList();
        }

        private void btnAddZapus_Click(object sender, EventArgs e)
        {
            // 1. Створюємо нову форму
            AddZapus addForm = new AddZapus(this);

            // 2. Ховаємо поточне вікно (Zapus)
            this.Hide();

            // 3. Відкриваємо AddZapus як модальне вікно
            addForm.ShowDialog();

            // 4. Коли користувач закриє AddZapus, код піде далі:
            RefreshAppointmentsList(); // Оновлюємо дані
            this.Show();               // Знову показуємо головне вікно
        }
        private void btnHistory_Click(object sender, EventArgs e)
        {
            historyZapusiv form = new historyZapusiv();
            form.Show();

            this.Hide();
        }
        private void btnDoctors_Click(object sender, EventArgs e)
        {
            ourDoktor form = new ourDoktor();
            form.Show();

            this.Hide();
        }

        public void RefreshAppointmentsList()
        {
            listView1.Items.Clear(); // Очищуємо список
            var appointments = db.GetFullAppointments();

            foreach (var app in appointments)
            {
                // 1. Пропускаємо завершені записи
                if (app.Status == 1) continue;

                // 2. Створюємо елемент. ПЕРШИЙ стовпець — це ЧАС
                // (Використовуємо app.Time як основний текст елемента)
                ListViewItem item = new ListViewItem(app.Time);

                // 3. Другий стовпець — ПІБ Клієнта
                item.SubItems.Add(app.Klient);

                // 4. Третій стовпець — ПІБ Лікаря
                item.SubItems.Add(app.Doctor);

                // 5. Четвертий стовпець — Статус
                item.SubItems.Add("Очікується");

                // 6. Зберігаємо весь об'єкт або ID у Tag, щоб потім відкрити вікно Info
                item.Tag = app;

                // Додаємо готовий рядок у список
                listView1.Items.Add(item);
            }
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var selectedApp = listView1.SelectedItems[0].Tag as Database.AppointmentExtended;

                if (selectedApp != null)
                {
                    Info infoForm = new Info(selectedApp);

                    infoForm.ShowDialog();

                    // --- ЦЕЙ РЯДОК СПРАЦЮЄ ОДРАЗУ ПІСЛЯ ЗАКРИТТЯ ВІКНА INFO ---
                    RefreshAppointmentsList();
                }
                else
                {
                    MessageBox.Show("Помилка: Дані про запис не знайдено в Tag!");
                }
            }
        }

        private void LoadAppointments()
        {
            listView1.Items.Clear();
            List<Database.AppointmentExtended> appointments = db.GetFullAppointments();

            foreach (var app in appointments)
            {
                // Створюємо рядок (відображаємо основні дані)
                ListViewItem item = new ListViewItem(app.Doctor); // Колонка 0
                item.SubItems.Add(app.Klient);                  // Колонка 1
                item.SubItems.Add(app.Time);                    // Колонка 2

                // ЗБЕРІГАЄМО ОБ'ЄКТ У TAG
                item.Tag = app;

                listView1.Items.Add(item);
            }
        }

    }
}
