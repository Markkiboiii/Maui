namespace TentakompletteringMaui;
using TentakompletteringMaui.ViewModels;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new FriendListViewModel();
    }
}
