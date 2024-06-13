using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.Class
{
    abstract class Calcular :Empleado
    {
            public abstract void CalcularSueldos();


        }

    internal class SueldoHoras : Calcular
    {
        public override void CalcularSueldos()
        {
            EmpleadoPorHoras empleadoPorHoras = new EmpleadoPorHoras();
            var SueldoPorhoras = empleadoPorHoras.SueldoPorHoras;
            var HorasTrabajas = empleadoPorHoras.horasTrabajadas;
            int resultado = empleadoPorHoras.resultado;
            if (SueldoPorhoras <= 40) {

               resultado= SueldoPorhoras* HorasTrabajas;
            
            }
        }
    }


    internal class SueldoComosion : Calcular
    {
        public override void CalcularSueldos()
        {
            EmpleadoMasComision empleadoPorcomision = new EmpleadoMasComision();
            var SueldoPorcomision = empleadoPorcomision.ventasBrutas;
            var tarifario = empleadoPorcomision.tarifarioComision;
            int resultado = empleadoPorcomision.resultado;


                resultado = tarifario * SueldoPorcomision;
        }
    }

}
