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
    }

    private void OpenMainWindow(object sender, RoutedEventArgs args)
    {
        if (EmailInput.Text == null) return;
        new MainWindow().Show();
        Close(); 
    }

    private void OpenSignUp(object sender, RoutedEventArgs args)
    {
        // -- place for checks --
        new SignUp().Show();
        Close();
    }

    private void OpenEmailConfirm(object sender, RoutedEventArgs args)
    {
        new EmailConfirm().Show();
        Close();
    }
    private void OpenSignIn(object sender, RoutedEventArgs args)
    {
        new SignIn().Show();
        Close();
    }
    
    private bool IsEmailValid()
    {
        if (EmailInput.Text is not null)
        {
            if (EmailInput.Text.Length > 5 && EmailInput.Text.Length < 61 && EmailInput.Text.Contains("@")) return true;
        }
        return false;
    }
    
    private void Login(object sender, RoutedEventArgs args)
    {
        if (EmailInput.Text is not null)
        {
            bool isEmailValid = IsEmailValid();
            if (isEmailValid == false)
            {
                return;
            }
            else
            {
                OpenMainWindow(sender, args);
            }
        }
    }
}