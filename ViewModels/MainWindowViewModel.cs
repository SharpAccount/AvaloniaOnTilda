using System.Collections.Generic;
using Avalonia.Controls;
using AvaloniaTilda.Views;

namespace AvaloniaTilda.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly Dictionary<int, Control> Pages = new Dictionary<int, Control>
    {
        {0, new SignIn()},
        {1, new SignUp()}
    };
}