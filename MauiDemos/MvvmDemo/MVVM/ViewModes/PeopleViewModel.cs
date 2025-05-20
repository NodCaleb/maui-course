using MvvmDemo.MVVM.Models;

namespace MvvmDemo.MVVM.ViewModes
{
    public class PeopleViewModel
    {
        public List<Person> People { get; set; }

        public PeopleViewModel()
        {
            People = new List<Person>
            {
                new Person
                {
                    Name = "John Doe",
                    Age = 30,
                    BirtDate = new DateTime(1993, 1, 1),
                    Married = false,
                    Weight = 70,
                    LunchTime = new TimeSpan(12, 0, 0)
                },
                new Person
                {
                    Name = "Jane Smith",
                    Age = 25,
                    BirtDate = new DateTime(1998, 5, 15),
                    Married = true,
                    Weight = 60,
                    LunchTime = new TimeSpan(13, 0, 0)
                }
            };
        }
    }
}
