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
        }

        public void ClickCalculate()
        {
            timetableModel.Year = int.Parse(timetableView.tYear.Text);

            timetableModel.Month = int.Parse(timetableView.tMonth.Text);

            timetableModel.FirstWorkDay = int.Parse(timetableView.tDay.Text);

            DateTime[] dateTimes;

            for (int i = timetableModel.Month - 1; i < 12; i++)
            {
                dateTimes = Calculate(timetableModel.Year, timetableModel.Month, timetableModel.FirstWorkDay);

                timetableModel.MonthCalendars[i].BoldedDates = dateTimes;

                switch (DateTime.DaysInMonth(timetableModel.Year, timetableModel.Month) - dateTimes[dateTimes.Length - 1].Day)
                {
                    case 0: timetableModel.FirstWorkDay = 3; break;

                    case 1: timetableModel.FirstWorkDay = 2; break;

                    case 2: timetableModel.FirstWorkDay = 1; break;
                }

                if (dateTimes.Length % 2 == 1) { timetableModel.FirstWorkDay = 1; }

                timetableModel.Month++;
            }
        }

        public DateTime[] Calculate(int year, int month, int day)
        {
            List<DateTime> dateTimes = new List<DateTime>() { new DateTime(year, month, day) };

            day++;

            if (month < 13)
            {
                while (day < DateTime.DaysInMonth(year, month))
                {
                    dateTimes.Add(new DateTime(year, month, day));

                    day++;

                    if (day < DateTime.DaysInMonth(year, month))
                    {
                        dateTimes.Add(new DateTime(year, month, day));
                    }

                    else { return dateTimes.ToArray(); }

                    for (int i = 0; i < 3; i++)
                    {
                        day++;

                        if (day == DateTime.DaysInMonth(year, month))
                        {
                            if (i == 1) { return dateTimes.ToArray(); }

                            if (i == 2) { dateTimes.Add(new DateTime(year, month, day)); }

                            break;
                        }
                    }
                }
            }

            return dateTimes.ToArray();
        }

        public void Calendars(int year)
        {
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

            int month = 1;

            foreach (MonthCalendar item in timetableModel.MonthCalendars)
            {
                item.SelectionStart = item.SelectionEnd = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                item.TodayDate = new DateTime(year, month, 1);

                month++;
            }
        }
    }
}