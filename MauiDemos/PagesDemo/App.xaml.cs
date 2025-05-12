namespace PagesDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navPage = new NavigationPage(new MainPage());

            navPage.BarBackground = Colors.Chocolate;
            navPage.BarTextColor = Colors.White;

            return new Window(new TabbedPageDemo());
        }
    }
}