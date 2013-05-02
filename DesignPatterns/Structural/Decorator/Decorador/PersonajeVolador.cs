using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Decorator
{
    //El PersonajeVolador es un PersonajeNormal decorado.
    public class PersonajeVolador: Personaje
    {
        Personaje _personaje;

        public PersonajeVolador()
        {
            _personaje = new PersonajeNormal();
        }

        //Puede ejecutar la habilidad del PersonajeNormal y además agregarle comportamiento adicional.
        public override string EjecutarHabilidad()
        {
            return _personaje.EjecutarHabilidad() + " y volar";
        }  
    }
}
