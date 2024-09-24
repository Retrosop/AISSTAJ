using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;



namespace TestConnectDB
{
	public class Sotrudnik
	{
		[Key]
		public int Id { get; set; }
		public string? Fio { get; set; }
		public string? FioBeforeMarry { get; set; }
		public bool? Marry { get; set; }
		public DateTime Dater { get; set; }
		public bool? Pol { get; set; }
		public int Age { get; set; }
	}

	public class StajLite
	{
		[Key]
		public int Id { get; set; }
		public Sotrudnik SotrudnikIdLite { get; set; }
		public DateTime BeginWorkSotrudnik { get; set; }
		public DateTime EndWorkSotrudnik { get; set; }
		public DateTime GosWorkSotrudnik { get; set; }
	}
	public class Staj
	{
		[Key]
		public int Id { get; set; }
		public Sotrudnik SotrudnikId { get; set; }
		public DateTime BeginWorkSotrudnik { get; set; }
		public DateTime EndWorkSotrudnik { get; set; }
		public DateTime GosWorkSotrudnik { get; set; }
	}

	public class Report
	{
		[Key]
		public int Id { get; set; }
		public Staj StajId { get; set; }
		public string Nomerreport { get; set; }
		
		public DateTime CreateReport { get; set; }
	}
	public class Comment
	{
		[Key]
		public int Id { get; set; }
		public Sotrudnik SotrudnikId { get; set; }
		public string CommentsWork { get; set; }
	}

	public class SotrudnikLite
	{
		[Key]
		public int Id { get; set; }
		public string? Fio { get; set; }
		public string? FioBeforeMarry { get; set; }
		public bool? Marry { get; set; }
		public DateTime Dater { get; set; }
		public bool? Pol { get; set; }
		public int Age { get; set; }
	}


	public class DataContext : DbContext
	{
		public DbSet<SotrudnikLite> SotrudnikLite { get; set; }
		//public DbSet<Sotrudnik> Sotrudnik { get; set; }
		public DbSet<StajLite> StajLite { get; set; }
		//public DbSet<Report> Report { get; set; }
		//public DbSet<Comment> Comment { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=sqlite.db");
		}
	}

}
