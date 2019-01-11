using System.Linq;

public interface IYorumRepository
{
    Yorum findByID(int yorumID);
    IQueryable<Yorum> findAll();
    void add(Yorum yorum);
    void edit(Yorum yorum);
    void delete(int yorumID);
    IQueryable<Yorum> findByKullanici(int kullaniciID);
    IQueryable<Yorum> findByMuzik(int muzikID);
}