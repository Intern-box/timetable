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

            //cJan.Font = new System.Drawing.Font("Verdana", 10); // Стиль и размер шрифта
            //cJan.ForeColor = System.Drawing.Color.Black; // Цвет шрифта
            //cJan.TitleBackColor = System.Drawing.Color.White; // Фон заголовка
            //cJan.TitleForeColor = System.Drawing.Color.Black; // Цвет заголовка
            //cJan.ShowTodayCircle = true;

            Start();
        }

        private void bCalc_Click(object sender, EventArgs e) { timetablePresenter.ClickCalculate(); }

        private void Start()
        {
            // Год

            tYear.Items.Add(DateTime.Now.Year - 2);

            tYear.Items.Add(DateTime.Now.Year - 1);

            tYear.Items.Add(DateTime.Now.Year);

            tYear.Items.Add(DateTime.Now.Year + 1);

            tYear.Items.Add(DateTime.Now.Year + 2);

            tYear.Text = DateTime.Now.Year.ToString();

            // Месяц

            tMonth.SelectedItem = DateTime.Now.Month.ToString();
        }

        private void tYear_SelectedIndexChanged(object sender, EventArgs e) { timetablePresenter.Calendars(int.Parse(tYear.Text)); }

        private void tMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Дни

            tDay.Items.Clear();

            for (int i = 0; i < DateTime.DaysInMonth(int.Parse(tYear.Text), int.Parse(tMonth.Text)); i++) { tDay.Items.Add(i + 1); }

            tDay.Text = DateTime.Now.Day.ToString();
        }
    }
}