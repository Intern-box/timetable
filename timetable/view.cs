using System;
using System.Windows.Forms;

namespace timetableViewSpace
{
    public partial class timetableView : Form
    {
        public timetableView()
        {
            InitializeComponent();

            tYear.Text = DateTime.Now.Year.ToString();

            //cJen.MaxDate = new DateTime(int.Parse(tYear.Text), 1, DateTime.DaysInMonth(int.Parse(tYear.Text), 1));

            //cJen.TodayDate = new DateTime(int.Parse(tYear.Text), 1, 1);
        }
    }
}