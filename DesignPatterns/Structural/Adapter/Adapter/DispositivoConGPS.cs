using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    /// <summary>
    /// Clase que adapta la libreria de tercerps (GPS) al cliente.
    /// </summary>
    public  class DispositivoConGPS: Dispositivo
    {
        //La clase Adapter compone al objeto que quiere adaptar
        GPS _gpsTerceros;

        public DispositivoConGPS()
        {
            _gpsTerceros = new GPS();
        }

        public override string MostrarGEOLocalizacion()
        {
            GEOPoint geoPoint = _gpsTerceros.GetLocation();
            return string.Concat(geoPoint.Lat, " - ", geoPoint.Long);
        }
    }
}
