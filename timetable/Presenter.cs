using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TimetableViewSpace;
using TimetableModelSpace;

namespace TimetablePresenterSpace
{
    public class TimetablePresenter
    {
        TimetableView timetableView;

        TimetableModel timetableModel;

        public TimetablePresenter(TimetableView timetableView)
        {
            this.timetableView = timetableView;

            timetableModel = new TimetableModel();

            timetableModel.MonthCalendars = new List<MonthCalendar>()
            {
                timetableView.cJan,
                timetableView.cFeb,
                timetableView.cMarch,
                timetableView.cApr,
                timetableView.cMay,
                timetableView.cJune,
                timetableView.cJuly,
                timetableView.cAug,
                timetableView.cSep,
                timetableView.cOct,
                timetableView.cNov,
                timetableView.cDec
            };
        }

        public void ClickCalculate()
        {
            timetableModel.Year = int.Parse(timetableView.tYear.Text);

            timetableModel.Month = int.Parse(timetableView.tMonth.Text);

            timetableModel.FirstWorkDay = int.Parse(timetableView.tDay.Text);

            for (int i = timetableModel.Month - 1; i < timetableView.tMonth.Items.Count; i++)
            {
                timetableModel.MonthCalendars[i].BoldedDates = Calculate(timetableModel.Year, timetableModel.Month, timetableModel.FirstWorkDay); timetableModel.Month++;
            }
        }

        public DateTime[] Calculate(int year, int month, int day)
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

            List<DateTime> dateTimes = new List<DateTime>();

            while (year == int.Parse(timetableView.tYear.Text) & month <= int.Parse(timetableView.tMonth.Text) & day < 32)
            {
                dateTimes.Add(new DateTime(year, month, day));

                if (day < DateTime.DaysInMonth(year, month))
                {
                    dateTimes.Add(new DateTime(year, month, ++day));
                }
                else
                {
                    month++; day = 1;

                    dateTimes.Add(new DateTime(year, month, day));
                }

                for (int i = 0; i < 3; i++) { if (day < DateTime.DaysInMonth(year, month)) { day++; } else { month++; day = 1; } }
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

        public void Calendars(int year)
        {
            timetableModel.Month = 1;

            foreach (MonthCalendar item in timetableModel.MonthCalendars)
            {
                item.MaxDate = item.SelectionStart = item.SelectionEnd = new DateTime(year, timetableModel.Month, DateTime.DaysInMonth(year, timetableModel.Month));

                item.TodayDate = new DateTime(year, timetableModel.Month, 1);

                timetableModel.Month++;
            }
        }
    }
}