using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    internal class TakeWay : Food
    {
        public string nombreLocal { get; set; }
        public string direccion { get; set; }
        public string localidad { get; set; }
        public string descripcion { get; set; }
    }
}
