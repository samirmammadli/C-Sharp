using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneFeWinForms
{
    public partial class Choose_Period : Form
    {
        private List<string> Date { get; }
        private DateTime SelectedDate { get; }
        public Choose_Period(List<string> date, DateTime selectedDate)
        {
            InitializeComponent();
            if (date.Count >= 5)
            {
                btnYear.Text = date[0];
                btnMonth.Text = date[1];
                btnWeek.Text = date[2];
                btnDay.Text = date[3];
                tbChooseDate.Text = date[4];

                SelectedDate = selectedDate;
            }
        }

    }
}
