using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    public interface IForo
    {
        Comentario PostearComentario(string texto);
        void AprobarComentario(Comentario comentario);
    }
}
