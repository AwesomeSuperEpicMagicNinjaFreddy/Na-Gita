using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataModels
{
    public class Gra
    {
        public int Id { get; set; }
        public string? Tytul { get; set; }
        public DateTime? RokWydania { get; set; }
        public virtual ICollection<Gracz>? Gracze { get; set; }
        public virtual Wydawnictwo? Wydawnictwo { get; set; }
    }
}
