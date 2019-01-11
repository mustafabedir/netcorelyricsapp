using System.Linq;

public interface IEtiketRepository
{
    Etiket findByID(int etiketID);
    IQueryable<Etiket> findAll();
    void add(Etiket etiket);
    void edit(Etiket etiket);
    void delete(int etiketID);
    IQueryable<Etiket> findByMuzik(int muzikID);
}