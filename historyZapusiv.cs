using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using VetClinic; // Переконайся, що цей namespace вірний

namespace Kursowa
{
    public partial class historyZapusiv : Form
    {
        private Database db;

        public historyZapusiv()
        {
            InitializeComponent();
            db = new Database();

            // Викликаємо завантаження даних при відкритті форми
            LoadHistory();
        }

        private void LoadHistory()
        {
            listView1.Items.Clear();

            // Переконайся, що в налаштуваннях ListView стоїть View = Details
            var appointments = db.GetFullAppointments();

            if (appointments == null) return;

            foreach (var app in appointments)
            {
                // 1. Перша колонка (ПІБ клієнта)
                ListViewItem item = new ListViewItem(app.Klient);

                // 2. Друга колонка (ДАТА)
                item.SubItems.Add(app.Date);

                // 3. Третя колонка (ЧАС)
                item.SubItems.Add(app.Time);

                // 4. Четверта колонка (ПІБ лікаря)
                item.SubItems.Add(app.Doctor);

                // 5. П'ята колонка (СТАТУС)
                if (app.Status == 1)
                {
                    item.SubItems.Add("Огляд проведено");
                    item.ForeColor = Color.DarkGreen;
                }
                else
                {
                    item.SubItems.Add("Очікується");
                    item.ForeColor = Color.Black;
                }

                // Зберігаємо ID або весь об'єкт у Tag (приховано від користувача)
                item.Tag = app;

                listView1.Items.Add(item);
            }
        }

        private void btnZapus_Click(object sender, EventArgs e)
        {
            Zapus form = new Zapus();
            form.Show();
            this.Close();
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            ourDoktor form = new ourDoktor();
            form.Show();
            this.Hide();
        }

        private void btnAddZapus_Click(object sender, EventArgs e)
        {
            Zapus temp = new Zapus();
            AddZapus form = new AddZapus(temp);
            form.Show();
            this.Close();
        }
    }
}