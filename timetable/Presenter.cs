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
            List<DateTime> dateTimes = new List<DateTime>();

            while (month < 13)
            {
                dateTimes.Add(new DateTime(year, month, day));

                if (day < DateTime.DaysInMonth(year, month))
                {
                    dateTimes.Add(new DateTime(year, month, ++day));
                }
                else
                {
                    if (month == 12) { return dateTimes.ToArray(); } else { month++; day = 1; }

                    dateTimes.Add(new DateTime(year, month, day));
                }

                for (int i = 0; i < 3; i++)
                {
                    if (day < DateTime.DaysInMonth(year, month)) { day++; }
                    
                    else { if (month == 12) { return dateTimes.ToArray(); } else { month++; day = 1; } }
                }
            }

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