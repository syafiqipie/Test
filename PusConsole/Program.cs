Database.LoadBooks();
Database.LoadItems();

List<string> menus = ["A", "B", "C", "D", "Q"];
string question = """
Input A to view the book data,
Input B to add a book,
Input C to search books by ISBN,
Input D to add items,
Input Q to quit
""";
string menuChoice = Form.AskMultipleChoices(question, menus);

while(menuChoice is not "Q")
{
    if(menuChoice is "A")
    {
        // do something with Database.Books
        Database.DisplayBooks();
        menuChoice = Form.AskMultipleChoices(question, menus);
    }
    else if(menuChoice is "B")
    {
        // do something with Database.Books
        Database.AddBook();
        menuChoice = Form.AskMultipleChoices(question, menus);
    }
    else if(menuChoice is "C")
    {
        Database.SearchBook();
        menuChoice = Form.AskMultipleChoices(question, menus);
    }
    else if (menuChoice is "D")
    {
        Database.AddItems();
        menuChoice = Form.AskMultipleChoices(question, menus);
    }
}
Console.WriteLine("Goodbye!");