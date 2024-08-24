namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void setHighTip_Clicked(object sender, EventArgs e)
        {
            tipSlider.Value = 20;
            LabelPercent.Text = tipSlider.Value.ToString() + "%";
        }

        private void RoundUp_Clicked(object sender, EventArgs e)
        {

        }

        private void RoundDown_Clicked(object sender, EventArgs e)
        {

        }

        private void setLowTip_Clicked(object sender, EventArgs e)
        {
            tipSlider.Value = 15;
            LabelPercent.Text = tipSlider.Value.ToString() + "%";
        }

        private void tipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LabelPercent.Text = tipSlider.Value.ToString("#.##") + "%";
        }

        private void EntryAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            double Valor = Convert.ToDouble(EntryAmount.Text);
            double ValorDaGorjeta = Valor * (tipSlider.Value / 100);
            double ValorTotal = ValorDaGorjeta + Valor;

            LabelTotal.Text = ValorTotal.ToString();
            TipLabel.Text = ValorDaGorjeta.ToString();

        }
    }

}
