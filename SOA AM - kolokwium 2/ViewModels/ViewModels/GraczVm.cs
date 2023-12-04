using Model.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ViewModels
{
    public class GraczVm
    {
        public int Id { get; set; }
        public string? Nick { get; set; }
        public string? Narodowosc { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public virtual ICollection<Gra>? Gry { get; set; }
    }
}
