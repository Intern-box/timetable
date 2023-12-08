using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace timetableViewSpace
{
    public partial class timetableView : Form
    {
        int month = 1;

        int year;

        int firstWorkDay;

        int lastDayInMonth;

        public timetableView()
        {
            InitializeComponent();

            tYear.Text = DateTime.Now.Year.ToString();

            tDay.SelectedIndex = 0;

            Calendars(DateTime.Now.Year);
        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            year = int.Parse(tYear.Text);

            firstWorkDay = int.Parse(tDay.Text);

            Calendars(year);
        }

        private DateTime[] Calculate(int year, int month)
        {
            lastDayInMonth = DateTime.DaysInMonth(year, month);

            if (month == 2)
            {
                if (DateTime.IsLeapYear(year))
                {
                    switch (lastDayInMonth)
                    {
                        case 28: firstWorkDay = 1; break;

                        case 29: firstWorkDay = 2; break;
                    }
                }
                else
                {
                    switch (lastDayInMonth)
                    {
                        case 27: firstWorkDay = 1; break;

                        case 28: firstWorkDay = 2; break;
                    }
                }
            }

            if (month != 1)
            {
                switch (lastDayInMonth)
                {
                    case 30: firstWorkDay = 1; break;

                    case 31: firstWorkDay = 2; break;
                }
            }

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

            return dateTimes.ToArray();
        }

        private void Calendars(int year)
        {
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
        }
    }
}