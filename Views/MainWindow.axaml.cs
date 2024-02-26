using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using AvaloniaTilda.Models;
using AvaloniaTilda.ViewModels;
namespace AvaloniaTilda.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }

    private void OpenShowUsers(string login, string email, string password)
    {
        //open showusers(ObservableCollection<> =  new ObservableCollection<> {login, email, pass})
    }

    public void foo(object? sender, PointerPressedEventArgs args)
    {
        ListBoxItem items;
    }
}