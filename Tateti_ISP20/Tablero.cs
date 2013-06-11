using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_ISP20
{
    public class Tablero
    {
        //diccionario q permite manejar pares de valores
        public Hashtable posiciones;

        public Tablero()
        {
            //inicializa la variable posiciones
            posiciones = new Hashtable();
            //creamos-inicializamos las 9 posiciones con el valor vacio
            for (int i = 0; i < 10; i++)
            //agrega la posicion i y le dice que no
            //tiene valores
            posiciones.Add(i, "  ");
        }

        public void Marcar(int jugador, int pos_elegida)
        {
        
        
        }
        
        public void Limpiar()
        {
            //limpia el tablero
            for (int i = 0; i < 10; i++)
            posiciones[i] = "  ";
        }

        public void Pintar()
        {
            //borro la consola
            Console.Clear();
            //imprimo tablero y cada una de las posiciones
            //con sus respectivo valor
            for (int i = 0; i < 10; i++)
            {
                //{} etiqueta
                Console.Write("[{0}]", posiciones[i]);
                //utilizamos el modulo para detectar que ya se
                //imprimieron 3 casillerosy generamos un salto de linea
                if (i % 3 == 0)
                {
                    Console.Write("\n");
                }


            }

        }

          
    }
}
