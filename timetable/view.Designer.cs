namespace TimetableViewSpace
{
    partial class TimetableView
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
            this.lYear = new System.Windows.Forms.Label();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.bCalc = new System.Windows.Forms.Button();
            this.tYear = new System.Windows.Forms.ComboBox();
            this.tDay = new System.Windows.Forms.ComboBox();
            this.lDay = new System.Windows.Forms.Label();
            this.lMonth = new System.Windows.Forms.Label();
            this.tMonth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lYear.Location = new System.Drawing.Point(12, 9);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(36, 16);
            this.lYear.TabIndex = 0;
            this.lYear.Text = "Год:";
            // 
            // Calendar
            // 
            this.Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar.CalendarDimensions = new System.Drawing.Size(3, 4);
            this.Calendar.Enabled = false;
            this.Calendar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calendar.Location = new System.Drawing.Point(15, 43);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToday = false;
            this.Calendar.ShowTodayCircle = false;
            this.Calendar.TabIndex = 3;
            this.Calendar.TodayDate = new System.DateTime(2024, 1, 18, 0, 0, 0, 0);
            // 
            // bCalc
            // 
            this.bCalc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCalc.Location = new System.Drawing.Point(430, 8);
            this.bCalc.Name = "bCalc";
            this.bCalc.Size = new System.Drawing.Size(85, 23);
            this.bCalc.TabIndex = 4;
            this.bCalc.Text = "посчитать";
            this.bCalc.UseVisualStyleBackColor = true;
            this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
            // 
            // tYear
            // 
            this.tYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tYear.FormattingEnabled = true;
            this.tYear.Location = new System.Drawing.Point(54, 7);
            this.tYear.Name = "tYear";
            this.tYear.Size = new System.Drawing.Size(77, 24);
            this.tYear.TabIndex = 1;
            this.tYear.SelectedIndexChanged += new System.EventHandler(this.tYear_SelectedIndexChanged);
            // 
            // tDay
            // 
            this.tDay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDay.FormattingEnabled = true;
            this.tDay.Location = new System.Drawing.Point(374, 7);
            this.tDay.Name = "tDay";
            this.tDay.Size = new System.Drawing.Size(50, 24);
            this.tDay.TabIndex = 3;
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDay.Location = new System.Drawing.Point(322, 9);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(46, 16);
            this.lDay.TabIndex = 17;
            this.lDay.Text = "День:";
            // 
            // lMonth
            // 
            this.lMonth.AutoSize = true;
            this.lMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMonth.Location = new System.Drawing.Point(203, 9);
            this.lMonth.Name = "lMonth";
            this.lMonth.Size = new System.Drawing.Size(57, 16);
            this.lMonth.TabIndex = 18;
            this.lMonth.Text = "Месяц:";
            // 
            // tMonth
            // 
            this.tMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tMonth.FormattingEnabled = true;
            this.tMonth.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.tMonth.Location = new System.Drawing.Point(266, 7);
            this.tMonth.Name = "tMonth";
            this.tMonth.Size = new System.Drawing.Size(50, 24);
            this.tMonth.TabIndex = 3;
            this.tMonth.SelectedIndexChanged += new System.EventHandler(this.tMonth_SelectedIndexChanged);
            // 
            // TimetableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(530, 662);
            this.Controls.Add(this.tMonth);
            this.Controls.Add(this.lMonth);
            this.Controls.Add(this.lDay);
            this.Controls.Add(this.tDay);
            this.Controls.Add(this.tYear);
            this.Controls.Add(this.bCalc);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.lYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TimetableView";
            this.ShowIcon = false;
            this.Text = "Timetable 0.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Button bCalc;
        private System.Windows.Forms.Label lDay;
        private System.Windows.Forms.Label lMonth;
        public System.Windows.Forms.ComboBox tYear;
        public System.Windows.Forms.ComboBox tDay;
        public System.Windows.Forms.ComboBox tMonth;
        public System.Windows.Forms.MonthCalendar Calendar;
    }
}

