using GlobalUsingTestProject.MVVM.ViewModels;

namespace GlobalUsingTestProject
{
    public partial class MainPage : ContentPage
    {
        public MainPage( MainPageViewModel viewModel )
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }

}
