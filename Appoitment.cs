namespace AutoLotModelFINAL1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appoitment")]
    public partial class Appoitment
    {
        [Key]
        public int IdApp { get; set; }

        public int? idHair { get; set; }

        public int? idCust { get; set; }
    }
}
