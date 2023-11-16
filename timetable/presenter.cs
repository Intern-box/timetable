using timetableViewSpace;
using timetableModelSpace;

namespace timetablePresenterSpace
{
    public class timetablePresenter
    {
        timetableView timetableView;

        timetableModel timetableModel = new timetableModel();

        public timetablePresenter(timetableView timetableView)
        {
            this.timetableView = timetableView;
        }
    }
}