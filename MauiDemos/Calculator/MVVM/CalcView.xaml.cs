namespace Calculator.MVVM;

public partial class CalcView : ContentPage
{
	public CalcView()
	{
		InitializeComponent();
		BindingContext = new ViewModels.CalcViewModel();
    }
}