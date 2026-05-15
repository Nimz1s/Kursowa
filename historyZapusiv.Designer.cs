namespace Kursowa
{
    partial class historyZapusiv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddZapus = new Button();
            btn = new Button();
            btnOurDocktor = new Button();
            listView1 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnAddZapus
            // 
            btnAddZapus.BackColor = Color.DarkGray;
            btnAddZapus.Location = new Point(38, 12);
            btnAddZapus.Name = "btnAddZapus";
            btnAddZapus.Size = new Size(166, 23);
            btnAddZapus.TabIndex = 8;
            btnAddZapus.Text = "Записатись на прийом";
            btnAddZapus.UseVisualStyleBackColor = false;
            btnAddZapus.Click += btnAddZapus_Click;
            // 
            // btn
            // 
            btn.BackColor = Color.DarkGray;
            btn.Location = new Point(586, 12);
            btn.Name = "btn";
            btn.Size = new Size(166, 23);
            btn.TabIndex = 7;
            btn.Text = "Записи";
            btn.UseVisualStyleBackColor = false;
            btn.Click += btnZapus_Click;
            // 
            // btnOurDocktor
            // 
            btnOurDocktor.BackColor = Color.DarkGray;
            btnOurDocktor.Location = new Point(316, 12);
            btnOurDocktor.Name = "btnOurDocktor";
            btnOurDocktor.Size = new Size(166, 23);
            btnOurDocktor.TabIndex = 6;
            btnOurDocktor.Text = "Наші лікарі";
            btnOurDocktor.UseVisualStyleBackColor = false;
            btnOurDocktor.Click += btnDoctors_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.MediumAquamarine;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader5, columnHeader1, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(12, 95);
            listView1.Name = "listView1";
            listView1.Size = new Size(776, 309);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Клієнт";
            columnHeader2.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Дата проведеного огляду";
            columnHeader5.Width = 160;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Час";
            columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Лікар";
            columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Статус";
            columnHeader4.Width = 130;
            // 
            // historyZapusiv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnAddZapus);
            Controls.Add(btn);
            Controls.Add(btnOurDocktor);
            Name = "historyZapusiv";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Історія роботи ветеренарів";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddZapus;
        private Button btn;
        private Button btnOurDocktor;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
    }
}