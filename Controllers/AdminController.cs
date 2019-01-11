using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;

public class AdminController:Controller
{
    private IYoneticiRepository _yoneticiRepository;
    private ISanatciRepository _sanatciRepository;
    private IKullaniciRepository _kullaniciRepository;
    private IMuzikRepository _muzikRepository;
    private IEtiketRepository _etiketRepository;
    private IYorumRepository _yorumRepository;
    public AdminController(IYoneticiRepository _yoneticiRepository,
                            ISanatciRepository _sanatciRepository,
                            IKullaniciRepository _kullaniciRepository,
                            IMuzikRepository _muzikRepository,
                            IEtiketRepository _etiketRepository,
                            IYorumRepository _yorumRepository)
    {
        this._yoneticiRepository = _yoneticiRepository;
        this._sanatciRepository = _sanatciRepository;
        this._kullaniciRepository = _kullaniciRepository;
        this._muzikRepository = _muzikRepository;
        this._etiketRepository = _etiketRepository;
        this._yorumRepository = _yorumRepository;
    }
    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Login(Yonetici yonetici)
    {
        
        Yonetici y = 
                _yoneticiRepository.loginn(yonetici.username, yonetici.password);
        if(y!= null)
        {
            return RedirectToAction("List");
        }
        else{
            return View();
        }
        
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Yonetici yonetici)
    {
        _yoneticiRepository.add(yonetici);
        return RedirectToAction("index");
    }

    [HttpGet]
    public IActionResult List()
    {
        IQueryable<Yonetici> yonetici = _yoneticiRepository.findAll();
        return View(yonetici);
        
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        Yonetici yonetici = _yoneticiRepository.findByID(id);
        return View(yonetici);
    }

    [HttpPost]
    public IActionResult Edit(Yonetici yonetici)
    {
        _yoneticiRepository.edit(yonetici);
        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        Yonetici yonetici = _yoneticiRepository.findByID(id);
        return View(yonetici);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        _yoneticiRepository.delete(id);
        return RedirectToAction("List");
    }

    [HttpGet]
    public IActionResult SanatciList()
    {
        IQueryable<Sanatci> sanatci = 
                            _sanatciRepository.findAll();
        return View(sanatci);
    }

    [HttpGet]
    public IActionResult SanatciCreate()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SanatciCreate(Sanatci sanatci)
    {
        _sanatciRepository.add(sanatci);
        return RedirectToAction("SanatciList");
    }

    [HttpGet]
    public IActionResult SanatciEdit(int id)
    {
        Sanatci sanatci = _sanatciRepository.findByID(id);
        return View(sanatci);
    }
    
    [HttpPost]
    public IActionResult SanatciEdit(Sanatci sanatci)
    {
        _sanatciRepository.edit(sanatci);
        return RedirectToAction("SanatciList");
    }

    [HttpGet]
    public IActionResult SanatciDelete(int id)
    {
        Sanatci sanatci = _sanatciRepository.findByID(id);
        return View(sanatci);
    }

    [HttpPost, ActionName("SanatciDelete")]
    public IActionResult SanatciDeleteConfirmed(int id)
    {
        _sanatciRepository.delete(id);
        return RedirectToAction("SanatciList");
    }

    [HttpGet]
    public IActionResult KullaniciList()
    {
        IQueryable<Kullanici> kullanici = 
                            _kullaniciRepository.findAll();
        return View(kullanici);
    }

    [HttpGet]
    public IActionResult KullaniciCreate()
    {
        return View();
    }

    [HttpPost]
    public IActionResult KullaniciCreate(Kullanici kullanici)
    {
        _kullaniciRepository.add(kullanici);
        return RedirectToAction("KullaniciList");
    }

    [HttpGet]
    public IActionResult KullaniciEdit(int id)
    {
        Kullanici kullanici = _kullaniciRepository.findByID(id);
        return View(kullanici);
    }
    
    [HttpPost]
    public IActionResult KullaniciEdit(Kullanici kullanici)
    {
        _kullaniciRepository.edit(kullanici);
        return RedirectToAction("KullaniciList");
    }

    [HttpGet]
    public IActionResult KullaniciDelete(int id)
    {
        Kullanici kullanici = _kullaniciRepository.findByID(id);
        return View(kullanici);
    }

    [HttpPost, ActionName("KullaniciDelete")]
    public IActionResult KullaniciDeleteConfirmed(int id)
    {
        _kullaniciRepository.delete(id);
        return RedirectToAction("KullaniciList");
    }

