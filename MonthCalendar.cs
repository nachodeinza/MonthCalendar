using System;
using System.Windows.Forms;

namespace EjemploMonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show("Fecha seleccionada: " + e.Start.ToShortDateString());
        }
    }
}


