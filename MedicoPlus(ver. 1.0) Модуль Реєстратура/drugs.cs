namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.drugs")]
    public partial class drugs
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public drugs()
        {
            intolerance = new HashSet<intolerance>();
        }

        public int id { get; set; }

        [StringLength(100)]
        public string name { get; set; }

        public int manufacturer { get; set; }

        public int? composition { get; set; }

        public virtual compositions compositions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<intolerance> intolerance { get; set; }

        public virtual manufacturers manufacturers { get; set; }
    }
}
