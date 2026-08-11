using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia
{
    public class MedicionLluvia : Medicion, IComparable<MedicionLluvia>
    {

        public double CantAgua { get; set; }

        public override double obtenerValor()
        {
            return CantAgua;
        }
        public int Obtenerhora()
        {
            return FechaHora.Hour;
        }
        public int CompareTo(MedicionLluvia otraMedicion)
        {
            // Si la otra medición es nula, esta va primero
            if (otraMedicion == null) return 1;

            // Le decimos que ordene basándose en la cantidad de agua (de menor a mayor)
            return this.CantAgua.CompareTo(otraMedicion.CantAgua);
        }
    }
}
