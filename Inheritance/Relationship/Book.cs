using System.Collections.Generic;

namespace Inheritance.Relationship
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public List<Author> Authors { get; set; }
    }
}
