namespace Kursowa
{
    partial class Zapus
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddZapus = new Button();
            btnDoctors = new Button();
            btnHistory = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // btnAddZapus
            // 
            btnAddZapus.BackColor = Color.DarkGray;
            btnAddZapus.Location = new Point(28, 12);
            btnAddZapus.Name = "btnAddZapus";
            btnAddZapus.Size = new Size(166, 23);
            btnAddZapus.TabIndex = 0;
            btnAddZapus.Text = "Записатись на прийом";
            btnAddZapus.UseVisualStyleBackColor = false;
            btnAddZapus.Click += btnAddZapus_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.DarkGray;
            btnDoctors.Location = new Point(318, 12);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(166, 23);
            btnDoctors.TabIndex = 1;
            btnDoctors.Text = "Наші лікарі";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DarkGray;
            btnHistory.ForeColor = SystemColors.ControlText;
            btnHistory.Location = new Point(603, 12);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(166, 23);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "Історі записів";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.MediumAquamarine;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(28, 81);
            listView1.Name = "listView1";
            listView1.Size = new Size(741, 309);
            listView1.TabIndex = 3;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseDoubleClick += listView1_MouseDoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Час";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Клієнт";
            columnHeader2.Width = 200;
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
            // Zapus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnHistory);
            Controls.Add(btnDoctors);
            Controls.Add(btnAddZapus);
            Name = "Zapus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сторінка із записами";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddZapus;
        private Button btnDoctors;
        private Button btnHistory;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}
