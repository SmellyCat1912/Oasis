namespace Oasis.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Theatre")]
    public partial class Theatre
    {
        [Column(TypeName = "numeric")]
        public decimal Id { get; set; }

        [Required]
        [StringLength(10)]
        public string name { get; set; }

        [Required]
        [StringLength(10)]
        public string desc { get; set; }

        [Required]
        public string location { get; set; }
    }
}
