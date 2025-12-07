namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lableStatus = new System.Windows.Forms.Label();
            this.reminder = new System.Windows.Forms.TextBox();
            this.DirectoryToMusic1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(120, 70);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(90, 21);
            this.dateTimePicker.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LimeGreen;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(77, 120);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 25);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Начать";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Salmon;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(179, 120);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 25);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Остановить";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lableStatus
            // 
            this.lableStatus.AutoSize = true;
            this.lableStatus.Location = new System.Drawing.Point(132, 94);
            this.lableStatus.Name = "lableStatus";
            this.lableStatus.Size = new System.Drawing.Size(38, 14);
            this.lableStatus.TabIndex = 3;
            this.lableStatus.Text = "label1";
            // 
            // reminder
            // 
            this.reminder.Location = new System.Drawing.Point(77, 43);
            this.reminder.Name = "reminder";
            this.reminder.Size = new System.Drawing.Size(177, 21);
            this.reminder.TabIndex = 4;
            this.reminder.Text = "Введите сюда текст...";
            this.reminder.AcceptsTabChanged += new System.EventHandler(this.reminder_Enter);
            this.reminder.TextChanged += new System.EventHandler(this.reminder_Enter);
            this.reminder.Enter += new System.EventHandler(this.reminder_Enter);
            // 
            // DirectoryToMusic1
            // 
            this.DirectoryToMusic1.Location = new System.Drawing.Point(64, 168);
            this.DirectoryToMusic1.Name = "DirectoryToMusic1";
            this.DirectoryToMusic1.Size = new System.Drawing.Size(207, 21);
            this.DirectoryToMusic1.TabIndex = 5;
            this.DirectoryToMusic1.Text = "C:\\Users\\User\\Downloads\\E.wav";
            this.DirectoryToMusic1.AcceptsTabChanged += new System.EventHandler(this.DirectoryToMusic1_TextChanged);
            this.DirectoryToMusic1.TextChanged += new System.EventHandler(this.DirectoryToMusic1_TextChanged);
            this.DirectoryToMusic1.Enter += new System.EventHandler(this.DirectoryToMusic1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.Location = new System.Drawing.Point(56, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(35, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // List
            // 
            this.List.AutoScroll = true;
            this.List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(48)))), ((int)(((byte)(110)))));
            this.List.Location = new System.Drawing.Point(16, 256);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(288, 224);
            this.List.TabIndex = 7;
            this.List.Paint += new System.Windows.Forms.PaintEventHandler(this.List_Paint);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.Location = new System.Drawing.Point(97, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(35, 32);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnClear_MouseDown);
            this.btnClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnClear_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(75)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.DirectoryToMusic1);
            this.panel2.Controls.Add(this.reminder);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.lableStatus);
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Location = new System.Drawing.Point(1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(316, 254);
            this.panel2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(61, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Путь до трэка в формате wav";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(197)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Location = new System.Drawing.Point(-9, 209);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 42);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(137, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Задержите на 2с.";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(18)))), ((int)(((byte)(42)))));
            this.panel3.Location = new System.Drawing.Point(-8, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(24, 484);
            this.panel3.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(48)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(318, 477);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.List);
            this.Controls.Add(this.panel2);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Будильник";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lableStatus;
        private System.Windows.Forms.TextBox reminder;
        private System.Windows.Forms.TextBox DirectoryToMusic1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel List;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}

