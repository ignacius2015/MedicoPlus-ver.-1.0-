namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.infectious_deseases")]
    public partial class infectious_deseases
    {
        public int id { get; set; }

        public int name { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public int patient_id { get; set; }

        public virtual deseases_table deseases_table { get; set; }

        public virtual patients patients { get; set; }
    }
}
