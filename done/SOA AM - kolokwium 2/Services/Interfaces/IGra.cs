using Model.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.ViewModels;

namespace Services.Interfaces
{
    public interface IGra
    {
        public void AddVm(Gra gra);
        public IList<GraVm> GetGry();
        public GraVm Get(int id);
        public void Remove(int id);
        public void Update(GraVm graVm, int id);
    }
}
