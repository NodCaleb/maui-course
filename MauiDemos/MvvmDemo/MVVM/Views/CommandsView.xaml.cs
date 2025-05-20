using MvvmDemo.MVVM.ViewModes;

namespace MvvmDemo.MVVM.Views;

public partial class CommandsView : ContentPage
{
	public CommandsView()
	{
		InitializeComponent();
        BindingContext = new CommandsViewModel();
    }
}