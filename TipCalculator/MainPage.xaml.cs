namespace TipCalculator
{
    public partial class MainPage : ContentPage
    {
        double Bill = 0, Tip = 0, Total = 0, TipPercent = 0.15;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SetLowTipButton_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 15;
        }

        private void SetHighTipButton_Clicked(object sender, EventArgs e)
        {
            TipSlider.Value = 20;
        }

        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
            
        }

        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {
           
        }

        private void TipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            LabelPercent.Text = TipSlider.Value.ToString("#.##") + "%";
            TipPercent = TipSlider.Value / 100;
            Tip = Bill * TipPercent;
            Total = Bill + Tip;
            TipLabel.Text = Tip.ToString("C");
            TotalLabel.Text = Total.ToString("C");
        }

        private void EntryAmount_TextChanged(object sender, TextChangedEventArgs e)
        {
            Bill = float.Parse(EntryAmount.Text);
            Tip = Bill * TipPercent;
            Total = Bill + Tip;
            TipLabel.Text = Tip.ToString("C");
            TotalLabel.Text = Total.ToString("C");
        }
    }

}
