namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.intolerance")]
    public partial class intolerance
    {
        public int id { get; set; }

        public int id_drug { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string result { get; set; }

        public int patient_id { get; set; }

        public virtual drugs drugs { get; set; }

        public virtual patients patients { get; set; }
    }
}
