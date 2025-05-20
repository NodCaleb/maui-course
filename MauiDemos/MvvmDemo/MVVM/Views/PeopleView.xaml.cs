using MvvmDemo.MVVM.ViewModes;

namespace MvvmDemo.MVVM.Views;

public partial class PeopleView : ContentPage
{
	public PeopleView()
	{
		InitializeComponent();
        BindingContext = new PeopleViewModel();
    }
}