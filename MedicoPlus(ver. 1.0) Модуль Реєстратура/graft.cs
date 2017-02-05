namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.graft")]
    public partial class graft
    {
        public int id { get; set; }

        [Column("graft")]
        public int graft1 { get; set; }

        [Required]
        [StringLength(100)]
        public string graft_name { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public int patient_id { get; set; }

        public virtual graft_table graft_table { get; set; }

        public virtual patients patients { get; set; }
    }
}
