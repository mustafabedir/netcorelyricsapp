using System.Linq;

public interface ISanatciRepository
{
    Sanatci findByID(int sanatciID);
    IQueryable<Sanatci> findAll();
    void add(Sanatci sanatci);
    void edit(Sanatci sanatci);
    void delete(int sanatciID);
}