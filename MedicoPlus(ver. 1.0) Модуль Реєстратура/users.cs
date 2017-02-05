namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.users")]
    public partial class users
    {
        public int id { get; set; }

        [Required]
        [StringLength(15)]
        public string login { get; set; }

        [Required]
        [StringLength(15)]
        public string password { get; set; }

        public int id_user { get; set; }

        public virtual personal personal { get; set; }
    }
}
