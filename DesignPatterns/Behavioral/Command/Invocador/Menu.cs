using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class Menu
    {
        ContenedorTexto _receptor;
        List<Comando> _listaComandos;

        public Menu(ContenedorTexto contenedorTexto)
        {
            _receptor = contenedorTexto;
            _listaComandos = new List<Comando>();            
        }

        //El invocador es el que fabrica el comando concreto
        public string EjecutarOpcion(Opciones opcion)
        {
            string resultado = string.Empty;

            Comando comando = null;

            switch (opcion)
            {
                case Opciones.Copiar:
                    comando = new ComandoCopiar(_receptor);
                    break;
                case Opciones.Cortar:
                    comando = new ComandoCortar(_receptor);
                    break;
                case Opciones.Pegar:
                    comando = new ComandoPegar(_receptor);
                    break;
            }

            //El comando es tratado indistintamente
            resultado = comando.Ejecutar();

            //Se agrega al repositorio de comandos ejecutados para poder hacer Undo
            _listaComandos.Add(comando);

            return resultado;
        }

        /// <summary>
        /// Recorre la lista de comandos ejecutados y los vuelte a ejecutar hacia atrás
        /// </summary>
        public string Deshacer()
        {
            for (int i = _listaComandos.Count; i==0; i--)
            {
                _listaComandos.ElementAt(i).Ejecutar();
            }

            return _receptor.Texto;
        }
    }
}
