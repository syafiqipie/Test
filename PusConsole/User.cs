public class User {
    public UserCategory Cat;
    public string Username;
    public User(UserCategory cat, string username) {
        Cat = cat;
        Username = username;
    }
}

public enum UserCategory {
    Librarian, Patron
}