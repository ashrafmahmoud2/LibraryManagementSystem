﻿namespace LibraryManagementSystem.Data
{
	public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}


		public DbSet<Author> Authors { get; set; }

		public DbSet<Area> Areas { get; set; }

		public DbSet<Governorate> Governorates { get; set; }

		public DbSet<Book> Books { get; set; }

		public DbSet<BookCopy> BookCopies { get; set; }

		public DbSet<BookCategory> BookCategories { get; set; }
		public DbSet<Category> Categories { get; set; }

		public DbSet<Subscriber> Subscribers { get; set; }

		public DbSet<Subscription> Subscriptions { get; set; }


		protected override void OnModelCreating(ModelBuilder builder)
		{
			//generate a unique serial number
			builder.HasSequence<int>("SerialNumber", schema: "shared")
		 .StartsAt(1000001);

			builder.Entity<BookCopy>()
				   .Property(p => p.SerialNumber)
				   .HasDefaultValueSql("NEXT VALUE FOR shared.SerialNumber");


            builder.Entity<BookCategory>().HasKey(e => new { e.BookId, e.CategoryId });


            //make all tables Restrict 
            var cascadeFKs = builder.Model.GetEntityTypes()
			   .SelectMany(t => t.GetForeignKeys())
			   .Where(fk => fk.DeleteBehavior == DeleteBehavior.Cascade && !fk.IsOwnership);

			foreach (var fk in cascadeFKs)
				fk.DeleteBehavior = DeleteBehavior.Restrict;

			base.OnModelCreating(builder);
		}
	}
}