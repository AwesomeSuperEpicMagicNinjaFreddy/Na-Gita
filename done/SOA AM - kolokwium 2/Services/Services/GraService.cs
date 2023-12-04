using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL.EF;
using Services.Interfaces;
using Model.DataModels;
using ViewModels.ViewModels;
namespace Services.Services
{
    public class GraService : BaseService, IGra
    {
        public GraService(MyDbContext dbContext, IMapper mapper) : base(dbContext, mapper) { }
        public void AddVm(Gra gra)
        {
            _dbContext.Add(gra);
            _dbContext.SaveChanges();
        }
        public IList<GraVm> GetGry()
        {
            var baza = _dbContext.Gry?.ToList();
            var wyswietl = _mapper.Map<IList<GraVm>>(baza);
            return wyswietl;
        }
        public void Remove(int id)
        {
            var sam = _dbContext.Gry?.FirstOrDefault(g => g.Id == id);
            _dbContext.Gry?.Remove(sam);
            _dbContext.SaveChanges();
        }
        public void Update(GraVm graVm, int id)
        {
            var sam = _mapper.Map<Gra>(graVm);
            sam.Id = id;
            var auto = _dbContext.Gry?.FirstOrDefault(g => g.Id == id);
            _dbContext.Gry?.Update(auto);
            _dbContext.SaveChanges();
        }
        public GraVm Get(int id)
        {
            var sam =_dbContext.Gry?.FirstOrDefault(g => g.Id == id);
            var gra = _mapper.Map<GraVm>(sam);
            return gra;
        }
    }
}
