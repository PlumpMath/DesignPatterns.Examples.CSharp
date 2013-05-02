using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    public class Foro: IForo
    {
        public Comentario PostearComentario(string texto)
        {
            return new Comentario("Mi comentario");
        }

        public void AprobarComentario(Comentario comentario)
        {
            comentario.Aprobado = true;            
        }
    }
}
