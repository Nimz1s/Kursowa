using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VetClinic;

namespace Kursowa
{
    public partial class ourDoktor : Form
    {
        private Database db;
        private Random rnd = new Random();

        public ourDoktor()
        {
            InitializeComponent();
            db = new Database();

            // Початкове налаштування колонок
            ConfigureListView();
            // Завантаження даних при відкритті форми
            LoadDoctorsFromDb();
        }

        private void ConfigureListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Clear();
            listView1.Columns.Add("ПІБ лікаря", 220);
            listView1.Columns.Add("Початок роботи", 120);
            listView1.Columns.Add("Кінець роботи", 120);
            listView1.Columns.Add("Рейтинг", 100);
        }

        private void LoadDoctorsFromDb()
        {
            listView1.Items.Clear();

            // Викликаємо наш новий метод
            var doctors = db.GetDoctorsFullInfo();

            if (doctors == null) return;

            foreach (var doc in doctors)
            {
                ListViewItem item = new ListViewItem(doc.Name); // Колонка 1: ПІБ
                item.SubItems.Add($"{doc.StartWork}:00");       // Колонка 2: Початок
                item.SubItems.Add($"{doc.EndWork}:00");         // Колонка 3: Кінець

                // Твій рандомний рейтинг
                double rating = 3.0 + (rnd.NextDouble() * 2.0);
                item.SubItems.Add(rating.ToString("0.0") + " ⭐"); // Колонка 4: Рейтинг

                listView1.Items.Add(item);
            }
        }

        // Кнопки навігації
        private void btnZapus_Click(object sender, EventArgs e)
        {
            Zapus form = new Zapus();
            form.Show();
            this.Close();
        }

        private void btnAddZapus_Click(object sender, EventArgs e)
        {
            AddZapus addForm = new AddZapus(null);
            addForm.Show();
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            historyZapusiv form = new historyZapusiv();
            form.Show();
            this.Close();
        }
    }
}