using DatabindingDemo.Models;
using System.ComponentModel;

namespace DatabindingDemo
{
    public partial class MainPage : ContentPage, INotifyPropertyChanged
    {
        Person _person = new Person();

        public MainPage()
        {
            InitializeComponent();

            _person = new Person
            {
                Name = "John Doe",
                Phone = "123-456-7890",
                Address = "123 Main St, Anytown, USA"
            };

            BindingContext = _person;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            _person.Name = "Jane Doe";
            _person.Phone = "098-765-4321";
            _person.Address = "456 Elm St, Othertown, USA";
        }
    }

}
