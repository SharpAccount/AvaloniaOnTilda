namespace AvaloniaTilda.ViewModels;

public class ShowUsersViewModel
{
    private string _login;
    private string _email;
    private string _password;
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
}