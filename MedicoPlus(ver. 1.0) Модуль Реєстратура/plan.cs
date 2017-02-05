namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.plan")]
    public partial class plan
    {
        public int id { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public int patient_id { get; set; }

        public int doctor { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string research { get; set; }

        public int inspection { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string treatment { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string reabilitation { get; set; }

        public virtual patients patients { get; set; }

        public virtual personal personal { get; set; }

        public virtual specialist specialist { get; set; }
    }
}
