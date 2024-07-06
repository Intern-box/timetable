using System;
using System.Windows.Forms;
using TimetablePresenterSpace;

namespace TimetableViewSpace
{
    public partial class TimetableView : Form
    {
        readonly TimetablePresenter timetablePresenter;
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

        private void Start()
        {
            // Год

            TYear.Items.Add(DateTime.Now.Year - 2);

            TYear.Items.Add(DateTime.Now.Year - 1);

            TYear.Items.Add(DateTime.Now.Year);

            TYear.Items.Add(DateTime.Now.Year + 1);

            TYear.Items.Add(DateTime.Now.Year + 2);

            TYear.Items.Add(DateTime.Now.Year + 3);

            TYear.Text = DateTime.Now.Year.ToString();

            // Месяц

            TMonth.SelectedItem = DateTime.Now.Month.ToString();
        }

        private void TMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            // День

            TDay.Items.Clear();

            for (int i = 0; i < DateTime.DaysInMonth(int.Parse(TYear.Text), int.Parse(TMonth.Text)); i++) { TDay.Items.Add(i + 1); }

            TDay.Text = DateTime.Now.Day.ToString();
        }

        private void TYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calendar.SelectionStart = Calendar.SelectionEnd = new DateTime(int.Parse(TYear.Text), 1, DateTime.DaysInMonth(int.Parse(TYear.Text), 1));
        }

        private void BCalc_Click(object sender, EventArgs e) { timetablePresenter.ClickCalculate(); }
    }
}