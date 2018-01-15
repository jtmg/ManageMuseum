using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace ManageMuseum.Models
{
    public class OurContectDb: DbContext
    {
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<ArtPiece> ArtPieces { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}