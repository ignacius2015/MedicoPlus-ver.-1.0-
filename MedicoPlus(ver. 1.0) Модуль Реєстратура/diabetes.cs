namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.diabetes")]
    public partial class diabetes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public diabetes()
        {
            acard = new HashSet<acard>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(45)]
        public string name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acard> acard { get; set; }
    }
}
