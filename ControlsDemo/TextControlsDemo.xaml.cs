using System.Diagnostics;

namespace ControlsDemo;

public partial class TextControlsDemo : ContentPage
{
	public TextControlsDemo()
	{
		InitializeComponent();
	}

    private void entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		Debug.WriteLine($"Text changed from {e.OldTextValue} to {e.NewTextValue}");
    }

    private void entry_Completed(object sender, EventArgs e)
    {

    }
}