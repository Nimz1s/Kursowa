namespace Kursowa
{
    partial class Info
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
            lblClient = new Label();
            lblDoctor = new Label();
            lblTime = new Label();
            lblStatus = new Label();
            btnChangeStatus = new Button();
            labelNumber = new Label();
            labelDate = new Label();
            labelAnimalInfo = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Location = new Point(63, 59);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(60, 15);
            lblClient.TabIndex = 0;
            lblClient.Text = "PIB_Client";
            // 
            // lblDoctor
            // 
            lblDoctor.AutoSize = true;
            lblDoctor.Location = new Point(595, 59);
            lblDoctor.Name = "lblDoctor";
            lblDoctor.Size = new Size(65, 15);
            lblDoctor.TabIndex = 1;
            lblDoctor.Text = "PIB_Doctor";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(462, 22);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(31, 15);
            lblTime.TabIndex = 2;
            lblTime.Text = "time";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(595, 117);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(38, 15);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "status";
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.BackColor = Color.DarkGray;
            btnChangeStatus.Location = new Point(346, 415);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(112, 23);
            btnChangeStatus.TabIndex = 4;
            btnChangeStatus.Text = "Огляд проведено";
            btnChangeStatus.UseVisualStyleBackColor = false;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // labelNumber
            // 
            labelNumber.AutoSize = true;
            labelNumber.Location = new Point(63, 117);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(49, 15);
            labelNumber.TabIndex = 5;
            labelNumber.Text = "number";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(310, 22);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(31, 15);
            labelDate.TabIndex = 6;
            labelDate.Text = "Date";
            // 
            // labelAnimalInfo
            // 
            labelAnimalInfo.AutoSize = true;
            labelAnimalInfo.Location = new Point(63, 170);
            labelAnimalInfo.Name = "labelAnimalInfo";
            labelAnimalInfo.Size = new Size(64, 15);
            labelAnimalInfo.TabIndex = 7;
            labelAnimalInfo.Text = "animalInfo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 44);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 8;
            label1.Text = "ПІБ пацієнта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 102);
            label2.Name = "label2";
            label2.Size = new Size(151, 15);
            label2.TabIndex = 9;
            label2.Text = "Номер телефону пацієнта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 155);
            label3.Name = "label3";
            label3.Size = new Size(243, 15);
            label3.TabIndex = 10;
            label3.Text = "Інформація надана цлієнтом про тваринку";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(595, 44);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 11;
            label4.Text = "ПІБ доктора";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(595, 102);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 12;
            label5.Text = "Статус запису";
            // 
            // Info
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelAnimalInfo);
            Controls.Add(labelDate);
            Controls.Add(labelNumber);
            Controls.Add(btnChangeStatus);
            Controls.Add(lblStatus);
            Controls.Add(lblTime);
            Controls.Add(lblDoctor);
            Controls.Add(lblClient);
            Name = "Info";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Інформація від клієнта";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClient;
        private Label lblDoctor;
        private Label lblTime;
        private Label lblStatus;
        private Button btnChangeStatus;
        private Label labelNumber;
        private Label labelDate;
        private Label labelAnimalInfo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}