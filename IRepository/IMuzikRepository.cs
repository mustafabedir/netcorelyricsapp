using System.Linq;

public interface IMuzikRepository
{
    Muzik findByID(int muzikID);
    IQueryable<Muzik> findAll();
    void add(Muzik muzik);
    void edit(Muzik muzik);
    void delete(int muzikID);
    IQueryable<Muzik> findBySanatci(int sanatciID);
}