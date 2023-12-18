using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaTilda.ViewModels;

namespace AvaloniaTilda.Views;

public partial class SignIn : Window
{
    public SignIn()
    {
        InitializeComponent();
        DataContext = new SignInViewModel();
    }

    private void OpenSignUp(object sender, RoutedEventArgs args)
    {
        // -- place for checks --
        new SignUp().Show();
        Hide();
    }

    private void OpenMainWindow(object sender, RoutedEventArgs args)
    {
        new MainWindow().Show();
        Hide();
    }
}