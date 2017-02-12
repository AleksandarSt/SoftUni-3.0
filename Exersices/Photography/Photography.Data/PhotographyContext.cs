using Photography.Models;
using System.Data.Entity;

namespace Photography.Data
{
    public class PhotographyContext : DbContext
    {
        public PhotographyContext()
            : base("name=PhotographyContext")
        {
        }
        
        public DbSet<Accessory> Accessories { get; set; }

        public DbSet<Camera> Cameras { get; set; }

        public DbSet<Lens> Lenses { get; set; }

        public DbSet<Photographer> Photographers { get; set; }

        public DbSet<Workshop> Workshops { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Camera>()
            .Map<DSLRCamera>(m =>
            m.Requires("Type")
                .HasValue("DSLR"))
            .Map<MirrorlessCamera>(m =>
            m.Requires("Type")
                .HasValue("Mirrorless"));

            modelBuilder.Entity<Lens>()
                .HasMany(lens => lens.CompatibleCameras)
                .WithMany(camera => camera.CompatibleLenses)
                .Map(configuration =>
                {
                    configuration.MapLeftKey("LenseId");
                    configuration.MapRightKey("CameraId");
                    configuration.ToTable("LenseCamera");
                });

            modelBuilder.Entity<Lens>()
                .HasOptional(lens => lens.Owner)
                .WithMany(owner => owner.Lenses)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Photographer>()
                .HasMany(photgrapher => photgrapher.AttendedWorkshops)
                .WithMany(workshop => workshop.Participants)
                .Map(configuration =>
                {
                    configuration.MapLeftKey("PhotographerId");
                    configuration.MapRightKey("WorkshopId");
                    configuration.ToTable("PhotographerPartisipantWorkshop");
                });

            modelBuilder.Entity<Camera>()
                .HasOptional(camera => camera.Owner)
                .WithRequired(owner => owner.PrimaryCamera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Camera>()
                .HasOptional(camera => camera.Owner)
                .WithRequired(owner => owner.SecondaryCamera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Workshop>()
                .HasRequired(workshop => workshop.Trainer)
                .WithMany(trainer => trainer.TrainedWorkshops)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Accessory>()
                .HasOptional(accessory => accessory.Owner)
                .WithMany(owner => owner.Accessories)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}