using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multas
{
    public class Multa
    {

        public int? Id { get; set; }

        public string dni { get; set; }

        public DateTime fechaExp { get; set; }

        public DateTime fechaLim { get; set; }

        public float importe { get; set; }

        public string observaciones { get; set; }

        public int nAgente { get; set; }
    }
}
