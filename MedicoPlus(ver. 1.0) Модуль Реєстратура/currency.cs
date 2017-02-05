namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.currency")]
    public partial class currency
    {
        public int id { get; set; }

        public int code { get; set; }

        [Required]
        [StringLength(45)]
        public string symb_code { get; set; }

        public decimal rate { get; set; }
    }
}
