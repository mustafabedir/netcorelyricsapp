using System.Linq;
using Microsoft.EntityFrameworkCore;

public class KullaniciRepository : IKullaniciRepository
{
    MuzikContext context;

    public KullaniciRepository(MuzikContext context)
    {
        this.context = context;
    }
    public void add(Kullanici kullanici)
    {
        context.kullanicis.Add(kullanici);
        context.SaveChanges();
    }

    public void delete(int kullaniciID)
    {
        Kullanici kullanici =
            context.kullanicis.FirstOrDefault(x => x.kullaniciID == kullaniciID);
        if(kullanici != null)
        {
            context.kullanicis.Remove(kullanici);
            context.SaveChanges();
        }
    }

    public void edit(Kullanici kullanici)
    {
        context.Entry(kullanici).State = EntityState.Modified;
        context.SaveChanges();
    }

    public IQueryable<Kullanici> findAll()
    {
        return context.kullanicis;
    }

    public Kullanici findByID(int kullaniciID)
    {
        return context.kullanicis.FirstOrDefault(x=>
            x.kullaniciID == kullaniciID);
    }

    public Kullanici loginn(string username, string password)
    {
        return context.kullanicis.FirstOrDefault(x=>
            x.username == username && x.password == password);
    }
}