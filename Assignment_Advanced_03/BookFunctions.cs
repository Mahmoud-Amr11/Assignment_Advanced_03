namespace Assignment_Advanced_03
{
    public static class BookFunctions { 
        public static string GetTitle(Book book)
        {
          
          return book.Title;

        }
        public static string GetAuthor(Book book)
        {

            return string.Join(", ", book.Authors);

        }
        public static string GetPrice(Book book)
        {

            return book.Price.ToString();

        }
    }
}
