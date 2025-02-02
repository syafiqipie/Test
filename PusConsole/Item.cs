public class Item {
    public string ID = Utility.RandomString();
    public string ISBN;
    public Availability Status = Availability.Available;
    public Item(string isbn) {
        ISBN = isbn;
    }
}

public enum Availability {
    Not_Available, Available
}