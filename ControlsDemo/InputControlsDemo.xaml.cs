namespace ControlsDemo;

public partial class InputControlsDemo : ContentPage
{
	public InputControlsDemo()
	{
		InitializeComponent();
	}

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
		sliderValueLabel.Text = slider.Value.ToString();
    }

    private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        if (stepper != null)
        {
            stepperValueLabel.Text = stepper.Value.ToString();
        }
    }
}