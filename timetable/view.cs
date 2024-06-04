using System;
using System.Windows.Forms;
using TimetablePresenterSpace;

namespace TimetableViewSpace
{
    public partial class TimetableView : Form
    {
        TimetablePresenter timetablePresenter;

        public TimetableView()
        {
            InitializeComponent();

            timetablePresenter = new TimetablePresenter(this);

            tYear.Text = DateTime.Now.Year.ToString();

            tMonth.SelectedIndex = tDay.SelectedIndex = 0;

            timetablePresenter.Calendars(int.Parse(tYear.Text));
        }

        private void bCalc_Click(object sender, EventArgs e) { timetablePresenter.ClickCalculate(); }
    }
}