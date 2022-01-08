namespace AutoLotModelFINAL1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class services
    {
        [Key]
        public int IdService { get; set; }

        [StringLength(100)]
        public string Description { get; set; }
    }
}
