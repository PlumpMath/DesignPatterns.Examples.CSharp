using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    public class PersonajeNormal: Personaje
    {
        public override string EjecutarHabilidad()
        { 
            //Un personaje normal puede solamente caminar
            return "Caminar";
        }      
    }
}
