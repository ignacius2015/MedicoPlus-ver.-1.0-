namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.registration_off")]
    public partial class registration_off
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public registration_off()
        {
            acard = new HashSet<acard>();
        }

        public int id { get; set; }

        public int patient_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime dataoff { get; set; }

        [Required]
        [StringLength(255)]
        public string cause { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<acard> acard { get; set; }

        public virtual patients patients { get; set; }
    }
}
