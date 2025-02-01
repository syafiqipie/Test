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
        menuChoice = Form.AskMutlipleChoices(question, menus);
    }
    else if(menuChoice is "B")
    {
        // do something with Database.Books
        menuChoice = Form.AskMutlipleChoices(question, menus);
    }
}
Console.WriteLine("Goodbye!");