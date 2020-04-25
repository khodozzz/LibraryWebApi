namespace Library.Domain.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        
        public Author Author { get; set; }
    }
}