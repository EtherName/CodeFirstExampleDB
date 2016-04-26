namespace DataService
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AirLineContext : DbContext
    {
        public AirLineContext()
             : base("name=AirLineCodeFirst")
        {
            //Database.SetInitializer(new CreateDatabaseIfNotExists<AirLineContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AirLineContext>());
        }

        public virtual DbSet<TicketType> TicketTypes { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    
    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}