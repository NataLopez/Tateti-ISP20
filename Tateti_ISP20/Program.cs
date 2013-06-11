using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tateti_ISP20
{
    class Program
    {
        static void Main(string[] args)
        {
            //crea-inicializa un objeto de tipo juego
            //dispara la ejecucion del constructor del juego
            //y así sucesivamente
            Juego juego = new Juego();
            //
            int jugador_actual = 1;
            int ficha_actual = 1;
            int ficha_a_mover = 0;
            int posicion_elegida = 0;
            while (true)
            {
                //llama al metodo pintar de la clase tablero
                juego.PintarTablero();
                //pide ingresar la ficha a mover
                //cuando ya se colocaron las 6 fichas pide
                //definir la ficha a mover
                if (ficha_actual == 0)
                {
                        ficha_a_mover=juego.SeleccionarFicha(jugador_actual);
                        Console.Write("Jugador {0}: Ingrese la posicion de la ficha {1}", jugador_actual, ficha_a_mover);
                        //obtenemos una variable llamaba posicion elegida,
                        //toma esa posicion y la hace entera
                        posicion_elegida = Convert.ToInt32(Console.ReadLine());
                        //almacena el movimiento en el tablero y en las
                        //fichas del jugador
                        juego.Jugar(jugador_actual, ficha_a_mover, posicion_elegida);
                        
                    }
                //en las primeras 6 fichas se ejecuta esto
                else
                {
                    //pide ingresar el movimiento
                    Console.Write("Jugador {0}: Ingrese la posicion de la ficha {1}", jugador_actual, ficha_actual);
                    //obtenemos una variable llamaba posicion elegida,
                    //toma esa posicion y la hace entera
                    posicion_elegida = Convert.ToInt32(Console.ReadLine());
                    //almacena el movimiento en el tablero y en las
                    //fichas del jugador
                    juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
                }
                    //cambio de jugador 
                    jugador_actual++;
                    //si jugador 1 llega a 3 , que vuelva a ser 1
                    //e incrementa la ficha
                if (jugador_actual == 3)
                {
                    jugador_actual = 1;
                    if (ficha_actual > 0)
                    {
                        ficha_actual++;
                        //cuando ficha actual es igual a 4 , hacemos que vuelva a 0
                        if (ficha_actual == 4)
                            ficha_actual = 0;
                    }
                   
                }
            }

        }
    }
}
