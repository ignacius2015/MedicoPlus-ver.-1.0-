namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.aids")]
    public partial class aids
    {
        public int id { get; set; }

        public bool? result { get; set; }

        public int patient_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public virtual patients patients { get; set; }
    }
}
