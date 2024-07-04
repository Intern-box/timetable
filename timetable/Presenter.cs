﻿using System;
using System.Collections.Generic;
using TimetableViewSpace;

namespace TimetablePresenterSpace
{
    public class TimetablePresenter
    {
        TimetableView timetableView;

        public TimetablePresenter(TimetableView timetableView) { this.timetableView = timetableView; }

        public void ClickCalculate()
        {
            timetableView.Calendar.BoldedDates =
                Calculate(int.Parse(timetableView.tYear.Text), int.Parse(timetableView.tMonth.Text), int.Parse(timetableView.tDay.Text));
        }

        public DateTime[] Calculate(int year, int month, int day)
        {
            List<DateTime> listDateTime = new List<DateTime>();

            while (month < 13)
            {
                if (day <= DateTime.DaysInMonth(year, month)) { listDateTime.Add(new DateTime(year, month, day)); day++; }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (day <= DateTime.DaysInMonth(year, month)) { listDateTime.Add(new DateTime(year, month, day)); day++; }

                else
                {
                    if (day == 31)
                    {
                        day = 1; month++;

                        listDateTime.Add(new DateTime(year, month, day)); day++;

                        if (month > 12) { return listDateTime.ToArray(); }
                    }
                    else
                    {
                        day = 1; month++;

                        if (month > 12) { return listDateTime.ToArray(); }

                        continue;
                    }
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (day <= DateTime.DaysInMonth(year, month)) { day++; }

                else
                {
                    if (day == 30)
                    {
                        day = 2; month++;

                        if (month > 12) { return listDateTime.ToArray(); }
                    }
                    if (day == 31)
                    {
                        day = 3; month++;

                        if (month > 12) { return listDateTime.ToArray(); }
                    }
                    else
                    {
                        day = 2; month++;

                        if (month > 12) { return listDateTime.ToArray(); }
                    }
                }

                ////////////////////////////////////////////////////////////////////////////////////////////////////////////

                if (day <= DateTime.DaysInMonth(year, month)) { day++; }

                else
                {
                    day = 2; month++;

                    if (month > 12) { return listDateTime.ToArray(); }
                }
            }

            return listDateTime.ToArray();
        }
    }
}