namespace Oasis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("film")]
    public partial class film
    {
        [Column(TypeName = "numeric")]
        public decimal Id { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Name")]
        public string name { get; set; }

        [Required]
        [StringLength(10)]
        public string desc { get; set; }

        [Column(TypeName = "date")]
        public DateTime start_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime end_date { get; set; }

        public int price { get; set; }

        [Required]
        [StringLength(10)]
        public string theatre_id { get; set; }
    }
}
