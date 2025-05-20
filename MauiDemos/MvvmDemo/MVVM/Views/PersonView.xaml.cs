using MvvmDemo.MVVM.ViewModes;

namespace MvvmDemo.MVVM.Views;

public partial class PersonView : ContentPage
{
	public PersonView()
	{
		InitializeComponent();

        BindingContext = new PersonViewModel();
    }
}