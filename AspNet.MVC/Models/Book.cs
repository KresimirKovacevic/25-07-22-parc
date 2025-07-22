using System.ComponentModel;

namespace AspNet.MVC.Models
{
    public class Book
    {
        private static int _id { get; set; } = 0;
        [DisplayName("ID")]
        public int Id { get; }
        [DisplayName("Title")]
        public required string Name { get; set; }
        public Author Author { get; set; }
        [DisplayName("Release Date")]
        public required DateOnly PublishDate { get; set; }
        public string? Description { get; set; }

        public Book()
        {
            this.Id = ++_id;
        }
    }
}
