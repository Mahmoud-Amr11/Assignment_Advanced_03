namespace Assignment_Advanced_03
{

    // User Defined Delegate Datatype
    public delegate string Filter(Book book);




    public class LibraryEngine { 
      public static void ProcessBooks<T>(List<Book> books, Func<Book,T> fPtr)
      {
          foreach (var book in books)
          {
              Console.WriteLine(fPtr(book));
          }
        }

    }
}
