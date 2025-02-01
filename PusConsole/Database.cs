public static class Database
{
    public static Dictionary<string, BookInfo> Books { get; } = SeedBooks();

    private static Dictionary<string, BookInfo> SeedBooks()
    {
        return new();
    }
}