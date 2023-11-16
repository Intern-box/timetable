using System;
using System.Media;
using System.Windows.Forms;

namespace timetableViewSpace
{
    public partial class timetableView : Form
    {
        int month;

        int year;

        public timetableView()
        {
            InitializeComponent();

            tYear.Text = DateTime.Now.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            month = 0;

            year = int.Parse(tYear.Text);

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
        }
    }
}