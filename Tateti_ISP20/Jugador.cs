using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_ISP20
{
    public class Jugador
    {
        //declaracion de las propiedades
        public Hashtable fichas;
        public string tipo_ficha;
        
        //tipo de ficha llega como parametro al 
        //metodo constructor
        public Jugador (string tipoficha)
        {
            //inicializamos las fichas
            fichas = new Hashtable();
            //el jugador tiene 3 fichas y tienen posicion 0
            fichas.Add(1,0);
            fichas.Add(2,0);
            fichas.Add(3,0);
            //el texto se almacena en tipoficha
            tipo_ficha=tipoficha;
        }
    
    }
}
