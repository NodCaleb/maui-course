using MvvmDemo.MVVM.ViewModes;

namespace MvvmDemo.MVVM.Views;

public partial class ConvertersView : ContentPage
{
	public ConvertersView()
	{
		InitializeComponent();
        BindingContext = new ConvertersViewModel();
    }
}