using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace BookDotnetCore.Entity
{
    public class BookDetails
    {
        [Key]//pk
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//identity column
        public int BookId { get; set; } //no need to enter any value since it is identity column
        public string BookName { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public string BookCategory { get; set; }
    }
}
