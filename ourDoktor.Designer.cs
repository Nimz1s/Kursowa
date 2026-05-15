namespace Kursowa
{
    partial class ourDoktor
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
            btnHistory = new Button();
            btnAddZapus = new Button();
            btnZapus = new Button();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DarkGray;
            btnHistory.Location = new Point(596, 23);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(166, 23);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "Історі записів";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnAddZapus
            // 
            btnAddZapus.BackColor = Color.DarkGray;
            btnAddZapus.Location = new Point(23, 23);
            btnAddZapus.Name = "btnAddZapus";
            btnAddZapus.Size = new Size(166, 23);
            btnAddZapus.TabIndex = 4;
            btnAddZapus.Text = "Записатись на прийом";
            btnAddZapus.UseVisualStyleBackColor = false;
            btnAddZapus.Click += btnAddZapus_Click;
            // 
            // btnZapus
            // 
            btnZapus.BackColor = Color.DarkGray;
            btnZapus.Location = new Point(297, 23);
            btnZapus.Name = "btnZapus";
            btnZapus.Size = new Size(166, 23);
            btnZapus.TabIndex = 3;
            btnZapus.Text = "Записи";
            btnZapus.UseVisualStyleBackColor = false;
            btnZapus.Click += btnZapus_Click;
            // 
            // listView1
            // 
            listView1.BackColor = Color.MediumAquamarine;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(23, 115);
            listView1.Name = "listView1";
            listView1.Size = new Size(739, 309);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ourDoktor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(btnHistory);
            Controls.Add(btnAddZapus);
            Controls.Add(btnZapus);
            Name = "ourDoktor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Наші ветеренари";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHistory;
        private Button btnAddZapus;
        private Button btnZapus;
        private ListView listView1;
    }
}