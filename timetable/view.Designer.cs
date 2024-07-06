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
            this.BCalc = new System.Windows.Forms.Button();
            this.TYear = new System.Windows.Forms.ComboBox();
            this.TDay = new System.Windows.Forms.ComboBox();
            this.lDay = new System.Windows.Forms.Label();
            this.lMonth = new System.Windows.Forms.Label();
            this.TMonth = new System.Windows.Forms.ComboBox();
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
            // BCalc
            // 
            this.BCalc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BCalc.Location = new System.Drawing.Point(430, 8);
            this.BCalc.Name = "BCalc";
            this.BCalc.Size = new System.Drawing.Size(85, 23);
            this.BCalc.TabIndex = 4;
            this.BCalc.Text = "посчитать";
            this.BCalc.UseVisualStyleBackColor = true;
            this.BCalc.Click += new System.EventHandler(this.BCalc_Click);
            // 
            // TYear
            // 
            this.TYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TYear.FormattingEnabled = true;
            this.TYear.Location = new System.Drawing.Point(54, 7);
            this.TYear.Name = "TYear";
            this.TYear.Size = new System.Drawing.Size(77, 24);
            this.TYear.TabIndex = 1;
            this.TYear.SelectedIndexChanged += new System.EventHandler(this.TYear_SelectedIndexChanged);
            // 
            // TDay
            // 
            this.TDay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TDay.FormattingEnabled = true;
            this.TDay.Location = new System.Drawing.Point(374, 7);
            this.TDay.Name = "TDay";
            this.TDay.Size = new System.Drawing.Size(50, 24);
            this.TDay.TabIndex = 3;
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
            // TMonth
            // 
            this.TMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TMonth.FormattingEnabled = true;
            this.TMonth.Items.AddRange(new object[] {
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
            this.TMonth.Location = new System.Drawing.Point(266, 7);
            this.TMonth.Name = "TMonth";
            this.TMonth.Size = new System.Drawing.Size(50, 24);
            this.TMonth.TabIndex = 3;
            this.TMonth.SelectedIndexChanged += new System.EventHandler(this.TMonth_SelectedIndexChanged);
            // 
            // TimetableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(530, 662);
            this.Controls.Add(this.TMonth);
            this.Controls.Add(this.lMonth);
            this.Controls.Add(this.lDay);
            this.Controls.Add(this.TDay);
            this.Controls.Add(this.TYear);
            this.Controls.Add(this.BCalc);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.lYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TimetableView";
            this.ShowIcon = false;
            this.Text = "Timetable 0.1.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Button BCalc;
        private System.Windows.Forms.Label lDay;
        private System.Windows.Forms.Label lMonth;
        public System.Windows.Forms.ComboBox TYear;
        public System.Windows.Forms.ComboBox TDay;
        public System.Windows.Forms.ComboBox TMonth;
        public System.Windows.Forms.MonthCalendar Calendar;
    }
}

