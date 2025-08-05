namespace Assignment_Advanced_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Considering the Code Below , Write Down the Body of all Listed Methods and Properties , you need to Define fPtr as the following cases:  a.User Defined Delegate Datatypeb.BCL Delegatesc.Anonymous Method(GetISBN)d.Lambda Expression(GetPublicationDate)

            List<Book> books = new List<Book>
            {
                new Book(1, "C# 9.0 in a Nutshell", new[] { "Joseph Albahari", "Ben Albahari" }, new DateTime(2020, 11, 10), 49.99m),
                new Book(2, "Clean Code", new[] { "Robert C. Martin" }, new DateTime(2008, 8, 1), 39.99m),
                new Book(3, "Design Patterns: Elements of Reusable Object-Oriented Software", new[] { "Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides" }, new DateTime(1994, 2, 1), 54.99m),
                new Book(4, "The Pragmatic Programmer", new[] { "Andrew Hunt", "David Thomas" }, new DateTime(1999, 10, 20), 44.99m),
                new Book(5, "Refactoring: Improving the Design of Existing Code", new[] { "Martin Fowler" }, new DateTime(1999, 6, 8), 42.99m)

            };



            //a. User Defined Delegate Datatype
            Console.WriteLine("Books Title");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            Console.WriteLine("==================================");

            Console.WriteLine("Books Authors");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthor);
            Console.WriteLine("==================================");

            Console.WriteLine("Books Price");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);




            //b. BCL Delegates

            Console.WriteLine("==================================");
            Console.WriteLine("Books Title");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);
            Console.WriteLine("==================================");

            Console.WriteLine("Books Authors");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthor);
            Console.WriteLine("==================================");

            Console.WriteLine("Books Price");
            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);




          





            //c. Anonymous Method (GetISBN)
            Console.WriteLine("==================================");
            Console.WriteLine("Books ISBN");

            LibraryEngine.ProcessBooks(books, delegate(Book b){  return b.ISBN;  }  );




            //d. Lambda Expression (GetPublicationDate)
            Console.WriteLine("==================================");
            Console.WriteLine("Books Publication Date");
            LibraryEngine.ProcessBooks(books, x=>x.PublicationDate);

            #endregion
        }
    }
}
