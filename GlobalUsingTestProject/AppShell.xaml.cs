using GlobalUsingTestProject.MVVM.ViewModels;

namespace GlobalUsingTestProject
{
    public partial class AppShell : Shell
    {
        public AppShell( MainPageViewModel page )
        {
            InitializeComponent();
            Routing.RegisterRoute( Routes.DisplayPage_PageName, Routes.DisplayPage_PageType );
            BindingContext = page;
        }
    }
}
