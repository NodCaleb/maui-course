
using PropertyChanged;
using System.Windows.Input;

namespace Calculator.MVVM.ViewModels;

[AddINotifyPropertyChangedInterface]
public class CalcViewModel
{
    public string Formula { get; set; }
    public string Result { get; set; } = "0";

    public ICommand OperationCommand =>
        new Command((number) =>
        {
            Formula += number;
        });

    public ICommand ResetCommand =>
        new Command(() =>
        {
            Formula = string.Empty;
            Result = "0";
        });

    public ICommand BackspaceCommand =>
        new Command(() =>
        {
            if (Formula.Length > 0)
            {
                Formula = Formula.Remove(Formula.Length - 1);
            }
        });

    public ICommand CalculateCommand =>
        new Command(() =>
        {
            if (string.IsNullOrEmpty(Formula))
            {
                Result = "0";
                return;
            }

            try
            {
                var result = Dangl.Calculator.Calculator.Calculate(Formula);
                Result = result.Result.ToString();
            }
            catch
            {
                Result = "Error";
            }
        });
}
