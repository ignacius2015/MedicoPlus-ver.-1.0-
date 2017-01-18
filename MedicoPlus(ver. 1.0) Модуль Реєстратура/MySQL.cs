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

        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.pwd)
                .IsUnicode(false);
        }
    }
}
