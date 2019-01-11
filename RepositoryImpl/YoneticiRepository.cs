using System.Linq;
using Microsoft.EntityFrameworkCore;

public class YoneticiRepository : IYoneticiRepository
{
    MuzikContext context;

    public YoneticiRepository(MuzikContext context)
    {
        this.context = context;
    }

    public void add(Yonetici yonetici)
    {
        context.yoneticis.Add(yonetici);
        context.SaveChanges();
    }

    public void delete(int yoneticiID)
    {
        Yonetici yonetici = context.yoneticis.FirstOrDefault(
            x=>x.adminID == yoneticiID
        );
        context.yoneticis.Remove(yonetici);
        context.SaveChanges();
    }

    public void edit(Yonetici yonetici)
    {
        context.Entry(yonetici).State = EntityState.Modified;
        context.SaveChanges();        
    }

    public IQueryable<Yonetici> findAll()
    {
        return context.yoneticis;
    }

    public Yonetici findByID(int yoneticiID)
    {
        return context.yoneticis.FirstOrDefault(
            x=>x.adminID==yoneticiID
        );
    }
    public Yonetici loginn(string username, string password)
    {
        return context.yoneticis.FirstOrDefault(x=>
            x.username == username && x.password == password);
    }
}