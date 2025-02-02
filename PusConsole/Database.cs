using Newtonsoft.Json;

public static class Database
{
    public static Dictionary<string, BookInfo> Books { get; set;} = new();
    const string BooksDatabaseFileName = "SavedBooks.json";

    public static void LoadBooks() {
        if (File.Exists(BooksDatabaseFileName)) {
            string json = File.ReadAllText(BooksDatabaseFileName);
            Books = JsonConvert.DeserializeObject<Dictionary<string, BookInfo>>(json) ?? new();
        }
    }

    public static void SaveBook() {
        string json = JsonConvert.SerializeObject(Books, Formatting.Indented);
        File.WriteAllText(BooksDatabaseFileName, json);
    }

    public static void AddBook() {
        Console.WriteLine("Enter book info");
        string isbn = Form.AskNonEmptyString("ISBN : ");
        string title = Form.AskNonEmptyString("Title : ");
        string author = Form.AskNonEmptyString("Author : ");

        BookInfo info = new(isbn,title,author);

        Books.Add(isbn, info);

        SaveBook();
        Items.Add(new(isbn));
        SaveItems();
        Console.WriteLine("Book saved!");
    }

    public static void DisplayBooks() {
        if (Books.Count == 0) {
            Console.WriteLine("Add some book to see.");
        }
        else {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("           All Book Data           ");
            Console.WriteLine("-----------------------------------");
            foreach (BookInfo book in Books.Values) {
                Console.WriteLine($"Title : {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"ISBN  : {book.ISBN}");
                Console.WriteLine($"{Utility.Stock(book.ISBN)} in stock.");
                Console.WriteLine("-----------------------------------");
            }
        }
    }

    public static void SearchBook() {
        string keyword = Form.AskNonEmptyString("Enter ISBN : ");
        if (Books.ContainsKey(keyword)) {
            Console.WriteLine("-----------Search Result-----------");
            Console.WriteLine($"Title : {Books[keyword].Title}");
            Console.WriteLine($"Author: {Books[keyword].Author}");
            Console.WriteLine($"{Utility.Stock(Books[keyword].ISBN)} item(s) in stock.");
            Console.WriteLine("-----------------------------------");
        }
        else Console.WriteLine("Book not found.");
    }

    public static List<Item> Items { get; set;} = new();
    const string ItemsDatabaseFileName = "AvailableItems.json";

    public static void LoadItems() {
        if (File.Exists(ItemsDatabaseFileName)) {
            string json = File.ReadAllText(ItemsDatabaseFileName);
            Items = JsonConvert.DeserializeObject<List<Item>>(json) ?? new();
        }
    }

    public static void SaveItems() {
        string json = JsonConvert.SerializeObject(Items, Formatting.Indented);
        File.WriteAllText(ItemsDatabaseFileName, json);
    }

    public static void AddItems() {
        string isbn = Form.AskNonEmptyString("Enter ISBN : ");
        int n = Form.AskPositiveInteger("How many items? ");
        for (int i = 1; i <= n; i++) {
            Item newitem = new(isbn);
            Items.Add(newitem);
        }
        SaveItems();
        Console.WriteLine("Items added!");
    }
}