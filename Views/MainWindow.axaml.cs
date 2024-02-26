using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.LogicalTree;
using Avalonia.Markup.Xaml;
using AvaloniaTilda.Models;
using AvaloniaTilda.ViewModels;
namespace AvaloniaTilda.Views;

public partial class MainWindow : Window
{
    private List<User> _selectedUsers = new List<User>();
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void OpenShowUsers(string login, string email, string password)
    {
        new ShowUsers(_selectedUsers).Show();
    }
    
    public void Foo(object? sender, PointerPressedEventArgs args)
    {
        if (sender is StackPanel stackPanel)
        {
            var children = stackPanel.GetLogicalChildren().ToList();
            if (children[0] is TextBlock log && children[1] is TextBlock email && children[2] is TextBlock pass)
            {
                _selectedUsers.Add(new User(log.Text, email.Text, pass.Text));
            }
        }
    }
}