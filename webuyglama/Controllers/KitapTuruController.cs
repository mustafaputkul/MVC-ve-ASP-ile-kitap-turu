using Microsoft.AspNetCore.Mvc;
using webuyglama.Utility;
using webuyglama.Models;

namespace webuyglama.Controllers
{
    public class KitapTuruController : Controller
    {
        private readonly UygulamaDBContext _uygulamaDbContext;

        public KitapTuruController(UygulamaDBContext context)
        {
            _uygulamaDbContext = context;
        }

        // Kitap türlerinin listelendiği sayfa
        public IActionResult Index()
        {
            var kitapTurleri = _uygulamaDbContext.KitapTurleri.ToList();
            return View(kitapTurleri);
        }

        // Kitap türü ekleme sayfası (GET)
        public IActionResult Ekle()
        {
            return View();
        }

        // Kitap türü ekleme işlemi (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Ekle(KitapTuru kitapTuru)
        {
            if (ModelState.IsValid)
            {
                _uygulamaDbContext.KitapTurleri.Add(kitapTuru);
                _uygulamaDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kitapTuru);
        }
    }
}
