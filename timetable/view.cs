using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace timetableViewSpace
{
    public partial class timetableView : Form
    {
        int month;

        int year;

        int firstWorkDay;

        int lastDayInMonth = 1;

        public timetableView()
        {
            InitializeComponent();

            tYear.Text = DateTime.Now.Year.ToString();

            tDay.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            month = 0;

            year = int.Parse(tYear.Text);

            firstWorkDay = int.Parse(tDay.Text);

            month++;

            cJen.MaxDate = cJen.SelectionStart = cJen.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cJen.TodayDate = new DateTime(year, month, 1);

            month++;

            cFeb.MaxDate = cFeb.SelectionStart = cFeb.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cFeb.TodayDate = new DateTime(year, month, 1);

            month++;

            cMarch.MaxDate = cMarch.SelectionStart = cMarch.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cMarch.TodayDate = new DateTime(year, month, 1);

            month++;

            cApr.MaxDate = cApr.SelectionStart = cApr.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cApr.TodayDate = new DateTime(year, month, 1);

            month++;

            cMay.MaxDate = cMay.SelectionStart = cMay.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cMay.TodayDate = new DateTime(year, month, 1);

            month++;

            cJune.MaxDate = cJune.SelectionStart = cJune.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cJune.TodayDate = new DateTime(year, month, 1);

            month++;

            cJuly.MaxDate = cJuly.SelectionStart = cJuly.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cJuly.TodayDate = new DateTime(year, month, 1);

            month++;

            cAug.MaxDate = cAug.SelectionStart = cAug.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cAug.TodayDate = new DateTime(year, month, 1);

            month++;

            cSep.MaxDate = cSep.SelectionStart = cSep.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cSep.TodayDate = new DateTime(year, month, 1);

            month++;

            cOct.MaxDate = cOct.SelectionStart = cOct.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cOct.TodayDate = new DateTime(year, month, 1);

            month++;

            cNov.MaxDate = cNov.SelectionStart = cNov.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cNov.TodayDate = new DateTime(year, month, 1);

            month++;

            cDec.MaxDate = cDec.SelectionStart = cDec.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cDec.TodayDate = new DateTime(year, month, 1);

            year++;

            month = 1;

            cNewJen.MaxDate = cNewJen.SelectionStart = cNewJen.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cNewJen.TodayDate = new DateTime(year, month, 1);

            year--;

            cJen.BoldedDates = Calculate(year, 1);

            cFeb.BoldedDates = Calculate(year, 2);

            cMarch.BoldedDates = Calculate(year, 3);

            cApr.BoldedDates = Calculate(year, 4);

            cMay.BoldedDates = Calculate(year, 5);

            cJune.BoldedDates = Calculate(year, 6);

            cJuly.BoldedDates = Calculate(year, 7);

            cAug.BoldedDates = Calculate(year, 8);

            cSep.BoldedDates = Calculate(year, 9);

            cOct.BoldedDates = Calculate(year, 10);

            cNov.BoldedDates = Calculate(year, 11);

            cDec.BoldedDates = Calculate(year, 12);

            year++;

            cNewJen.BoldedDates = Calculate(year, 1);
        }

        private DateTime[] Calculate(int year, int month)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            for (int j = 1; j < DateTime.DaysInMonth(year, month); j++)
            {
                if (j == firstWorkDay)
                {
                    dateTimes.Add(new DateTime(year, month, j));

                    dateTimes.Add(new DateTime(year, month, j + 1));

                    lastDayInMonth = dateTimes[dateTimes.Count - 1].Day;

                    firstWorkDay += 4;
                }
            }

            if (month != 2)
            {
                switch (lastDayInMonth)
                {
                    case 30: firstWorkDay = 2; break;

                    case 31: firstWorkDay = 3; break;

                    default: firstWorkDay = 1; break;
                }
            }
            else
            {
                switch (lastDayInMonth)
                {
                    case 28: firstWorkDay = 2; break;

                    case 29: firstWorkDay = 3; break;

                    default: firstWorkDay = 1; break;
                }
            }

            return dateTimes.ToArray();
        }
    }
}