using GlobalUsingTestProject.MVVM.ViewModels;

namespace GlobalUsingTestProject
{
    public partial class App : Application
    {
        public App( MainPageViewModel pageVM )
        {
            InitializeComponent();

            MainPage = new AppShell( pageVM );
        }
    }
}
