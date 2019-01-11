using System.Linq;
using Microsoft.EntityFrameworkCore;

public class MuzikRepository : IMuzikRepository
{
    MuzikContext context;

    public MuzikRepository(MuzikContext context)
    {
        this.context = context;
    }

    public void add(Muzik muzik)
    {
        context.muziks.Add(muzik);
        context.SaveChanges();

    }

    public void delete(int muzikID)
    {
        Muzik muzik = context.muziks.FirstOrDefault(
            x=>x.muzikID==muzikID
        );
        if(muzik != null)
        {
            context.muziks.Remove(muzik);
            context.SaveChanges();
        }
    }

    public void edit(Muzik muzik)
    {
        context.Entry(muzik).State = EntityState.Modified;
        context.SaveChanges();
    }

    public IQueryable<Muzik> findAll()
    {
        return context.muziks;
    }

    public Muzik findByID(int muzikID)
    {
        return context.muziks.FirstOrDefault(
            x=>x.muzikID == muzikID
        );
    }

    public IQueryable<Muzik> findBySanatci(int sanatciID)
    {
        return findAll().Where(x=>x.sanatciID == sanatciID);
    }
}