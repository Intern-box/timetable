using System.Collections.Generic;
using System.Windows.Forms;

namespace TimetableModelSpace
{
    public class TimetableModel
    {
        public List<MonthCalendar> MonthCalendars;

        public int Year;

        public int Month;

        public int FirstWorkDay;

        public int LastDayInMonth;
    }
}