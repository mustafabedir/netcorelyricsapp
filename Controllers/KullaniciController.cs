using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Routing;

public class KullaniciController:Controller
{

    private IKullaniciRepository _kullaniciRepository;
    private ISanatciRepository _sanatciRepository;
    private IYorumRepository _yorumRepository;
    private IMuzikRepository _muzikRepository;
    private IEtiketRepository _etiketRepository;
    private  static int idDeger;

    public KullaniciController(IKullaniciRepository _kullaniciRepository,
                                ISanatciRepository _sanatciRepository,
                                IYorumRepository _yorumRepository,
                                IMuzikRepository _muzikRepository,
                                IEtiketRepository _etiketRepository)
    {
        this._kullaniciRepository = _kullaniciRepository;
        this._sanatciRepository = _sanatciRepository;
        this._yorumRepository = _yorumRepository;
        this._muzikRepository = _muzikRepository;
        this._etiketRepository = _etiketRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult List(int id)
    {
        if(id == 0)
        {
            id = idDeger;
        }
        idDeger = id;
        Kullanici kullanici = 
           _kullaniciRepository.findByID(id);
        
        return View(kullanici);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        Kullanici kullanici = _kullaniciRepository.findByID(id);
        idDeger = kullanici.kullaniciID;
        return View(kullanici);
    }

    [HttpPost]
    public IActionResult Edit(Kullanici kullanici)
    {
        kullanici.kullaniciID = idDeger;
        _kullaniciRepository.edit(kullanici);
        return RedirectToAction("Index");
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
    public IActionResult YorumCreate()
    {
        ViewBag.Muziks = new SelectList(
            _muzikRepository.findAll(), "muzikID", "muzikAd");
        ViewBag.Kullanicis = new SelectList(
            _kullaniciRepository.findAll().Where(i=> i.kullaniciID == idDeger), "kullaniciID", "username");
        return View();
    }

    [HttpPost]
    public IActionResult YorumCreate(Yorum yorum)
    {
        _yorumRepository.add(yorum);
        return RedirectToAction("YorumList");
    }


}