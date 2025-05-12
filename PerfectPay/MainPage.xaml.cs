namespace PerfectPay
{
    public partial class MainPage : ContentPage
    {
        decimal bill;
        int tip;
        int noPersons = 1;

        public MainPage()
        {
            InitializeComponent();
        }

        private void xtxBill_Completed(object sender, EventArgs e)
        {
            bill = decimal.Parse(xtxBill.Text);
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            var totalTip = (bill * tip) / 100;

            var tipByPerson = (totalTip / noPersons);
            lvlTipByPerson.Text = $"{tipByPerson:C}";

            var subtotal = (bill / noPersons);
            lvlSubtotal.Text = $"{subtotal:C}";

            var totalByPerson = (bill + totalTip) / noPersons;
            lvlTotal.Text = $"{totalByPerson:C}";
        }

        private void sldTip_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            tip = (int)sldTip.Value;
            lvlTip.Text = $"Tip: {tip}%";
            CalculateTotal();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                var btn = (Button)sender;
                var percentage = int.Parse(btn.Text.Replace("%", ""));
                sldTip.Value = percentage;
            }
        }

        private void btnMinus_Clicked(object sender, EventArgs e)
        {
            if (noPersons > 1)
            {
                noPersons--;
            }
            lblNoPersons.Text = noPersons.ToString();
            CalculateTotal();
        }

        private void btnPlus_Clicked(object sender, EventArgs e)
        {
            noPersons++;
            lblNoPersons.Text = noPersons.ToString();
            CalculateTotal();
        }
    }
}
