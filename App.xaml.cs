namespace PagesDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();

            var navPage = new NavigationPage(new MainPage());

            navPage.BarBackgroundColor = Colors.Black;
            navPage.BarTextColor = Colors.White;


            //MainPage = navPage;

            MainPage = new FlyoutPageDemo();

        }
    }
}
