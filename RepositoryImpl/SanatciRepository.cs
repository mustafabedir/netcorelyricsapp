using System.Linq;
using Microsoft.EntityFrameworkCore;

public class SanatciRepository : ISanatciRepository
{
    MuzikContext context;
    public SanatciRepository(MuzikContext context)
    {
        this.context = context;
    }
    public void add(Sanatci sanatci)
    {
        context.sanatcis.Add(sanatci);
        context.SaveChanges();
    }

    public void delete(int sanatciID)
    {
        Sanatci sanatci = context.sanatcis.FirstOrDefault(
            x=>x.sanatciID == sanatciID
        );
        if(sanatci!=null)
        {
            context.sanatcis.Remove(sanatci);
            context.SaveChanges();
        }
    }

    public void edit(Sanatci sanatci)
    {
        context.Entry(sanatci).State = EntityState.Modified;
        context.SaveChanges();
    }

    public IQueryable<Sanatci> findAll()
    {
        return context.sanatcis;
    }

    public Sanatci findByID(int sanatciID)
    {
        return context.sanatcis.FirstOrDefault(
            x=>x.sanatciID == sanatciID
        );
        
    }
}