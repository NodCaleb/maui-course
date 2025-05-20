using MvvmDemo.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MvvmDemo.MVVM.ViewModes;

public class CommandsViewModel
{
    public ICommand ClickCommand =>
        new Command(Alert);

    public ICommand SearchCommand { get; }

    public CommandsViewModel()
    {
        SearchCommand = new Command((s) =>
        {
            var data = s as string;
            var window = Application.Current?.Windows.FirstOrDefault();
            if (window?.Page != null)
            {
                window.Page.DisplayAlert("Searched", s.ToString(), "OK");
            }
        });
    }

    private void Alert()
    {
        // Handle the alert event here
        var window = Application.Current?.Windows.FirstOrDefault();
        if (window?.Page != null)
        {
            window.Page.DisplayAlert("Title", "Message", "OK");
        }
    }
}
