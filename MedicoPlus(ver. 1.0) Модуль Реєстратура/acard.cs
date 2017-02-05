namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.acard")]
    public partial class acard
    {
        public int id { get; set; }

        public int patient_id { get; set; }

        public int reg_on { get; set; }

        public int reg_off { get; set; }

        public int bloodtypes { get; set; }

        public int rh { get; set; }

        public sbyte? diabetes { get; set; }

        public int diabetes_d { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string allergy { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string intolerance { get; set; }

        public virtual bloodtypes bloodtypes1 { get; set; }

        public virtual diabetes diabetes1 { get; set; }

        public virtual patients patients { get; set; }

        public virtual registration_off registration_off { get; set; }

        public virtual registration_on registration_on { get; set; }

        public virtual rh rh1 { get; set; }
    }
}
