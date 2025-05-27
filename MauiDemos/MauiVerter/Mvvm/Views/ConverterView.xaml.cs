using MauiVerter.Mvvm.ViewModels;

namespace MauiVerter.Mvvm.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var viewModel = BindingContext as ConverterViewModel;
        viewModel.Convert();
    }
}