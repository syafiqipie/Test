public static class Utility
{
    public static string RandomString()
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        char[] stringChars = new char[8];
        Random random = new();

        for (int i = 0; i < stringChars.Length; i++)
        {
            stringChars[i] = chars[random.Next(chars.Length)];
        }

        return new string(stringChars);
    }
    
    public static string Stock(string isbn) {
        int n = 0;
        int m = 0;
        foreach (Item item in Database.Items) {
            if (item.ISBN == isbn) {
                if (item.Status == Availability.Available) n++;
                m++;
            }
        }
        return $"{n}/{m}";
    }
}