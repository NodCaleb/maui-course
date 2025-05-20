namespace BMI.Views;

public partial class BmiView : ContentPage
{
	public BmiView()
	{
		InitializeComponent();
        BindingContext = new ViewModels.BmiViewModel();
    }
}