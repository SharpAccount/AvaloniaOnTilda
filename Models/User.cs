namespace AvaloniaTilda.Models;

public class User
{
    public string Login { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public User(string login, string email, string password)
    {
        Login = login;
        Email = email;
        Password = password;
    }
}