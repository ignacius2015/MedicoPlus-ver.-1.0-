namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("requiem.users")]
    public partial class user
    {
        public int id { get; set; }

        [Required]
        [StringLength(15)]
        public string login { get; set; }

        [Required]
        [StringLength(100)]
        public string pwd { get; set; }
    }
}
