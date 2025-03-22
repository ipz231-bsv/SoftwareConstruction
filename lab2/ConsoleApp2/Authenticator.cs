public class Authenticator
{
    private static Authenticator _instance = null!;
    private static readonly object _lock = new object();

    private Authenticator() { }

    public static Authenticator Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Authenticator();
                }
                return _instance;
            }
        }
    }

    public void Authenticate(string username, string password)
    {
        Console.WriteLine($"Authenticating user: {username}");
    }
}
