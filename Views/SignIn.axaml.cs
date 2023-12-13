using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaTilda.Views;

public partial class SignIn : Window
{
    public SignIn()
    {
        InitializeComponent();
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