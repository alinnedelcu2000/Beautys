namespace AutoLotModelFINAL1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        [Column("employees")]
        [StringLength(100)]
        public string employees1 { get; set; }
    }
}
