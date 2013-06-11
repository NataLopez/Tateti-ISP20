using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_ISP20
{
    public class Juego
    {
        //propiedades definidas por nosotros mismos
        private Tablero tablero;
        private Jugador jugador1;
        private Jugador jugador2;

        public Juego()
        {
            tablero = new Tablero();
            jugador1 = new Jugador("X");
            jugador2 = new Jugador("0");
        }

        public void PintarTablero()
        {
            tablero.Limpiar();
            //recorre las fichas de los jugadores y va grabando
            //en las posiciones del tablero el 
            //tipo de ficha del jugador
            foreach (DictionaryEntry ficha in jugador1.fichas)
            {
                tablero.posiciones[ficha.Value] = jugador1.tipo_ficha+ficha.Key.ToString();
            }
            //ficha es de tipo dictionary entry (entrada de diccionario)
            //usamos ficha para saber la posicion q tiene definida ese jugador en sus fichas
            foreach (DictionaryEntry ficha in jugador2.fichas)
            {
                //ficha.value para saber cual es la posicion que tiene definida ese
                //jugador en sus fichas
                //imprime el tipo de ficha dle jugador 2
                tablero.posiciones[ficha.Value] = jugador2.tipo_ficha+ficha.Key.ToString();
            }

            //tablero.Marcar(jugador, pos_elegida);
            tablero.Pintar();
        }

        public int SeleccionarFicha(int jugador_actual)
        {
            int ficha_a_mover = 0;
            Console.Write("Jugador {0}: Ingrese el nro de ficha a mover: ", jugador_actual);
            //obtenemos una variable llamada posicion elegida
            // toma esa posicion y la convierte en entera
            try
            {
                ficha_a_mover = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Error, Valor Incorrecto, presione una tecla para continuar");
                Console.ReadKey();
                SeleccionarFicha(jugador_actual);
            }
            return ficha_a_mover;
        }     
        
        public void Jugar(int jugador, int nroficha, int pos_elegida)
        {
            //almacena cada uno de los jugadores
            //en las posiciones elegidas
            if (jugador == 1)
                //almacena (en el diccionario) dentro de la ficha la posicion elegida
                jugador1.fichas[nroficha] = pos_elegida;
            else
                jugador2.fichas[nroficha] = pos_elegida;
             //recorremos las fichas del jugador uno tomando 
            //los valores de cada una de las posiciones de la ficha
            
         }
    }
}
