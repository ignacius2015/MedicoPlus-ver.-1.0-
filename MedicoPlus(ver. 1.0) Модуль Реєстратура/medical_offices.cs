namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.medical_offices")]
    public partial class medical_offices
    {
        public int id { get; set; }

        public int? number { get; set; }

        [StringLength(45)]
        public string name { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public int hosp_id { get; set; }

        public virtual hospitals hospitals { get; set; }
    }
}
