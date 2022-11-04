using System;
using System.Collections.Generic;
using System.Text;

namespace ImpilicitvsExplicit_Generictypes.Temperature {
    class Celius {
        public int Degree { get; set; }


        public static implicit operator Kelvin( Celius celius)
        {
            return new Kelvin { Degree  = celius.Degree + 273 };
        }
    }
}
