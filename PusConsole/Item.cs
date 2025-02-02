public class Item {
    public string ID;
    public string ISBN;
    public Availability Status;
    public Item(string id, string isbn, Availability status) {
        ID = id;
        ISBN = isbn;
        Status = status;
    }
}

public enum Availability {
    Available, Not_Available
}