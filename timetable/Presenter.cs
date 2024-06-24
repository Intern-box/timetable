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
            int year = int.Parse(timetableView.tYear.Text);

            int month = int.Parse(timetableView.tMonth.Text);

            int day = int.Parse(timetableView.tDay.Text);

            DateTime[] dateTimes;

            for (int i = month - 1; i < 12; i++)
            {
                dateTimes = Calculate(year, month, day);

                timetableModel.MonthCalendars[i].BoldedDates = dateTimes;

                if (dateTimes.Length % 2 == 1)
                {
                    if (DateTime.DaysInMonth(year, month) - dateTimes[dateTimes.Length - 1].Day != 0)
                    {
                        day = DateTime.DaysInMonth(year, month) - dateTimes[dateTimes.Length - 1].Day; // Только первая дата
                    }
                    else
                    {
                        day = 1;
                    }
                }
                else
                {
                    switch (DateTime.DaysInMonth(year, month) - dateTimes[dateTimes.Length - 1].Day)
                    {
                        case 0: day = 3; break;

                        case 1: day = 2; break;

                        case 2: day = 1; break;
                    }
                }

                month++;
            }
        }

        public DateTime[] Calculate(int year, int month, int day)
        {
            List<DateTime> dateTimes = new List<DateTime>();

            if (month < 13)
            {
                while (day <= DateTime.DaysInMonth(year, month))
                {
                    dateTimes.Add(new DateTime(year, month, day)); day++;

                    if (day < DateTime.DaysInMonth(year, month)) { dateTimes.Add(new DateTime(year, month, day)); }

                    else { return dateTimes.ToArray(); }
                    
                    day += 3;
                }
            }

            return dateTimes.ToArray();
        }

        public void Calendars(int year)
        {
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