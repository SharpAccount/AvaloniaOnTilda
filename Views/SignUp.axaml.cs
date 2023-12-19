using System.Security.AccessControl;
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

    private bool IsLoginValid()
    {
        if (LoginInput.Text is not null)
        {
            if (LoginInput.Text.Length > 2 && LoginInput.Text.Length < 51) return true;
        }
        return false;
    }

    private bool IsEmailValid()
    {
        if (EmailInput.Text is not null)
        {
            if (EmailInput.Text.Length > 5 && EmailInput.Text.Length < 61 && EmailInput.Text.Contains("@")) return true;
        }
        return false;
    }
    
    private bool IsPasswordValid()
    {
        if (PasswordInput.Text is not null)
        {
            if (PasswordInput.Text.Length > 4 && PasswordInput.Text.Length < 51) return true;
        }
        return false;
    }
    
    private void OpenSignIn(object sender, RoutedEventArgs args)
    {
        new SignIn().Show();
        Close();
    }

    private void SubmitData(object sender, RoutedEventArgs args)
    {
        bool isEmailValid = IsEmailValid();
        bool isPasswordValid = IsPasswordValid();
        bool isLoginValid = IsLoginValid();
        if (isEmailValid == false)
        {
            // place for email input borderbrush color changing and etc...
            return;
        }
        if (isPasswordValid == false)
        {
            // place for password input borderbrush color changing and etc...
            return;
        }
        if (isLoginValid == false)
        {
            // place for login input borderbrush color changing and etc...
            return;
        }

        //add user data to DB here...
        OpenSignIn(sender, args);
    }
}