    [HttpGet]
    public IActionResult MuzikList()
    {
        
        IQueryable<Muzik> muzik = 
                            _muzikRepository.findAll();
        
        return View(muzik);
    }

    [HttpGet]
    public IActionResult MuzikCreate()
    {
        ViewBag.Sanatcis = new SelectList(
            _sanatciRepository.findAll(), "sanatciID", "sanatciAd");
        return View();
    }

    [HttpPost]
    public IActionResult MuzikCreate(Muzik muzik)
    {
        _muzikRepository.add(muzik);
        return RedirectToAction("MuzikList");
    }

    [HttpGet]
    public IActionResult MuzikEdit(int id)
    {
        ViewBag.Sanatcis = new SelectList(
            _sanatciRepository.findAll(), "sanatciID", "sanatciAd");
        Muzik muzik = _muzikRepository.findByID(id);
        return View(muzik);
    }
    
    [HttpPost]
    public IActionResult MuzikEdit(Muzik muzik)
    {
        _muzikRepository.edit(muzik);
        return RedirectToAction("MuzikList");
    }

    [HttpGet]
    public IActionResult MuzikDelete(int id)
    {
        Muzik muzik = _muzikRepository.findByID(id);
        return View(muzik);
    }

    [HttpPost, ActionName("MuzikDelete")]
    public IActionResult MuzikDeleteConfirmed(int id)
    {
        _muzikRepository.delete(id);
        return RedirectToAction("MuzikList");
    }

    [HttpGet]
    public IActionResult EtiketList()
    {
        IQueryable<Etiket> etiket = 
                            _etiketRepository.findAll();
        return View(etiket);
    }

    [HttpGet]
    public IActionResult EtiketCreate()
    {
        ViewBag.Muziks = new SelectList(
            _muzikRepository.findAll(), "muzikID", "muzikAd");
        return View();
    }

    [HttpPost]
    public IActionResult EtiketCreate(Etiket etiket)
    {
        _etiketRepository.add(etiket);
        return RedirectToAction("EtiketList");
    }

    [HttpGet]
    public IActionResult EtiketEdit(int id)
    {
        ViewBag.Muziks = new SelectList(
            _muzikRepository.findAll(), "muzikID", "muzikAd");
        Etiket etiket = _etiketRepository.findByID(id);
        return View(etiket);
    }
    
    [HttpPost]
    public IActionResult EtiketEdit(Etiket etiket)
    {
        _etiketRepository.edit(etiket);
        return RedirectToAction("EtiketList");
    }

    [HttpGet]
    public IActionResult EtiketDelete(int id)
    {
        Etiket etiket = _etiketRepository.findByID(id);
        return View(etiket);
    }


    [HttpPost, ActionName("EtiketDelete")]
    public IActionResult EtiketDeleteConfirmed(int id)
    {
        _etiketRepository.delete(id);
        return RedirectToAction("EtiketList");
    }

    [HttpGet]
    public IActionResult YorumList()
    {
        
        IQueryable<Yorum> yorum = 
                            _yorumRepository.findAll();
        return View(yorum);
    }

    [HttpGet]
    public IActionResult YorumCreate()
    {
        ViewBag.Muziks = new SelectList(
            _muzikRepository.findAll(), "muzikID", "muzikAd");
        ViewBag.Kullanicis = new SelectList(
            _kullaniciRepository.findAll(), "kullaniciID", "username");
        return View();
    }

    [HttpPost]
    public IActionResult YorumCreate(Yorum yorum)
    {
        _yorumRepository.add(yorum);
        return RedirectToAction("YorumList");
    }

    [HttpGet]
    public IActionResult YorumEdit(int id)
    {
        ViewBag.Muziks = new SelectList(
            _muzikRepository.findAll(), "muzikID", "muzikAd");
        ViewBag.Kullanicis = new SelectList(
            _kullaniciRepository.findAll(), "kullaniciID", "username");
        Yorum yorum = _yorumRepository.findByID(id);
        return View(yorum);
    }
    
    [HttpPost]
    public IActionResult YorumEdit(Yorum yorum)
    {
        _yorumRepository.edit(yorum);
        return RedirectToAction("YorumList");
    }

    [HttpGet]
    public IActionResult YorumDelete(int id)
    {
        Yorum yorum = _yorumRepository.findByID(id);
        return View(yorum);
    }


    [HttpPost, ActionName("yorumDelete")]
    public IActionResult YorumDeleteConfirmed(int id)
    {
        _yorumRepository.delete(id);
        return RedirectToAction("YorumList");
    }

}