using Newtonsoft.Json;

public static class Database
{
    public static Dictionary<string, BookInfo> Books { get; set;} = SeedBooks();

    private static Dictionary<string, BookInfo> SeedBooks()
    {
        return new();
    }

    const string FileName = "SavedBooks.json";

    public static void LoadBooks() {
        if (File.Exists(FileName)) {
            string json = File.ReadAllText(FileName);
            Books = JsonConvert.DeserializeObject<Dictionary<string, BookInfo>>(json) ?? new();
        }
    }

    public static void SaveBook() {
        string json = JsonConvert.SerializeObject(Books, Formatting.Indented);
        File.WriteAllText(FileName, json);
    }

    public static void AddBook() {
        Console.WriteLine("Enter book info");
        string isbn = Form.AskNonEmptyString("ISBN : ");
        string title = Form.AskNonEmptyString("Title : ");
        string author = Form.AskNonEmptyString("Author : ");

        BookInfo info = new(isbn,title,author);

        Books.Add(isbn, info);

        SaveBook();
        Console.WriteLine("Book saved!");
    }

    public static void DisplayBooks() {
        if (Books.Count == 0) {
            Console.WriteLine("Add some book to see.");
        }
        else {
            foreach (BookInfo book in Books.Values) {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"Title : {book.Title}");
                Console.WriteLine($"Author: {book.Author}");
                Console.WriteLine($"ISBN  : {book.ISBN}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }

    public static void SearchBook() {
        string keyword = Form.AskNonEmptyString("Enter ISBN : ");
        if (Books.ContainsKey(keyword)) {
            Console.WriteLine($"{Books[keyword].Title} by {Books[keyword].Author}");
        }
        else Console.WriteLine("Book not found.");
    }
}