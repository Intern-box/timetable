using System;
using System.Windows.Forms;
using timetableViewSpace;
using timetablePresenterSpace;

namespace timetable
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            timetableView timetableView = new timetableView();
            timetablePresenter timetablePresenter = new timetablePresenter(timetableView);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new timetableView());
        }
    }
}