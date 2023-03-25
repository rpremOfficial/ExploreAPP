using ExploreAPP.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ExploreAPP.Views;

public sealed partial class ContentGridPage : Page
{
    public ContentGridViewModel ViewModel
    {
        get;
    }

    public ContentGridPage()
    {
        ViewModel = App.GetService<ContentGridViewModel>();
        InitializeComponent();
    }
}
