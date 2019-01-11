using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;

public class HomeController:Controller
{

    private IKullaniciRepository _kullaniciRepository;
    private IMuzikRepository _muzikRepository;
    private IYorumRepository _yorumRepository;

    public HomeController(IKullaniciRepository _kullaniciRepository,
                            IMuzikRepository _muzikRepository,
                            IYorumRepository _yorumRepository)
    {
        this._kullaniciRepository = _kullaniciRepository;
        this._muzikRepository = _muzikRepository;
    }

    public IActionResult Index()
    {
        IQueryable<Muzik> muzik = _muzikRepository.findAll();
        return View(muzik);
    }
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Register(Kullanici kullanici)
    {
        _kullaniciRepository.add(kullanici);
        return RedirectToAction("List", new RouteValueDictionary( 
        new { controller = "Kullanici", action = "List", id = kullanici.kullaniciID } ) );
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(Kullanici kullanici)
    {
        
        Kullanici k = 
                _kullaniciRepository.loginn(kullanici.username, kullanici.password);
        if(k!= null)
        {
            return RedirectToAction("List", new RouteValueDictionary( 
            new { controller = "Kullanici", action = "List", id = k.kullaniciID } ) );
        }
        else{
            return View();
        }
        
    }

    public IActionResult Details(int id)
    {
        return RedirectToAction("Login");
    }
}