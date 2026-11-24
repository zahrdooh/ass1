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
            //Book book1 = new Book();

            //book1.Title = "The Alchemist";
            //book1.Pages = 208;
            //object obj = book1;
            //Console.WriteLine($"Title: {book1.Title}");
            //Console.WriteLine($"Pages: {book1.Pages}");

            #endregion

            #region question2

            //Book book = new Book();

            //book.Title = "life";
            //book.Pages = 350;

            //Console.WriteLine("ToString(): " + book.ToString());

            //Console.WriteLine("Equals(): " + book.Equals(book));

            //Console.WriteLine("GetHashCode(): " + book.GetHashCode());

            //Console.WriteLine("GetType(): " + book.GetType());

            #endregion

            #region question3
            // int pages = "464";
            //Compile-time error.
            //A type mismatch detected by the compiler is a compile-time error.
            //int pages = 464;
            //Console.WriteLine($"Pages: {pages}");
            #endregion

            #region question4
            //try
            //{
            //    int x = 0;
            //    int result = 10 / x;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}


            #endregion

            #region question5
            //int pages = 300;
            //double result = pages;

            //Console.WriteLine(result);
            #endregion

            #region question6
            //int pages = 300;
            //double result = pages;

            //Console.WriteLine(result);
            #endregion

            #region question7
            //string pagesText = "464";
            //int pages = Convert.ToInt32(pagesText);
            //Console.WriteLine(pages);
            #endregion

            #region question8
            //string yearText = "2023";
            //int year = int.Parse(yearText);

            //Console.WriteLine(year);

            //// Using int.TryParse()
            //string badText = "abc";

            //if (int.TryParse(badText, out int number))
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion

            #region question9
            int pages = 464;
            string pagesText = pages.ToString();
            Console.WriteLine(pagesText);
            Console.WriteLine(pagesText.GetType());
            #endregion

        }
    }
}
