using MvvmDemo.MVVM.Models;

namespace MvvmDemo.MVVM.ViewModes;

public class ConvertersViewModel
{
    public Data Data { get; set; }

    public ConvertersViewModel()
    {
        Data = new Data
        {
            Married = "YES"
        };
    }
}
