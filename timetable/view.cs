using System;
using System.Windows.Forms;
using timetablePresenterSpace;

namespace timetableViewSpace
{
    public partial class timetableView : Form
    {
        timetablePresenter timetablePresenter;
        public timetableView()
        {
            this.timetablePresenter = new timetablePresenter(this);

            InitializeComponent();

            tYear.Text = DateTime.Now.Year.ToString();

            //cJen.MaxDate = new DateTime(int.Parse(tYear.Text), 1, DateTime.DaysInMonth(int.Parse(tYear.Text), 1));

            //cJen.TodayDate = new DateTime(int.Parse(tYear.Text), 1, 1);
        }
    }
}