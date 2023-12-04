using Model.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.ViewModels
{
    public class GraVm
    {
        public int? Id { get; set; }
        public string? Tytul { get; set; }
        public DateTime? RokWydania { get; set; }
        public virtual ICollection<Gracz>? Gracze { get; set; }
        public virtual Wydawnictwo? Wydawnictwo { get; set; }
    }
}
