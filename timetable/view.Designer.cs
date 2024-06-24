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
            this.cJan = new System.Windows.Forms.MonthCalendar();
            this.cFeb = new System.Windows.Forms.MonthCalendar();
            this.cMarch = new System.Windows.Forms.MonthCalendar();
            this.cApr = new System.Windows.Forms.MonthCalendar();
            this.cAug = new System.Windows.Forms.MonthCalendar();
            this.cJuly = new System.Windows.Forms.MonthCalendar();
            this.cJune = new System.Windows.Forms.MonthCalendar();
            this.cMay = new System.Windows.Forms.MonthCalendar();
            this.cDec = new System.Windows.Forms.MonthCalendar();
            this.cNov = new System.Windows.Forms.MonthCalendar();
            this.cOct = new System.Windows.Forms.MonthCalendar();
            this.cSep = new System.Windows.Forms.MonthCalendar();
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
            // cJan
            // 
            this.cJan.Enabled = false;
            this.cJan.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cJan.Location = new System.Drawing.Point(18, 41);
            this.cJan.Name = "cJan";
            this.cJan.ShowToday = false;
            this.cJan.ShowTodayCircle = false;
            this.cJan.TabIndex = 3;
            this.cJan.TodayDate = new System.DateTime(2024, 1, 18, 0, 0, 0, 0);
            // 
            // cFeb
            // 
            this.cFeb.Enabled = false;
            this.cFeb.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cFeb.Location = new System.Drawing.Point(200, 41);
            this.cFeb.Name = "cFeb";
            this.cFeb.ShowToday = false;
            this.cFeb.ShowTodayCircle = false;
            this.cFeb.TabIndex = 4;
            // 
            // cMarch
            // 
            this.cMarch.Enabled = false;
            this.cMarch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cMarch.Location = new System.Drawing.Point(382, 41);
            this.cMarch.Name = "cMarch";
            this.cMarch.ShowToday = false;
            this.cMarch.ShowTodayCircle = false;
            this.cMarch.TabIndex = 5;
            // 
            // cApr
            // 
            this.cApr.Enabled = false;
            this.cApr.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cApr.Location = new System.Drawing.Point(564, 41);
            this.cApr.Name = "cApr";
            this.cApr.ShowToday = false;
            this.cApr.ShowTodayCircle = false;
            this.cApr.TabIndex = 6;
            // 
            // cAug
            // 
            this.cAug.Enabled = false;
            this.cAug.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cAug.Location = new System.Drawing.Point(564, 224);
            this.cAug.Name = "cAug";
            this.cAug.ShowToday = false;
            this.cAug.ShowTodayCircle = false;
            this.cAug.TabIndex = 10;
            // 
            // cJuly
            // 
            this.cJuly.Enabled = false;
            this.cJuly.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cJuly.Location = new System.Drawing.Point(382, 224);
            this.cJuly.Name = "cJuly";
            this.cJuly.ShowToday = false;
            this.cJuly.ShowTodayCircle = false;
            this.cJuly.TabIndex = 9;
            // 
            // cJune
            // 
            this.cJune.Enabled = false;
            this.cJune.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cJune.Location = new System.Drawing.Point(200, 224);
            this.cJune.Name = "cJune";
            this.cJune.ShowToday = false;
            this.cJune.ShowTodayCircle = false;
            this.cJune.TabIndex = 8;
            // 
            // cMay
            // 
            this.cMay.Enabled = false;
            this.cMay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cMay.Location = new System.Drawing.Point(18, 224);
            this.cMay.Name = "cMay";
            this.cMay.ShowToday = false;
            this.cMay.ShowTodayCircle = false;
            this.cMay.TabIndex = 7;
            // 
            // cDec
            // 
            this.cDec.Enabled = false;
            this.cDec.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cDec.Location = new System.Drawing.Point(564, 407);
            this.cDec.Name = "cDec";
            this.cDec.ShowToday = false;
            this.cDec.ShowTodayCircle = false;
            this.cDec.TabIndex = 14;
            // 
            // cNov
            // 
            this.cNov.Enabled = false;
            this.cNov.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cNov.Location = new System.Drawing.Point(382, 407);
            this.cNov.Name = "cNov";
            this.cNov.ShowToday = false;
            this.cNov.ShowTodayCircle = false;
            this.cNov.TabIndex = 13;
            this.cNov.TabStop = false;
            // 
            // cOct
            // 
            this.cOct.Enabled = false;
            this.cOct.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cOct.Location = new System.Drawing.Point(200, 407);
            this.cOct.Name = "cOct";
            this.cOct.ShowToday = false;
            this.cOct.ShowTodayCircle = false;
            this.cOct.TabIndex = 12;
            // 
            // cSep
            // 
            this.cSep.Enabled = false;
            this.cSep.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cSep.Location = new System.Drawing.Point(18, 407);
            this.cSep.Name = "cSep";
            this.cSep.ShowToday = false;
            this.cSep.ShowTodayCircle = false;
            this.cSep.TabIndex = 11;
            // 
            // bCalc
            // 
            this.bCalc.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCalc.Location = new System.Drawing.Point(643, 6);
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
            this.tYear.Location = new System.Drawing.Point(54, 6);
            this.tYear.Name = "tYear";
            this.tYear.Size = new System.Drawing.Size(77, 24);
            this.tYear.TabIndex = 1;
            this.tYear.SelectedIndexChanged += new System.EventHandler(this.tYear_SelectedIndexChanged);
            // 
            // tDay
            // 
            this.tDay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tDay.FormattingEnabled = true;
            this.tDay.Location = new System.Drawing.Point(587, 6);
            this.tDay.Name = "tDay";
            this.tDay.Size = new System.Drawing.Size(50, 24);
            this.tDay.TabIndex = 3;
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDay.Location = new System.Drawing.Point(535, 10);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(46, 16);
            this.lDay.TabIndex = 17;
            this.lDay.Text = "День:";
            // 
            // lMonth
            // 
            this.lMonth.AutoSize = true;
            this.lMonth.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lMonth.Location = new System.Drawing.Point(416, 10);
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
            this.tMonth.Location = new System.Drawing.Point(479, 7);
            this.tMonth.Name = "tMonth";
            this.tMonth.Size = new System.Drawing.Size(50, 24);
            this.tMonth.TabIndex = 3;
            // 
            // TimetableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 579);
            this.Controls.Add(this.tMonth);
            this.Controls.Add(this.lMonth);
            this.Controls.Add(this.lDay);
            this.Controls.Add(this.tDay);
            this.Controls.Add(this.tYear);
            this.Controls.Add(this.bCalc);
            this.Controls.Add(this.cDec);
            this.Controls.Add(this.cNov);
            this.Controls.Add(this.cOct);
            this.Controls.Add(this.cSep);
            this.Controls.Add(this.cAug);
            this.Controls.Add(this.cJuly);
            this.Controls.Add(this.cJune);
            this.Controls.Add(this.cMay);
            this.Controls.Add(this.cApr);
            this.Controls.Add(this.cMarch);
            this.Controls.Add(this.cFeb);
            this.Controls.Add(this.cJan);
            this.Controls.Add(this.lYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimetableView";
            this.ShowIcon = false;
            this.Text = "timetable 0.0";
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
        public System.Windows.Forms.MonthCalendar cJan;
        public System.Windows.Forms.MonthCalendar cFeb;
        public System.Windows.Forms.MonthCalendar cMarch;
        public System.Windows.Forms.MonthCalendar cApr;
        public System.Windows.Forms.MonthCalendar cAug;
        public System.Windows.Forms.MonthCalendar cJuly;
        public System.Windows.Forms.MonthCalendar cJune;
        public System.Windows.Forms.MonthCalendar cMay;
        public System.Windows.Forms.MonthCalendar cDec;
        public System.Windows.Forms.MonthCalendar cNov;
        public System.Windows.Forms.MonthCalendar cOct;
        public System.Windows.Forms.MonthCalendar cSep;
    }
}

