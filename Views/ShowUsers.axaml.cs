using System.Collections.Generic;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using AvaloniaTilda.Models;
using AvaloniaTilda.ViewModels;

namespace AvaloniaTilda.Views;

public partial class ShowUsers : Window
{
    public List<User> SelectedUsers;
    public ShowUsers(List<User> selectedUsers)
    {
        InitializeComponent();
        DataContext = new ShowUsersViewModel();
        SelectedUsers = selectedUsers;
    }
}