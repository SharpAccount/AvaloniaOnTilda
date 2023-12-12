using System.Collections.Generic;
using Avalonia.Controls;

namespace AvaloniaTilda.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private readonly Dictionary<int, Control> Pages = new Dictionary<int, Control>
    {
        
    };
    public string Greeting => "Welcome to Avalonia!";
}