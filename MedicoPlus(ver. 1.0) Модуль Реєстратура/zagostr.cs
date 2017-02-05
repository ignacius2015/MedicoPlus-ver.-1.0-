namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.zagostr")]
    public partial class zagostr
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zagostr()
        {
            epikriz = new HashSet<epikriz>();
        }

        public int id { get; set; }

        public int name { get; set; }

        [Column(TypeName = "date")]
        public DateTime data { get; set; }

        public int patient_id { get; set; }

        public virtual diagnosis_table diagnosis_table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<epikriz> epikriz { get; set; }

        public virtual patients patients { get; set; }
    }
}
