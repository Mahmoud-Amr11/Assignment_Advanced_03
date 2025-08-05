namespace Assignment_Advanced_03
{
    public class Book
    {
        public int ISBN{ get; set; }
        public string Title { get; set; }

        public string[] Authors { get; set; }
        public DateTime PublicationDate{ get; set; }

        public decimal Price{ get; set; }

     

        public Book(int iSBN, string title, string[] authors, DateTime publicationDate, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Authors = authors;
            PublicationDate = publicationDate;
            Price = price;
        }
        override public string ToString()
        {
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {string.Join(", ", Authors)}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
        }
    }
}
