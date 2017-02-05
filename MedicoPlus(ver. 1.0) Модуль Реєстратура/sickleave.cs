namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.sickleave")]
    public partial class sickleave
    {
        public int id { get; set; }

        public int patient_id { get; set; }

        [Required]
        [StringLength(15)]
        public string number { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_start { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_end { get; set; }

        public int diagnosis { get; set; }

        public int doctor { get; set; }

        public virtual diagnosis_table diagnosis_table { get; set; }

        public virtual patients patients { get; set; }

        public virtual personal personal { get; set; }
    }
}
