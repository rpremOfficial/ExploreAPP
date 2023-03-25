using ExploreAPP.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ExploreAPP.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }
}
