using System.Collections.Generic;
using System.Drawing;
using System.Security.AccessControl;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Brushes = Avalonia.Media.Brushes;

namespace AvaloniaTilda.Views;

public partial class SignUp : Window
{
    public SignUp()
    {
        InitializeComponent();
    }

    private static string currentLogin;
    private static string currentPassword;
    
    public static Dictionary<string, string> getUserInfo()
    {
        return new Dictionary<string, string>() {{"login", currentLogin}, { "password", currentPassword } };
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
        LogInputBorder.BorderBrush = Brushes.Transparent;
        PasswordInputBorder.BorderBrush = Brushes.Transparent;
        EmailInputBorder.BorderBrush = Brushes.Transparent;
        bool isEmailValid = IsEmailValid();
        bool isPasswordValid = IsPasswordValid();
        bool isLoginValid = IsLoginValid();
        if (isLoginValid == false)
        {
            LogInputBorder.BorderBrush = Brushes.Red;
            return;
        }
        else if (isEmailValid == false)
        {
            EmailInputBorder.BorderBrush = Brushes.Red;
            return;
        }
        else if (isPasswordValid == false)
        {
            PasswordInputBorder.BorderBrush = Brushes.Red;
            return;
        }
        //add user data to DB here...
        currentLogin = LoginInput.Text;
        currentPassword = PasswordInput.Text;
        OpenSignIn(sender, args);
    }
}