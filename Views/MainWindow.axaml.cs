using System.Collections.Generic;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaTilda.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        setGreetings();
    }

    private Dictionary<string, string> userInfo = SignUp.getUserInfo();
    
    private void setGreetings()
    {
        Greetings.Text = $"Welcome, {userInfo["login"]}\nWith {userInfo["password"]} pass!";
    }
}