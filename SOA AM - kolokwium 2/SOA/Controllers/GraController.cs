using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using ViewModels.ViewModels;
using Model.DataModels;
namespace Web.Controllers
{
    public class GraController : BaseController
    {
        private readonly IGra _gra;
        public GraController(IMapper mapper, IGra gra) : base(mapper)
        {
            _gra = gra;
        }
        
        public IActionResult Index()
        {
            var wynik = _gra.GetGry();
            return View(wynik);
        }
        public IActionResult AddVm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddVm(GraVm graVm)
        {
            var gra = _mapper.Map<Gra>(graVm);
            _gra.AddVm(gra);
            return View();
        }
        [HttpPost]
        public IActionResult Index(GraVm graVm, int id)
        {
            _gra.Update(graVm, id);
            var wynik = _gra.GetGry();
            return View(wynik);
        }
        [HttpPost]
        public IActionResult Remove(int Id)
        {
            _gra.Remove(Id);
            var wynik = _gra.GetGry();
            Index();
            return View(wynik);
        }
        [HttpPost]
        public IActionResult Update(int Id)
        {
            var wynik = _gra.Get(Id);
            return View(wynik);
        }
    }
}
