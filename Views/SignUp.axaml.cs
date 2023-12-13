using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AvaloniaTilda.Views;

public partial class SignUp : Window
{
    public SignUp()
    {
        InitializeComponent();
    }
    
    public void OpenSignIn(object sender, RoutedEventArgs args)
    {
        // -- all checks here --
        new SignIn().Show();
        Hide();
    }
}