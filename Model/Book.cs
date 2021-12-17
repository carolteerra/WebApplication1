using System;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Model.Base;

namespace WebApplication1.Model {
    [Table("books")]
    public class Book : BaseEntity {
        [Column("title")]
        public string Title { get; set; }

        [Column("author")]
        public string Author { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
    }



}
