using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculos.Logic
{
    public abstract class Vehiculo
    {
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public int Anio { get; set; }

        public abstract string GetInformation() { 
            return $"Informacion del carro:  { Marca} { Modelo} { Anio}";
        };

        public abstract string RunAction() {
            Console.WriteLine("Sistema de registro de Vehiculos");
        };
                
        public override string ToString()
        {
            return $"Marca: {Marca}\n\t" +
                   $"Modelo:............... {Modelo,20}\n\t" +
                   $"Anio:.........{Anio,20}\n\t" +
        }
    }

}
