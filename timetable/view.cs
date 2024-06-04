using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TimetableViewSpace
{
    public partial class TimeTableView : Form
    {
        List<MonthCalendar> MonthCalendars;

        int Year;

        int Month;

        int FirstWorkDay;

        int LastDayInMonth;

        public TimeTableView()
        {
            InitializeComponent();

            tYear.Text = DateTime.Now.Year.ToString();

            tMonth.SelectedIndex = tDay.SelectedIndex = 0;

            MonthCalendars = new List<MonthCalendar> { cJan, cFeb, cMarch, cApr, cMay, cJune, cJuly, cAug, cSep, cOct, cNov, cDec };

            Calendars(DateTime.Now.Year);
        }

        private void bCalc_Click(object sender, EventArgs e)
        {
            Year = int.Parse(tYear.Text);

            Month = int.Parse(tMonth.Text);

            FirstWorkDay = int.Parse(tDay.Text);

            for (int i = Month - 1; i < tMonth.Items.Count; i++) { MonthCalendars[i].BoldedDates = Calculate(Year, Month); Month++; }
        }

        private DateTime[] Calculate(int year, int month)
        {
            //LastDayInMonth = DateTime.DaysInMonth(year, month);

            //if (month == 2)
            //{
            //    if (DateTime.IsLeapYear(year))
            //    {
            //        switch (LastDayInMonth)
            //        {
            //            case 28: FirstWorkDay = 1; break;

            //            case 29: FirstWorkDay = 2; break;
            //        }
            //    }
            //    else
            //    {
            //        switch (LastDayInMonth)
            //        {
            //            case 27: FirstWorkDay = 1; break;

            //            case 28: FirstWorkDay = 2; break;
            //        }
            //    }
            //}

            //if (month != 1)
            //{
            //    switch (LastDayInMonth)
            //    {
            //        case 30: FirstWorkDay = 1; break;

            //        case 31: FirstWorkDay = 2; break;
            //    }
            //}

            byte mark = 0;

            List<DateTime> dateTimes = new List<DateTime>();

            while (year == int.Parse(tYear.ToString()) & month <= int.Parse(tMonth.ToString()) & FirstWorkDay < 32)
            {
                
            }

            //for (int j = 1; j < DateTime.DaysInMonth(year, month); j++)
            //{
            //    if (j == FirstWorkDay)
            //    {
            //        dateTimes.Add(new DateTime(year, month, j));

            //        dateTimes.Add(new DateTime(year, month, j + 1));

            //        LastDayInMonth = dateTimes[dateTimes.Count - 1].Day;

            //        FirstWorkDay += 4;
            //    }
            //}

            return dateTimes.ToArray();
        }

        private void Calendars(int year)
        {
            Month = 1;

            foreach (MonthCalendar item in MonthCalendars)
            {
                item.MaxDate = item.SelectionStart = item.SelectionEnd = new DateTime(year, Month, DateTime.DaysInMonth(year, Month));

                item.TodayDate = new DateTime(year, Month, 1);

                Month++;
            }
        }
    }
}