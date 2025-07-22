using FoolProof.Core;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace AspNet.MVC.Models
{
    public class Author
    {
        private static int _id { get; set; } = 0;
        [DisplayName("ID")]
        public int Id { get; }
        public required string Name { get; set; }
        [DisplayName("Born on")]
        public required DateOnly BirthDate { get; set; }
        [DisplayName("Died on")]
        //[GreaterThan("BirthDate")]
        public DateOnly? DeathDate { get; set; }

        public Author()
        {
            this.Id = ++_id;
        }

        public override string ToString()
        {
            string result = $"{Name} [{BirthDate}]"; 
            return result;
        }
    }
}
