using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehiculo.Logic
{
    public class Automovil : Vehiculo
    {
        public int Puertas { get; set; }

        public NumPuertas( int NumPuerta)
        {
            Puertas = NumPuerta;
        }

        public override string GetInformation()
        {
            return $"{base.GetInformation()}\n\t" +
                $"Numero de puertas {Puertas}\n\t";
        }

        public override string RunAction()
        {
            return base.RunAction();
        }


        public class Camioneta : Vehiculo 
        {
            public int CapacidadCargo { get; set; }

        }
    }
}
