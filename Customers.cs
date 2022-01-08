namespace AutoLotModelFINAL1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customers
    {
        [Key]
        public int CustId { get; set; }

        [Column("First Name")]
        [StringLength(50)]
        public string First_Name { get; set; }

        [Column("Last Name")]
        [StringLength(50)]
        public string Last_Name { get; set; }
    }
}
