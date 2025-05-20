using MvvmDemo.MVVM.Models;

namespace MvvmDemo.MVVM.ViewModes;

public class PersonViewModel
{
    public Person Person { get; set; }

    public PersonViewModel()
    {
        Person = new Person
        {
            Name = "John Doe",
            Age = 30,
            BirtDate = new DateTime(1993, 1, 1),
            Married = false,
            Weight = 70,
            LunchTime = new TimeSpan(12, 0, 0)
        };
    }
}
