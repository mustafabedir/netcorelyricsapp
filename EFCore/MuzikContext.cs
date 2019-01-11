using Microsoft.EntityFrameworkCore;

public class MuzikContext:DbContext{

    public MuzikContext(DbContextOptions<MuzikContext> options):base(options)
    {
        
    }

    public DbSet<Etiket> etikets { get; set; }
    public DbSet<Kullanici> kullanicis { get; set; }
    public DbSet<Muzik> muziks { get; set; }
    public DbSet<Sanatci> sanatcis { get; set; }
    public DbSet<Yonetici> yoneticis { get; set; }
    public DbSet<Yorum> yorums { get; set; }


}