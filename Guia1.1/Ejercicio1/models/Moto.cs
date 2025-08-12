using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.models
{
    internal class Moto
    {
        public string Marca { get; private set; }
        public int Modelo { get; private set; }
        public double ValorFabricacion { get; private set; }

        public Moto(string marca, int modelo, double valorfabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            ValorFabricacion = valorfabricacion;
        }

        public double CalcularDepreciacionLineal (int añoACalcular, int vidaUtil)
        {
            int añosDeUso = añoACalcular - Modelo;
            return ValorFabricacion - (ValorFabricacion * añosDeUso / vidaUtil);
        }

        public double CalcularDepreciacionAnual(int añoACalcular, double tasaDepreciacion)
        {
            int añosDeUso = añoACalcular - Modelo;
            return ValorFabricacion * (Math.Pow(1 - tasaDepreciacion, añosDeUso));
        }

        public string VerDescripcion()
        {
            return $"Marca:{Marca}, Modelo:{Modelo}, Valor Fabriación: ${ValorFabricacion,10:f2}";
        }
    }
}
