namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.epikriz")]
    public partial class epikriz
    {
        public int id { get; set; }

        public int patient_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string cause { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string suputn { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string likuvan { get; set; }

        public int zagostr { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string sanatoriy { get; set; }

        public int inval { get; set; }

        public virtual invalid invalid { get; set; }

        public virtual patients patients { get; set; }

        public virtual zagostr zagostr1 { get; set; }
    }
}
