namespace AutoLotModelFINAL1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Hairstyle")]
    public partial class Hairstyle
    {
        [Key]
        public int idHair { get; set; }

        public int? idEmp { get; set; }

        public int? idService { get; set; }
    }
}
