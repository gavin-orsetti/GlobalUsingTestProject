using GlobalUsingTestProject.MVVM.ViewModels;

namespace GlobalUsingTestProject.MVVM.Views;

public partial class DisplayListPage : ContentPage
{
    public DisplayListPage( DisplayPageViewModel viewModel )
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}