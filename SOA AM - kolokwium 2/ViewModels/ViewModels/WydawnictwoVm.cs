using Model.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ViewModels
{
    public class WydawnictwoVm
    {
        public int Id { get; set; }
        public string? Nazwa { get; set; }
        public string? Siedziba { get; set; }
        public virtual ICollection<Gra>? Gry { get; set; }
    }
}
