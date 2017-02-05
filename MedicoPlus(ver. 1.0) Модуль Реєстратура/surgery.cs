namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.surgery")]
    public partial class surgery
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public int id_surg { get; set; }

        public int patient_id { get; set; }

        public int anestic { get; set; }

        public int doctor_s { get; set; }

        public int doctor_a { get; set; }

        [StringLength(255)]
        public string comment { get; set; }

        public virtual anestic_type anestic_type { get; set; }

        public virtual patients patients { get; set; }

        public virtual personal personal { get; set; }

        public virtual personal personal1 { get; set; }

        public virtual surgery_table surgery_table { get; set; }
    }
}
