using System.Linq;

public interface IYoneticiRepository
{
    Yonetici findByID(int yoneticiID);
    Yonetici loginn(string username, string password);
    IQueryable<Yonetici> findAll();
    void add(Yonetici yonetici);
    void edit(Yonetici yonetici);
    void delete(int yoneticiID);
}