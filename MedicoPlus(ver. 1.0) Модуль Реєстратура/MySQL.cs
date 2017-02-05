namespace MedicoPlus_ver._1._0__Модуль_Реєстратура
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MySQL : DbContext
    {
        public MySQL()
            : base("name=MySQL")
        {
        }

        public virtual DbSet<acard> acard { get; set; }
        public virtual DbSet<aids> aids { get; set; }
        public virtual DbSet<anestic_type> anestic_type { get; set; }
        public virtual DbSet<areas> areas { get; set; }
        public virtual DbSet<blood_transfusion> blood_transfusion { get; set; }
        public virtual DbSet<bloodtypes> bloodtypes { get; set; }
        public virtual DbSet<capacity> capacity { get; set; }
        public virtual DbSet<cause_off> cause_off { get; set; }
        public virtual DbSet<cities> cities { get; set; }
        public virtual DbSet<compositions> compositions { get; set; }
        public virtual DbSet<currency> currency { get; set; }
        public virtual DbSet<dairy> dairy { get; set; }
        public virtual DbSet<departments> departments { get; set; }
        public virtual DbSet<deseases_table> deseases_table { get; set; }
        public virtual DbSet<diabetes> diabetes { get; set; }
        public virtual DbSet<diagnosis> diagnosis { get; set; }
        public virtual DbSet<diagnosis_table> diagnosis_table { get; set; }
        public virtual DbSet<dispgroup> dispgroup { get; set; }
        public virtual DbSet<drugs> drugs { get; set; }
        public virtual DbSet<effectiv_table> effectiv_table { get; set; }
        public virtual DbSet<epikriz> epikriz { get; set; }
        public virtual DbSet<graft> graft { get; set; }
        public virtual DbSet<graft_table> graft_table { get; set; }
        public virtual DbSet<hospitalization> hospitalization { get; set; }
        public virtual DbSet<hospitals> hospitals { get; set; }
        public virtual DbSet<infectious_deseases> infectious_deseases { get; set; }
        public virtual DbSet<insurance> insurance { get; set; }
        public virtual DbSet<intolerance> intolerance { get; set; }
        public virtual DbSet<invalid> invalid { get; set; }
        public virtual DbSet<kontingent> kontingent { get; set; }
        public virtual DbSet<manufacturers> manufacturers { get; set; }
        public virtual DbSet<medical_offices> medical_offices { get; set; }
        public virtual DbSet<medresults> medresults { get; set; }
        public virtual DbSet<mkh> mkh { get; set; }
        public virtual DbSet<oncology_table> oncology_table { get; set; }
        public virtual DbSet<patients> patients { get; set; }
        public virtual DbSet<personal> personal { get; set; }
        public virtual DbSet<plan> plan { get; set; }
        public virtual DbSet<profosmotr> profosmotr { get; set; }
        public virtual DbSet<profosmotr_table> profosmotr_table { get; set; }
        public virtual DbSet<regions> regions { get; set; }
        public virtual DbSet<registration_off> registration_off { get; set; }
        public virtual DbSet<registration_on> registration_on { get; set; }
        public virtual DbSet<rh> rh { get; set; }
        public virtual DbSet<rules> rules { get; set; }
        public virtual DbSet<sex> sex { get; set; }
        public virtual DbSet<sickleave> sickleave { get; set; }
        public virtual DbSet<specialist> specialist { get; set; }
        public virtual DbSet<stcard> stcard { get; set; }
        public virtual DbSet<surgery> surgery { get; set; }
        public virtual DbSet<surgery_table> surgery_table { get; set; }
        public virtual DbSet<transfer> transfer { get; set; }
        public virtual DbSet<units> units { get; set; }
        public virtual DbSet<unitsgroup> unitsgroup { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<ward> ward { get; set; }
        public virtual DbSet<zagostr> zagostr { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<acard>()
                .Property(e => e.allergy)
                .IsUnicode(false);

            modelBuilder.Entity<acard>()
                .Property(e => e.intolerance)
                .IsUnicode(false);

            modelBuilder.Entity<anestic_type>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<anestic_type>()
                .HasMany(e => e.surgery)
                .WithRequired(e => e.anestic_type)
                .HasForeignKey(e => e.anestic);

            modelBuilder.Entity<areas>()
                .Property(e => e.area)
                .IsUnicode(false);

            modelBuilder.Entity<areas>()
                .HasMany(e => e.hospitals)
                .WithRequired(e => e.areas)
                .HasForeignKey(e => e.area);

            modelBuilder.Entity<areas>()
                .HasMany(e => e.patients)
                .WithRequired(e => e.areas)
                .HasForeignKey(e => e.id_area);

            modelBuilder.Entity<bloodtypes>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<bloodtypes>()
                .HasMany(e => e.acard)
                .WithRequired(e => e.bloodtypes1)
                .HasForeignKey(e => e.bloodtypes);

            modelBuilder.Entity<bloodtypes>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.bloodtypes)
                .HasForeignKey(e => e.bloodtype);

            modelBuilder.Entity<capacity>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<capacity>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.capacity1)
                .HasForeignKey(e => e.capacity);

            modelBuilder.Entity<cause_off>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<cause_off>()
                .HasMany(e => e.stcard)
                .WithOptional(e => e.cause_off1)
                .HasForeignKey(e => e.cause_off)
                .WillCascadeOnDelete();

            modelBuilder.Entity<cities>()
                .Property(e => e.village)
                .IsUnicode(false);

            modelBuilder.Entity<cities>()
                .HasMany(e => e.hospitals)
                .WithRequired(e => e.cities)
                .HasForeignKey(e => e.city);

            modelBuilder.Entity<cities>()
                .HasMany(e => e.patients)
                .WithRequired(e => e.cities)
                .HasForeignKey(e => e.id_city);

            modelBuilder.Entity<compositions>()
                .HasMany(e => e.drugs)
                .WithOptional(e => e.compositions)
                .HasForeignKey(e => e.composition)
                .WillCascadeOnDelete();

            modelBuilder.Entity<currency>()
                .Property(e => e.symb_code)
                .IsUnicode(false);

            modelBuilder.Entity<dairy>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<dairy>()
                .Property(e => e.naznachniya)
                .IsUnicode(false);

            modelBuilder.Entity<departments>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.dairy)
                .WithRequired(e => e.departments)
                .HasForeignKey(e => e.dep_id);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.ward)
                .WithRequired(e => e.departments)
                .HasForeignKey(e => e.dep_id);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.transfer)
                .WithRequired(e => e.departments)
                .HasForeignKey(e => e.dep_id);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.insurance)
                .WithRequired(e => e.departments)
                .HasForeignKey(e => e.dep_id);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.personal)
                .WithRequired(e => e.departments)
                .HasForeignKey(e => e.dep_id);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.hospitalization)
                .WithRequired(e => e.departments)
                .HasForeignKey(e => e.dep_id);

            modelBuilder.Entity<departments>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.departments)
                .HasForeignKey(e => e.dep_id);

            modelBuilder.Entity<deseases_table>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<deseases_table>()
                .HasMany(e => e.infectious_deseases)
                .WithRequired(e => e.deseases_table)
                .HasForeignKey(e => e.name);

            modelBuilder.Entity<diabetes>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<diabetes>()
                .HasMany(e => e.acard)
                .WithRequired(e => e.diabetes1)
                .HasForeignKey(e => e.diabetes_d);

            modelBuilder.Entity<diagnosis_table>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<diagnosis_table>()
                .HasMany(e => e.dairy)
                .WithRequired(e => e.diagnosis_table)
                .HasForeignKey(e => e.diagnosis);

            modelBuilder.Entity<diagnosis_table>()
                .HasMany(e => e.diagnosis)
                .WithRequired(e => e.diagnosis_table)
                .HasForeignKey(e => e.diagnosis1);

            modelBuilder.Entity<diagnosis_table>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.diagnosis_table)
                .HasForeignKey(e => e.diagnosis_clin);

            modelBuilder.Entity<diagnosis_table>()
                .HasMany(e => e.stcard1)
                .WithRequired(e => e.diagnosis_table1)
                .HasForeignKey(e => e.diagnosis_first);

            modelBuilder.Entity<diagnosis_table>()
                .HasMany(e => e.hospitalization)
                .WithRequired(e => e.diagnosis_table)
                .HasForeignKey(e => e.diagnosis);

            modelBuilder.Entity<diagnosis_table>()
                .HasMany(e => e.stcard2)
                .WithRequired(e => e.diagnosis_table2)
                .HasForeignKey(e => e.diagnosis_hosp);

            modelBuilder.Entity<diagnosis_table>()
                .HasMany(e => e.insurance)
                .WithRequired(e => e.diagnosis_table)
                .HasForeignKey(e => e.diagnosis_id);

            modelBuilder.Entity<diagnosis_table>()
                .HasMany(e => e.sickleave)
                .WithRequired(e => e.diagnosis_table)
                .HasForeignKey(e => e.diagnosis);

            modelBuilder.Entity<diagnosis_table>()
                .HasMany(e => e.zagostr)
                .WithRequired(e => e.diagnosis_table)
                .HasForeignKey(e => e.name);

            modelBuilder.Entity<dispgroup>()
                .HasMany(e => e.patients)
                .WithRequired(e => e.dispgroup1)
                .HasForeignKey(e => e.dispgroup);

            modelBuilder.Entity<drugs>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<drugs>()
                .HasMany(e => e.intolerance)
                .WithRequired(e => e.drugs)
                .HasForeignKey(e => e.id_drug);

            modelBuilder.Entity<effectiv_table>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<effectiv_table>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.effectiv_table)
                .HasForeignKey(e => e.effectiv);

            modelBuilder.Entity<epikriz>()
                .Property(e => e.cause)
                .IsUnicode(false);

            modelBuilder.Entity<epikriz>()
                .Property(e => e.suputn)
                .IsUnicode(false);

            modelBuilder.Entity<epikriz>()
                .Property(e => e.likuvan)
                .IsUnicode(false);

            modelBuilder.Entity<epikriz>()
                .Property(e => e.sanatoriy)
                .IsUnicode(false);

            modelBuilder.Entity<graft>()
                .Property(e => e.graft_name)
                .IsUnicode(false);

            modelBuilder.Entity<graft_table>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<graft_table>()
                .Property(e => e.reaction_mest)
                .IsUnicode(false);

            modelBuilder.Entity<graft_table>()
                .Property(e => e.reaction_all)
                .IsUnicode(false);

            modelBuilder.Entity<graft_table>()
                .Property(e => e.contraindication)
                .IsUnicode(false);

            modelBuilder.Entity<graft_table>()
                .HasMany(e => e.graft)
                .WithRequired(e => e.graft_table)
                .HasForeignKey(e => e.graft1);

            modelBuilder.Entity<hospitals>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<hospitals>()
                .HasMany(e => e.dairy)
                .WithRequired(e => e.hospitals)
                .HasForeignKey(e => e.hosp_id);

            modelBuilder.Entity<hospitals>()
                .HasMany(e => e.departments)
                .WithRequired(e => e.hospitals)
                .HasForeignKey(e => e.hosp_id);

            modelBuilder.Entity<hospitals>()
                .HasMany(e => e.hospitalization)
                .WithRequired(e => e.hospitals)
                .HasForeignKey(e => e.hosp_id);

            modelBuilder.Entity<hospitals>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.hospitals)
                .HasForeignKey(e => e.direction);

            modelBuilder.Entity<hospitals>()
                .HasMany(e => e.ward)
                .WithRequired(e => e.hospitals)
                .HasForeignKey(e => e.id_hosp);

            modelBuilder.Entity<hospitals>()
                .HasMany(e => e.transfer)
                .WithRequired(e => e.hospitals)
                .HasForeignKey(e => e.hosp_id);

            modelBuilder.Entity<hospitals>()
                .HasMany(e => e.insurance)
                .WithRequired(e => e.hospitals)
                .HasForeignKey(e => e.hosp_id);

            modelBuilder.Entity<hospitals>()
                .HasMany(e => e.medical_offices)
                .WithRequired(e => e.hospitals)
                .HasForeignKey(e => e.hosp_id);

            modelBuilder.Entity<intolerance>()
                .Property(e => e.result)
                .IsUnicode(false);

            modelBuilder.Entity<invalid>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<invalid>()
                .HasMany(e => e.epikriz)
                .WithRequired(e => e.invalid)
                .HasForeignKey(e => e.inval);

            modelBuilder.Entity<kontingent>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<kontingent>()
                .HasMany(e => e.patients)
                .WithRequired(e => e.kontingent)
                .HasForeignKey(e => e.id_kont);

            modelBuilder.Entity<manufacturers>()
                .HasMany(e => e.drugs)
                .WithRequired(e => e.manufacturers)
                .HasForeignKey(e => e.manufacturer);

            modelBuilder.Entity<medical_offices>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<medical_offices>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<medresults>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<medresults>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.medresults)
                .HasForeignKey(e => e.medresult);

            modelBuilder.Entity<mkh>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<mkh>()
                .Property(e => e.codes)
                .IsUnicode(false);

            modelBuilder.Entity<oncology_table>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<oncology_table>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.oncology_table)
                .HasForeignKey(e => e.oncology);

            modelBuilder.Entity<patients>()
                .Property(e => e.fullname)
                .IsUnicode(false);

            modelBuilder.Entity<patients>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<patients>()
                .Property(e => e.phone)
                .IsUnicode(false);

            modelBuilder.Entity<patients>()
                .Property(e => e.work)
                .IsUnicode(false);

            modelBuilder.Entity<patients>()
                .Property(e => e.posada)
                .IsUnicode(false);

            modelBuilder.Entity<patients>()
                .Property(e => e.docnumber)
                .IsUnicode(false);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.acard)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.aids)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.blood_transfusion)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.bloodtypes)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.dairy)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.diagnosis)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.epikriz)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.graft)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.hospitalization)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.infectious_deseases)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.insurance)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.intolerance)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.invalid)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.zagostr)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.plan)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.transfer)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.registration_off)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.registration_on)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.surgery)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.sickleave)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.profosmotr)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<patients>()
                .HasMany(e => e.rh)
                .WithRequired(e => e.patients)
                .HasForeignKey(e => e.patient_id);

            modelBuilder.Entity<personal>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.dairy)
                .WithRequired(e => e.personal)
                .HasForeignKey(e => e.doctor);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.diagnosis)
                .WithRequired(e => e.personal)
                .HasForeignKey(e => e.doctor);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.personal)
                .HasForeignKey(e => e.chief);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.stcard1)
                .WithRequired(e => e.personal1)
                .HasForeignKey(e => e.doctor);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.plan)
                .WithRequired(e => e.personal)
                .HasForeignKey(e => e.doctor);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.sickleave)
                .WithRequired(e => e.personal)
                .HasForeignKey(e => e.doctor);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.surgery)
                .WithRequired(e => e.personal)
                .HasForeignKey(e => e.doctor_s);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.profosmotr)
                .WithRequired(e => e.personal)
                .HasForeignKey(e => e.doctor);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.surgery1)
                .WithRequired(e => e.personal1)
                .HasForeignKey(e => e.doctor_a);

            modelBuilder.Entity<personal>()
                .HasMany(e => e.users)
                .WithRequired(e => e.personal)
                .HasForeignKey(e => e.id_user);

            modelBuilder.Entity<plan>()
                .Property(e => e.research)
                .IsUnicode(false);

            modelBuilder.Entity<plan>()
                .Property(e => e.treatment)
                .IsUnicode(false);

            modelBuilder.Entity<plan>()
                .Property(e => e.reabilitation)
                .IsUnicode(false);

            modelBuilder.Entity<profosmotr>()
                .Property(e => e.result)
                .IsUnicode(false);

            modelBuilder.Entity<profosmotr_table>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<profosmotr_table>()
                .HasMany(e => e.profosmotr)
                .WithRequired(e => e.profosmotr_table)
                .HasForeignKey(e => e.profosmotr1);

            modelBuilder.Entity<regions>()
                .Property(e => e.region)
                .IsUnicode(false);

            modelBuilder.Entity<regions>()
                .HasMany(e => e.cities)
                .WithRequired(e => e.regions)
                .HasForeignKey(e => e.region_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<regions>()
                .HasMany(e => e.hospitals)
                .WithRequired(e => e.regions)
                .HasForeignKey(e => e.region);

            modelBuilder.Entity<regions>()
                .HasMany(e => e.patients)
                .WithRequired(e => e.regions)
                .HasForeignKey(e => e.id_region);

            modelBuilder.Entity<registration_off>()
                .Property(e => e.cause)
                .IsUnicode(false);

            modelBuilder.Entity<registration_off>()
                .HasMany(e => e.acard)
                .WithRequired(e => e.registration_off)
                .HasForeignKey(e => e.reg_off);

            modelBuilder.Entity<registration_on>()
                .Property(e => e.cause)
                .IsUnicode(false);

            modelBuilder.Entity<registration_on>()
                .HasMany(e => e.acard)
                .WithRequired(e => e.registration_on)
                .HasForeignKey(e => e.reg_on);

            modelBuilder.Entity<rh>()
                .HasMany(e => e.acard)
                .WithRequired(e => e.rh1)
                .HasForeignKey(e => e.rh);

            modelBuilder.Entity<rh>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.rh1)
                .HasForeignKey(e => e.rh);

            modelBuilder.Entity<rules>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<sex>()
                .HasMany(e => e.patients)
                .WithRequired(e => e.sex1)
                .HasForeignKey(e => e.sex);

            modelBuilder.Entity<sickleave>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<specialist>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<specialist>()
                .HasMany(e => e.plan)
                .WithRequired(e => e.specialist)
                .HasForeignKey(e => e.inspection);

            modelBuilder.Entity<stcard>()
                .Property(e => e.expert)
                .IsUnicode(false);

            modelBuilder.Entity<stcard>()
                .Property(e => e.complaints)
                .IsUnicode(false);

            modelBuilder.Entity<stcard>()
                .Property(e => e.anamnesis)
                .IsUnicode(false);

            modelBuilder.Entity<stcard>()
                .Property(e => e.anamnesis_life)
                .IsUnicode(false);

            modelBuilder.Entity<stcard>()
                .Property(e => e.state)
                .IsUnicode(false);

            modelBuilder.Entity<stcard>()
                .Property(e => e.proc)
                .IsUnicode(false);

            modelBuilder.Entity<stcard>()
                .Property(e => e.recom)
                .IsUnicode(false);

            modelBuilder.Entity<surgery>()
                .Property(e => e.comment)
                .IsUnicode(false);

            modelBuilder.Entity<surgery_table>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<surgery_table>()
                .Property(e => e.code)
                .IsUnicode(false);

            modelBuilder.Entity<surgery_table>()
                .HasMany(e => e.surgery)
                .WithRequired(e => e.surgery_table)
                .HasForeignKey(e => e.id_surg);

            modelBuilder.Entity<units>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<units>()
                .Property(e => e.shortname)
                .IsUnicode(false);

            modelBuilder.Entity<unitsgroup>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<unitsgroup>()
                .HasMany(e => e.units)
                .WithRequired(e => e.unitsgroup1)
                .HasForeignKey(e => e.unitsgroup);

            modelBuilder.Entity<users>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<ward>()
                .HasMany(e => e.stcard)
                .WithRequired(e => e.ward1)
                .HasForeignKey(e => e.ward);

            modelBuilder.Entity<zagostr>()
                .HasMany(e => e.epikriz)
                .WithRequired(e => e.zagostr1)
                .HasForeignKey(e => e.zagostr);
        }
    }
}
