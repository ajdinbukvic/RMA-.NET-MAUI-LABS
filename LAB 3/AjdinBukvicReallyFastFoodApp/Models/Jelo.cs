using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjdinBukvicReallyFastFoodApp.Models
{
    public class Jelo
    {
        public int Id { get; set; }
        public string Icon { get; set; }
        public string Naziv { get; set; }
        public int Cijena { get; set; }
        public int Kalorije { get; set; }
        public bool Odabrano { get; set; }
        public int Kolicina { get; set; }
    }
}
