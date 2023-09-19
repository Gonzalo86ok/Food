using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class OutSide : Food
    {
        public string name { get; set; }
        public string adress { get; set; }
        public Localidad localidad { get; set; }
    }
}
