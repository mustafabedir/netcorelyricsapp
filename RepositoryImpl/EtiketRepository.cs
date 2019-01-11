using System.Linq;
using Microsoft.EntityFrameworkCore;

public class EtiketRepository : IEtiketRepository
{
    MuzikContext context;

    public EtiketRepository(MuzikContext context)
    {
        this.context = context;
    }

    public void add(Etiket etiket)
    {
        context.etikets.Add(etiket);
        context.SaveChanges();
    }

    public void delete(int etiketID)
    {
        Etiket etiket = context.etikets.FirstOrDefault(
            x => x.etiketID == etiketID
        );

        if (etiket != null)
        {
            context.etikets.Remove(etiket);
            context.SaveChanges();
        }
    }

    public void edit(Etiket etiket)
    {
        context.Entry(etiket).State = EntityState.Modified;
        context.SaveChanges();

    }

    public IQueryable<Etiket> findAll()
    {
        return context.etikets;
    }

    public Etiket findByID(int etiketID)
    {
        return context.etikets.FirstOrDefault(x=> x.etiketID==etiketID);
    }

    public IQueryable<Etiket> findByMuzik(int muzikID)
    {
        return findAll().Where(x=> x.muzikID == muzikID);
    }
}