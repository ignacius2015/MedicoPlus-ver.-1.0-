namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.rules")]
    public partial class rules
    {
        public int id { get; set; }

        [Required]
        [StringLength(30)]
        public string name { get; set; }
    }
}
