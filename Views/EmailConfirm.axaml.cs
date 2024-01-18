using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaTilda.Views;

public partial class EmailConfirm : Window
{
    public EmailConfirm()
    {
        InitializeComponent();
    }
    private void OpenSignIn(object sender, RoutedEventArgs args)
    {
        new SignIn().Show();
        Close();
    }
    
    private void OpenSignUp(object sender, RoutedEventArgs args)
    {
        new SignUp().Show();
        Close();
    }
}