namespace timetableViewSpace
{
    partial class timetableView
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
            this.tYear = new System.Windows.Forms.TextBox();
            this.lYear = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tYear
            // 
            this.tYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tYear.Location = new System.Drawing.Point(54, 6);
            this.tYear.Name = "tYear";
            this.tYear.Size = new System.Drawing.Size(65, 23);
            this.tYear.TabIndex = 0;
            this.tYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lYear.Location = new System.Drawing.Point(12, 9);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(36, 16);
            this.lYear.TabIndex = 1;
            this.lYear.Text = "Год:";
            // 
            // timetableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lYear);
            this.Controls.Add(this.tYear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "timetableView";
            this.ShowIcon = false;
            this.Text = "timetable 0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tYear;
        private System.Windows.Forms.Label lYear;
    }
}

