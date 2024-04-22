namespace WebDataExample
{
    public static class Info
    {
        public static List<string> AllWords { get; } = new();

        public static void AddWord(string s)
        {
            AllWords.Add(s);
        }
    }
}
