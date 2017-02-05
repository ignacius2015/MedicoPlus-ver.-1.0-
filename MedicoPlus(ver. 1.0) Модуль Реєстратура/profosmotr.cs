namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.profosmotr")]
    public partial class profosmotr
    {
        public int id { get; set; }

        public int patient_id { get; set; }

        [Column("profosmotr")]
        public int profosmotr1 { get; set; }

        [Column(TypeName = "date")]
        public DateTime? data { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string result { get; set; }

        public int doctor { get; set; }

        public virtual patients patients { get; set; }

        public virtual personal personal { get; set; }

        public virtual profosmotr_table profosmotr_table { get; set; }
    }
}
