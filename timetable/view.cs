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
        }
    }
}