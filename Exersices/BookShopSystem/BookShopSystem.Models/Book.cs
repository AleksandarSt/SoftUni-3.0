using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShopSystem.Models
{
    public class Book
    {
        public Book()
        {
            this.Categories=new HashSet<Category>();
        }

        [Key]
        public int Id { get; set; }

        [Range(0,50),Required]
        public string Title { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public EditionTypes EditionType { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public int Copies { get; set; }

        public DateTime ReleaseDate { get; set; }
        
        public virtual Author Author { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

        [Required]
        public AgeRestrictions AgeRestriction { get; set; }
    }

    public enum EditionTypes
    {
        Normal,
        Promo,
        Gold
    }

    public enum AgeRestrictions
    {
        Minor,
        Teen,
        Adult
    }
}
