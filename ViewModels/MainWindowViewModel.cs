using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Avalonia.Controls;
using AvaloniaTilda.Models;
using AvaloniaTilda.Views;
using ReactiveUI;

namespace AvaloniaTilda.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _login;
    private string _email;
    private string _password;
    private static ObservableCollection<User> _users = new ();

    public string Login
    {
        get => _login;
        set => _login = value;
    }
    
    public string Email
    {
        get => _email;
        set => _email = value;
    }
    
    public string Password
    {
        get => _password;
        set => _password = value;
    }
    
    public ObservableCollection<User> Users
    {
        get => _users;
        set => _users = value;
    }
    
    public void AddUser()
    {
        if (IsLoginValid(_login) && IsPasswordValid(_password) && IsEmailValid(_email) && IsElementInCollection(_login, _email))
        {
            User newUser = new User(_login, _email, _password);
            Users.Add(newUser);
        }
    }
    
    private bool IsLoginValid(string log)
    {
        if (log is not null)
        {
            if (log.Length > 2 && log.Length < 51) return true;
        }
        return false;
    }

    private bool IsEmailValid(string email)
    {
        if (email is not null)
        {
            if (email.Length > 5 && email.Length < 61 && email.Contains("@")) return true;
        }
        return false;
    }
    
    private bool IsPasswordValid(string pass)
    {
        if (pass is not null)
        {
            if (pass.Length > 4 && pass.Length < 51) return true;
        }
        return false;
    }

    private bool IsElementInCollection(string log, string email)
    {
        foreach (User user in _users)
        {
            if (user.Login == log || user.Email == email)
            {
                return false;
            }
        }
        return true;
    }
    
}