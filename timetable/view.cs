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

            year = int.Parse(tYear.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            month++;

            cJen.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cJen.TodayDate = new DateTime(year, month, 1);

            month++;

            cFeb.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cFeb.TodayDate = new DateTime(year, month, 1);

            month++;

            cMarth.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cMarth.TodayDate = new DateTime(year, month, 1);

            month++;

            cApr.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cApr.TodayDate = new DateTime(year, month, 1);

            month++;

            cMay.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cMay.TodayDate = new DateTime(year, month, 1);

            month++;

            cJune.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cJune.TodayDate = new DateTime(year, month, 1);

            month++;

            cJuly.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cJuly.TodayDate = new DateTime(year, month, 1);

            month++;

            cAug.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cAug.TodayDate = new DateTime(year, month, 1);

            month++;

            cSen.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cSen.TodayDate = new DateTime(year, month, 1);

            month++;

            cOct.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cOct.TodayDate = new DateTime(year, month, 1);

            month++;

            cNov.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cNov.TodayDate = new DateTime(year, month, 1);

            month++;

            cDec.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            cDec.TodayDate = new DateTime(year, month, 1);

            //year++;

            //month = 1;

            //cDec.MaxDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            //cDec.TodayDate = new DateTime(year, month, 1);
        }
    }
}