using MauiVerter.Mvvm.ViewModels;

namespace MauiVerter.Mvvm.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var element = sender as Grid;
        var option = ((Label)element.Children.LastOrDefault()).Text;
        var converterView = new ConverterView
        {
            BindingContext = new ConverterViewModel(option)
        };
        Navigation.PushAsync(converterView);
    }
}