using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDemo.MVVM.Models;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirtDate { get; set; }
    public bool Married { get; set; }
    public int Weight { get; set; }
    public TimeSpan LunchTime { get; set; }
}
