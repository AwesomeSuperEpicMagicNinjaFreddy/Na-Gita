using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DataModels
{
    public class Gracz
    {
        public int Id { get; set; }
        public string Nick { get; set; }
        public string Narodowosc { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public virtual ICollection<Gra> Gry { get; set; }
    }
}
