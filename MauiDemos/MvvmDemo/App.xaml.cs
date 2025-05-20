using MvvmDemo.MVVM.Views;

namespace MvvmDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new CommandsView());
        }
    }
}