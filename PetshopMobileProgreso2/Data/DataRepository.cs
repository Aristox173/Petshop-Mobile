public static class DataRepository
{
    private static readonly List<User> _users = new List<User>
    {
        new User { Username = "juanaristi2001@gmail.com", Password = "12345678" },
        new User { Username = "usuario2", Password = "contraseña2" },
    };

    public static List<User> GetUsers()
    {
        return _users;
    }
}

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
}