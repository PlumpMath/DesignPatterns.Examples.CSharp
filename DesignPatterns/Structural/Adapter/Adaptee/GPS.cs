using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{

    /// <summary>
    /// Una librería encapsulada, supongamos de terceros, que proporciona la Geolocalización de un dispositivo.
    /// </summary>
    public class GPS
    {
        public GEOPoint GetLocation()
        {
            //Suponemos que la librería devuelve un tipo de dato no compatible con nuestro modelo de negocio
            return new GEOPoint(200, 200);
        }
    }

    public class GEOPoint
    {
        public GEOPoint(int lat, int long1)
        {
            this.Lat = lat;
            this.Long = long1;
        }

        public int Lat{get;set;}
        public int Long{get;set;}
    }
}
