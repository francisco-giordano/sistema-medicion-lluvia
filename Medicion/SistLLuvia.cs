using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyeto_Medicios_de_LLuvia
{
    public static class SistLLuvia 
    {

        // Lista estática para guardar todas las mediciones en memoria
        private static List<MedicionLluvia> historialMediciones = new List<MedicionLluvia>();

        // Método para agregar una nueva medición
        public static bool RegistrarMedicion(MedicionLluvia nuevaMedicion)
        {
            // Validamos que la localidad no sea un string vacío
            if (nuevaMedicion.Localidad == "")
            {
                return false;
            }

            // Validamos que el responsable no sea un string vacío
            if (nuevaMedicion.Responsable == "")
            {
                return false;
            }

            historialMediciones.Add(nuevaMedicion);

            // Opcional: Registrar en la bitácora
            seguridad.Bitacora.Registrar($"Nueva medición registrada en {nuevaMedicion.Localidad}: {nuevaMedicion.CantAgua}mm");

            return true;
        }

        // Método para obtener todas las mediciones
        public static List<MedicionLluvia> ObtenerTodas()
        {
            return historialMediciones;
        }

        // Método para filtrar mediciones por localidad
        public static List<MedicionLluvia> BuscarPorLocalidad(string localidadBuscada)
        {
            List<MedicionLluvia> resultados = new List<MedicionLluvia>();

            foreach (MedicionLluvia med in historialMediciones)
            {
                if (med.Localidad.ToLower() == localidadBuscada.ToLower())
                {
                    resultados.Add(med);
                }
            }
            return resultados;
        }

        // Método para calcular el total de agua caída
        public static double CalcularTotalAgua()
        {
            double total = 0;
            foreach (MedicionLluvia med in historialMediciones)
            {
                total += med.obtenerValor(); // Usamos el método polimórfico
            }
            return total;
        }

        public static List<MedicionLluvia> ConsultarMediciones(
            DateTime desde,
            DateTime hasta,
            string localidad)
        {
            return historialMediciones 
                .Where(m =>
                    m.FechaHora >= desde &&
                    m.FechaHora <= hasta &&
                    (localidad == "" || m.Localidad == localidad))
                .ToList();
        }

        public static MedicionLluvia ObtenerMayorRegistro(int hora)
        {
            return historialMediciones
                .Where(m => m.Obtenerhora() == hora)
                .OrderByDescending(m => m.CantAgua)
                .FirstOrDefault();
        }

        public static List<(MedicionLluvia Medicion,
                     double Diferencia,
                     string Estado)>
                 GenerarAlertas()
        {
            List<(MedicionLluvia, double, string)> listaAlertas =
                new List<(MedicionLluvia, double, string)>();

            var ordenadas = historialMediciones
                .OrderBy(m => m.FechaHora)
                .ToList();

            for (int i = 1; i < ordenadas.Count; i++)
            {
                double diferencia =
                    ordenadas[i].CantAgua -
                    ordenadas[i - 1].CantAgua;

                if (Math.Abs(diferencia) > 50)
                {
                    listaAlertas.Add(
                        (
                            ordenadas[i],
                            diferencia,
                            "ALERTA"
                        ));
                }
            }

            return listaAlertas;
        }
    }
}
