namespace ass1
{
    class Book
    {
        public string? Title;
        public int Pages;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            Book book1 = new Book();

            book1.Title = "The Alchemist";
            book1.Pages = 208;
            object obj = book1;
            Console.WriteLine($"Title: {book1.Title}");
            Console.WriteLine($"Pages: {book1.Pages}");
            #endregion
        }
    }
}
