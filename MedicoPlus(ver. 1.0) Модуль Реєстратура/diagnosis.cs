namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.diagnosis")]
    public partial class diagnosis
    {
        public int id { get; set; }

        [Column("diagnosis")]
        public int diagnosis1 { get; set; }

        public bool? first { get; set; }

        public bool? first_prof { get; set; }

        public int doctor { get; set; }

        public int patient { get; set; }

        public virtual diagnosis_table diagnosis_table { get; set; }

        public virtual personal personal { get; set; }

        public virtual patients patients { get; set; }
    }
}
