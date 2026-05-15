namespace Kursowa
{
    partial class AddZapus
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
            components = new System.ComponentModel.Container();
            btnHistory = new Button();
            btnDoctors = new Button();
            btnZapus = new Button();
            btnSave = new Button();
            inputPIB = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            labelPIB = new Label();
            labelNumber = new Label();
            textNubmer = new TextBox();
            datePicker = new DateTimePicker();
            comboTime = new ComboBox();
            comboBoxDoctors = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxAnimalInfo = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.DarkGray;
            btnHistory.Location = new Point(605, 23);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(166, 23);
            btnHistory.TabIndex = 5;
            btnHistory.Text = "Історі записів";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnDoctors
            // 
            btnDoctors.BackColor = Color.DarkGray;
            btnDoctors.Location = new Point(320, 23);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(166, 23);
            btnDoctors.TabIndex = 4;
            btnDoctors.Text = "Наші лікарі";
            btnDoctors.UseVisualStyleBackColor = false;
            btnDoctors.Click += btnDoctors_Click_1;
            // 
            // btnZapus
            // 
            btnZapus.BackColor = Color.DarkGray;
            btnZapus.Location = new Point(30, 23);
            btnZapus.Name = "btnZapus";
            btnZapus.Size = new Size(166, 23);
            btnZapus.TabIndex = 3;
            btnZapus.Text = "Записи";
            btnZapus.UseVisualStyleBackColor = false;
            btnZapus.Click += btnZapus_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkGray;
            btnSave.Location = new Point(303, 357);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(202, 66);
            btnSave.TabIndex = 6;
            btnSave.Text = "Створити запис на консультацію у лікаря";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // inputPIB
            // 
            inputPIB.Location = new Point(123, 136);
            inputPIB.Name = "inputPIB";
            inputPIB.Size = new Size(227, 23);
            inputPIB.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // labelPIB
            // 
            labelPIB.AutoSize = true;
            labelPIB.Location = new Point(137, 118);
            labelPIB.Name = "labelPIB";
            labelPIB.Size = new Size(168, 15);
            labelPIB.TabIndex = 13;
            labelPIB.Text = "Введіть Своє Призвіще та Імя";
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(137, 178);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(141, 15);
            labelNumber.TabIndex = 14;
            labelNumber.Text = "Введіть номер телефону";
            // 
            // textNubmer
            // 
            textNubmer.Location = new Point(123, 196);
            textNubmer.Name = "textNubmer";
            textNubmer.Size = new Size(227, 23);
            textNubmer.TabIndex = 15;
            // 
            // datePicker
            // 
            datePicker.Location = new Point(465, 138);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(200, 23);
            datePicker.TabIndex = 16;
            datePicker.ValueChanged += datePicker_ValueChanged;
            // 
            // comboTime
            // 
            comboTime.FormattingEnabled = true;
            comboTime.Location = new Point(465, 255);
            comboTime.Name = "comboTime";
            comboTime.Size = new Size(121, 23);
            comboTime.TabIndex = 17;
            // 
            // comboBoxDoctors
            // 
            comboBoxDoctors.FormattingEnabled = true;
            comboBoxDoctors.Location = new Point(467, 196);
            comboBoxDoctors.Name = "comboBoxDoctors";
            comboBoxDoctors.Size = new Size(121, 23);
            comboBoxDoctors.TabIndex = 18;
            comboBoxDoctors.SelectedIndexChanged += comboBoxDoctors_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(465, 120);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 19;
            label1.Text = "Виберіть день запису";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 239);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 20;
            label2.Text = "Виберіть годину запису";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(465, 178);
            label3.Name = "label3";
            label3.Size = new Size(197, 15);
            label3.TabIndex = 21;
            label3.Text = "Лікарь до якого хочете записатись";
            // 
            // textBoxAnimalInfo
            // 
            textBoxAnimalInfo.Location = new Point(123, 255);
            textBoxAnimalInfo.Name = "textBoxAnimalInfo";
            textBoxAnimalInfo.Size = new Size(227, 23);
            textBoxAnimalInfo.TabIndex = 23;
            textBoxAnimalInfo.TextChanged += textBoxAnimalInfo_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(137, 237);
            label4.Name = "label4";
            label4.Size = new Size(168, 15);
            label4.TabIndex = 22;
            label4.Text = "Опишіть проблему тваринки";
            // 
            // AddZapus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxAnimalInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxDoctors);
            Controls.Add(comboTime);
            Controls.Add(datePicker);
            Controls.Add(textNubmer);
            Controls.Add(labelNumber);
            Controls.Add(labelPIB);
            Controls.Add(inputPIB);
            Controls.Add(btnSave);
            Controls.Add(btnHistory);
            Controls.Add(btnDoctors);
            Controls.Add(btnZapus);
            Name = "AddZapus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Створити запис до ветеренара";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnHistory;
        private Button btnDoctors;
        private Button btnZapus;
        private Button btnSave;
        private TextBox inputPIB;
        private ContextMenuStrip contextMenuStrip1;
        private Label labelPIB;
        private Label labelNumber;
        private TextBox textNubmer;
        private DateTimePicker datePicker;
        private ComboBox comboTime;
        private ComboBox comboBoxDoctors;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxAnimalInfo;
        private Label label4;
    }
}