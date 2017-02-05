namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.blood_transfusion")]
    public partial class blood_transfusion
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime datatrans { get; set; }

        public int quantity { get; set; }

        public int patient_id { get; set; }

        public virtual patients patients { get; set; }
    }
}
