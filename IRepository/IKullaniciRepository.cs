using System.Linq;

public interface IKullaniciRepository
{
    Kullanici findByID(int kullaniciID);
    Kullanici loginn(string username, string password);
    IQueryable<Kullanici> findAll();
    void add(Kullanici kullanici);
    void edit(Kullanici kullanici);
    void delete(int kullaniciID);
}