using System.Linq;
using Microsoft.EntityFrameworkCore;

public class YorumRepository : IYorumRepository
{
    MuzikContext context;

    public YorumRepository(MuzikContext context)
    {
        this.context = context;
    }
    public void add(Yorum yorum)
    {
        context.yorums.Add(yorum);
        context.SaveChanges();
    }

    public void delete(int yorumID)
    {
        Yorum yorum = context.yorums.FirstOrDefault(
            x=>x.yorumID == yorumID
        );
        if(yorum!= null)
        {
            context.yorums.Remove(yorum);
            context.SaveChanges();
        }
    }

    public void edit(Yorum yorum)
    {
        context.Entry(yorum).State = EntityState.Modified;
        context.SaveChanges();
    }

    public IQueryable<Yorum> findAll()
    {
        return context.yorums;
    }

    public Yorum findByID(int yorumID)
    {
        return context.yorums.FirstOrDefault(
            x=>x.yorumID==yorumID
        );
    }

    public IQueryable<Yorum> findByKullanici(int kullaniciID)
    {
        return findAll().Where(x=>x.kullaniciID==kullaniciID);
    }

    public IQueryable<Yorum> findByMuzik(int muzikID)
    {
        return findAll().Where(x=>x.muzikID==muzikID);
    }
}