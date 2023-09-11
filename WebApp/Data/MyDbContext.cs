using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Data;

public class Kisi
{
    public int Id { get; set; }

    [Display(Name = "Kişinin İsmidir")]
    public string Adi { get; set; }
    public string? IkinciAdi { get; set; }

    [StringLength(100)]
    [Column("Soyisim", TypeName = "ntext")]
    public string Soyadı { get; set; }

    //[NotMapped]
    public string TamAdi => Adi + " " + IkinciAdi + " " + Soyadı;

    [Required(ErrorMessage = "yaş alanı mecburidir")]
    [Range(20, 40, ErrorMessage = "yaş 20..40 arasında olmalıdır")]
    public int? Yas { get; set; }
    public bool Cinsiyet { get; set; } = false;
}

public class MyDbContext : DbContext
{
    public DbSet<Kisi> Kisiler { get; set; }
    public MyDbContext(DbContextOptions options) : base(options) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Kisi>()
            .Property(col => col.Adi)
            .HasColumnName("Isim")
            .HasMaxLength(50)
            .IsUnicode(false);

        modelBuilder.Entity<Kisi>().Ignore(x => x.TamAdi);
    }
}
