using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Class
{
    public class Comision:Empleado
    {
        public int ventasBrutas { get; set; }
        public int tarifarioComision { get; set; }
    }
}

