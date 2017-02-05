namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("medico.stcard")]
    public partial class stcard
    {
        public int id { get; set; }

        public int patient_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_hosp { get; set; }

        public int dep_id { get; set; }

        public int ward { get; set; }

        [Column(TypeName = "date")]
        public DateTime offordeath { get; set; }

        public int koykodni { get; set; }

        public int bloodtype { get; set; }

        public int rh { get; set; }

        [Column(TypeName = "date")]
        public DateTime rhdate { get; set; }

        public bool? hosptype { get; set; }

        public int age { get; set; }

        public bool? hosptype2 { get; set; }

        public int direction { get; set; }

        public int doctor { get; set; }

        public int diagnosis_first { get; set; }

        public int diagnosis_clin { get; set; }

        public int diagnosis_hosp { get; set; }

        [Column(TypeName = "date")]
        public DateTime diag_data { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string expert { get; set; }

        public int oncology { get; set; }

        public int capacity { get; set; }

        public int? cause_off { get; set; }

        public bool? listok { get; set; }

        public int medresult { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fluorografia { get; set; }

        [Column(TypeName = "date")]
        public DateTime? onco { get; set; }

        public int chief { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string complaints { get; set; }

        [Column(TypeName = "text")]
        [Required]
        [StringLength(65535)]
        public string anamnesis { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string anamnesis_life { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string state { get; set; }

        public bool? korosta { get; set; }

        public bool? pedikul { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string proc { get; set; }

        [Column(TypeName = "text")]
        [StringLength(65535)]
        public string recom { get; set; }

        public int effectiv { get; set; }

        public virtual bloodtypes bloodtypes { get; set; }

        public virtual capacity capacity1 { get; set; }

        public virtual cause_off cause_off1 { get; set; }

        public virtual departments departments { get; set; }

        public virtual diagnosis_table diagnosis_table { get; set; }

        public virtual diagnosis_table diagnosis_table1 { get; set; }

        public virtual diagnosis_table diagnosis_table2 { get; set; }

        public virtual effectiv_table effectiv_table { get; set; }

        public virtual hospitals hospitals { get; set; }

        public virtual medresults medresults { get; set; }

        public virtual oncology_table oncology_table { get; set; }

        public virtual patients patients { get; set; }

        public virtual personal personal { get; set; }

        public virtual personal personal1 { get; set; }

        public virtual rh rh1 { get; set; }

        public virtual ward ward1 { get; set; }
    }
}
