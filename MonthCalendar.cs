private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
{
    MessageBox.Show("Fecha seleccionada: " + e.Start.ToShortDateString());
}
