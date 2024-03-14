namespace ConsoleMenuApp;

//The user class represents a database connection. It holds a list of users which can log on to the system
public class User
{
    private Dictionary<string, string> _knownUsers = new Dictionary<string, string>();
    
    // Default constructor. The user doesn't need to provide anything.
    public User()
    {
        this.AddUsers();
    }
    
    //Add Users represents searching a database for users
    private void AddUsers()
    {
        this._knownUsers.Add("elliot@example.org", "password123");
        this._knownUsers.Add("e","e");
    }
    
    // check known users and if found return true
    public bool checkCredentials(string username, string password)
    {
        return _knownUsers.ContainsKey(username) && _knownUsers[username] == password;
    }
}