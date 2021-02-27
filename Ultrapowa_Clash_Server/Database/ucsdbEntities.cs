namespace Ultrapowa_Clash_Server.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Runtime.CompilerServices;

    public class ucsdbEntities : DbContext
    {
        [CompilerGenerated]
        private DbSet<Ultrapowa_Clash_Server.Database.Player> a;
        [CompilerGenerated]
        private DbSet<Ultrapowa_Clash_Server.Database.Clan> b;

        public ucsdbEntities() : base("name=ucsdbEntities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public DbSet<Ultrapowa_Clash_Server.Database.Clan> Clan
        {
            [CompilerGenerated]
            get
            {
                return this.b;
            }
            [CompilerGenerated]
            set
            {
                this.b = value;
            }
        }

        public DbSet<Ultrapowa_Clash_Server.Database.Player> Player
        {
            [CompilerGenerated]
            get
            {
                return this.a;
            }
            [CompilerGenerated]
            set
            {
                this.a = value;
            }
        }
    }
}

