namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.dairy")]
    public partial class dairy
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public int hosp_id { get; set; }

        public int dep_id { get; set; }

        public int diagnosis { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string text { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string naznachniya { get; set; }

        public int doctor { get; set; }

        public int patient_id { get; set; }

        public virtual departments departments { get; set; }

        public virtual diagnosis_table diagnosis_table { get; set; }

        public virtual personal personal { get; set; }

        public virtual hospitals hospitals { get; set; }

        public virtual patients patients { get; set; }
    }
}
