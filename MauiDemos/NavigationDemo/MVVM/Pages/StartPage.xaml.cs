using NavigationDemo.MVVM.ViewModels;
using NavigationDemo.Utilities;

namespace NavigationDemo.MVVM.Pages;

public partial class StartPage : ContentPage
{
	public StartPage()
	{
		InitializeComponent();
        BindingContext = new StartPageViewModel();
    }

    protected override bool OnBackButtonPressed()
    {
        // Handle back button press here if needed
        return true; // Return true to prevent the default behavior
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        NavUtilities.Examine(Navigation);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        var currentViewModel = (StartPageViewModel)BindingContext;

        Navigation.PushAsync(new Page2
        {
            BindingContext = new Page2ViewModel
            {
                Name = currentViewModel.Name
            }
        });
    }
}