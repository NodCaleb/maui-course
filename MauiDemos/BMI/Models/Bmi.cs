using PropertyChanged;

namespace BMI.Models;

[AddINotifyPropertyChangedInterface]
public class Bmi
{
    public float Height { get; set; }
    public float Weight { get; set; }
    public float Result => Weight / ((Height / 100) * (Height / 100));
    public string Category
    {
        get
        {
            if (Result < 18.5)
                return "Underweight";
            else if (Result < 24.9)
                return "Normal weight";
            else if (Result < 29.9)
                return "Overweight";
            else
                return "Obesity";
        }
    }
}
