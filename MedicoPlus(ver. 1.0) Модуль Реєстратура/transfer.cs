namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.transfer")]
    public partial class transfer
    {
        public int id { get; set; }

        public int patient_id { get; set; }

        public int dep_id { get; set; }

        public int hosp_id { get; set; }

        public virtual departments departments { get; set; }

        public virtual hospitals hospitals { get; set; }

        public virtual patients patients { get; set; }
    }
}
