using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DatabindingDemo.Models;

public class Person : INotifyPropertyChanged
{
    private string name;
    private string phone;
    private string address;

    public string Name { get => name;
        set {
            if (name != value)
            {
                name = value;
                OnPropertyChanged();
            }
        }
    }
    public string Phone
    {
        get => phone;
        set
        {
            phone = value;
            OnPropertyChanged();
        }
    }
    public string Address
    {
        get => address;
        set
        {
            address = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
