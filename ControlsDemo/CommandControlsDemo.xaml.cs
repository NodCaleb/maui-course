namespace ControlsDemo;

public partial class CommandControlsDemo : ContentPage
{
	public CommandControlsDemo()
	{
		InitializeComponent();
	}

    private void btnTest_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Test", "Test button clicked", "OK");
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        DisplayAlert("RadioButton", $"Option {e.Value} selected", "OK");
    }

    private void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Search", $"Searching for {searchBar.Text}", "OK");
    }

    private void SwipeItem_Invoked(object sender, EventArgs e)
    {

    }
}