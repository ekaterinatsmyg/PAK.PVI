using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bsuir.PAK.PVI.DataAccessLayer.Entities.Entities;

namespace Bsuir.PAK.PVI.DataAccessLayer.Entities
{
    public class DbContextModel : DbContext
    {
        public DbContextModel() 
            : base("name=DbContextModel")
        {
            Database.SetInitializer(new PakDbInitializer());
        }

        public virtual IDbSet<UserEntity> Users { get; set; }
        public virtual IDbSet<ExperimentEntity> Experiments { get; set; }
        public virtual IDbSet<TestEntity> Tests { get; set; }
        public virtual IDbSet<ExperimentSettingsEntity> ExperimentSettings { get; set; }
        public virtual IDbSet<TestSettingsEntity> TestSettings { get; set; }
        public virtual IDbSet<StimulusEntity> Stimulus { get; set; }
        public virtual IDbSet<ResultsEntity> Results { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExperimentEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<ExperimentEntity>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<TestEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<TestEntity>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<ExperimentSettingsEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<ExperimentSettingsEntity>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<TestSettingsEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<TestSettingsEntity>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<StimulusEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<StimulusEntity>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<ResultsEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<ResultsEntity>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<UserEntity>().HasKey(t => t.Id);
            modelBuilder.Entity<UserEntity>().Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            modelBuilder.Entity<TestEntity>()
                  .HasRequired<ExperimentEntity>(e => e.ExperimentEntity)
                  .WithMany(t => t.Tests)
                  .HasForeignKey(e => e.ExperimentId);

            modelBuilder.Entity<ExperimentSettingsEntity>()
                .HasRequired<ExperimentEntity>(s => s.ExperimentEntity)
                .WithMany(e => e.ExperimentSettings)
                .HasForeignKey(s => s.ExperimentId);

            modelBuilder.Entity<TestSettingsEntity>()
               .HasRequired<TestEntity>(s => s.TestEntity)
               .WithMany(e => e.TestSettings)
               .HasForeignKey(s => s.TestId);

            modelBuilder.Entity<TestSettingsEntity>()
               .HasRequired<StimulusEntity>(s => s.StimulusEntity)
               .WithMany(ts => ts.TestSettings)
               .HasForeignKey(s => s.StimulusId);

            modelBuilder.Entity<ResultsEntity>()
                 .HasRequired<ExperimentEntity>(e => e.ExperimentEntity)
                 .WithMany(t => t.Results)
                 .HasForeignKey(e => e.ExperimentId)
                 .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResultsEntity>()
                 .HasRequired<TestEntity>(e => e.TestEntity)
                 .WithMany(t => t.Results)
                 .HasForeignKey(e => e.TestId)
                 .WillCascadeOnDelete(false); 

            modelBuilder.Entity<ResultsEntity>()
                .HasRequired<TestSettingsEntity>(e => e.TestSettingEntity)
                .WithMany(t => t.Results)
                .HasForeignKey(e => e.TestSettingsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResultsEntity>()
                .HasRequired<ExperimentSettingsEntity>(e => e.ExperimentSettingEntity)
                .WithMany(t => t.Results)
                .HasForeignKey(e => e.ExperimentSettingsId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResultsEntity>()
                .HasRequired<UserEntity>(e => e.UserEntity)
                .WithMany(t => t.UserResults)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

        }

    }
}
