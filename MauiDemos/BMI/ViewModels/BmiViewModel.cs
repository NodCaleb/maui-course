using BMI.Models;
using PropertyChanged;

namespace BMI.ViewModels;


public class BmiViewModel
{
    public Bmi Bmi { get; set; }

    public BmiViewModel()
    {
        Bmi = new Bmi
        {
            Height = 180,
            Weight = 73
        };
    }
}
