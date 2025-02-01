List<string> menus = ["A", "B", "Q"];
string question = """
Input A to view the book data,
Input B to add a book,
Input Q to quit
""";
string menuChoice = Form.AskMutlipleChoices(question, menus);

while(menuChoice is not "Q")
{
    if(menuChoice is "A")
    {
        // do something with Database.Books
        foreach (BookInfo book in Database.Books.Values) {
            Console.WriteLine(book.Title);
        }
        menuChoice = Form.AskMutlipleChoices(question, menus);
    }
    else if(menuChoice is "B")
    {
        // do something with Database.Books
        string input = Console.ReadLine();
        List<string> data = new(input.Split(" | "));
        BookInfo book = new (data[0],data[1],data[2]);
        Database.Books.Add(data[0], book);
        menuChoice = Form.AskMutlipleChoices(question, menus);
    }
}
Console.WriteLine("Goodbye!");