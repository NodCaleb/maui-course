using System.Globalization;

namespace MvvmDemo.MVVM.Converters;

public class BoolConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        var answer = value.ToString();
        if (answer == "YES")
        {
            return true;
        }
        else if (answer == "NO")
        {
            return false;
        }
        else
        {
            return null;
        }
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool)
        {
            return (bool)value ? "YES" : "NO";
        }
        else
        {
            return null;
        }
    }
}
