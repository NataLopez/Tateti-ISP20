using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cliente
{
    class Cliente
    {
        
        private string nombre, apellido, direccion, localidad, telefono;
        public int codigo;
        private DateTime FechaNac;

        private void CapturarNombre()
        {
            //se escribe en consola ingrese nombre, le asigna a la variable nombre, el mismo ingresado
            //si el valor es nulo, se escribe en consola error y llama al metodo capturar nombre
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            if (nombre == "")
            {
                Console.WriteLine("Error al ingresar el nombre. Intente nuevamente");
                CapturarNombre();
            }
        }

        private void CapturarApellido()
        {
            //se escribe en consola ingrese apellido, le asigna a la variable apellido, el mismo ingresado
            //si el valor es nulo, se escribe en consola error y llama al metodo capturar apellido
            Console.Write("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            if (apellido == "")
            {
                Console.WriteLine("Error al ingresar apellido. Intente nuevamente");
                CapturarApellido();
            }
         }

        private void CapturarDireccion()
        {
            //se escribe en consola ingrese direccion, le asigna a la variable nombre, el mismo ingresado
            //si el valor es nulo, se escribe en consola error y llama al metodo capturar direccion
            Console.Write("Ingrese su dirección: ");
            direccion = Console.ReadLine();
            if (direccion == "")
            {
                Console.WriteLine("Error al ingresar direccion. Intente nuevamente");
                CapturarDireccion();
            }
        }

        private void CapturarLocalidad()
        {
            //se escribe en consola ingrese localidad, le asigna a la variable nombre, el mismo ingresado
            //si el valor es nulo, se escribe en consola error y llama al metodo capturar localidad
            Console.Write("Ingrese su localidad: ");
            localidad = Console.ReadLine();
            if (localidad == "")
            {
                Console.WriteLine("Error al ingresar localidad. Intente nuevamente");
                CapturarLocalidad();
            }
        }

        private void CapturarTelefono()
        {
            //se escribe en consola ingrese tel, le asigna a la variable nombre, el mismo ingresado
            //si el valor es nulo, se escribe en consola error y llama al metodo capturar tel
            Console.Write("Ingrese su teléfono: ");
            telefono = Console.ReadLine();
            if (telefono == "")
            {
                Console.WriteLine("Error al ingresar telefono. Intente nuevamente");
                CapturarTelefono();
            }
        }

        private void CapturarCodigo()
        {
            Console.Write("Ingrese su Codigo: ");
            //intenta convertir a entero lo que escribe el usuario
            try
            {
                codigo = Convert.ToInt32(Console.ReadLine());
            }
            //si la conversion falló vuelve a llamar al metodo
            catch
            {
                Console.WriteLine("Error al ingresar su codigo. Intente nuevamente");
                CapturarCodigo();
            }
        }

        private void CapturarFechaNac()
        {
            Console.Write ("Ingrese su Fecha de Nacimiento: ");
        //intenta convertir a datetime lo que escribe el usuario
        try 
        {
            FechaNac = Convert.ToDateTime (Console.ReadLine ());
        }
        //si la conversion falló vuelve a llamar al metodo
        catch 
        {
            Console.WriteLine("Error al ingresar la fecha de nacimiento. Intente nuevamente");
            CapturarFechaNac ();
        }
}
 
 
 
        public string ImprimirFicha() 
        {
            string ficha="FICHA PERSONAL CLIENTE";
            ficha += "\nCodigo: " + codigo;
            ficha+="\nNombre: " + nombre;
            ficha+= "\nApellido: " + apellido;
            ficha+= "\nDireccion: " + direccion; 
            ficha+= "\nLocalidad: " + localidad; 
            ficha+= "\nTelefono: " + telefono; 
            ficha += "\nFechaNac:" + FechaNac.Date.ToShortDateString();
            return ficha;
        }

        public void CapturarDatos()
        {
            CapturarCodigo();
            CapturarNombre();
            CapturarApellido();
            CapturarDireccion();
            CapturarLocalidad();
            CapturarTelefono();
            CapturarFechaNac();
        }

        private string Presentarse()
        {
            string presentacion = ("Hola soy:" + nombre + "" +apellido);
            return presentacion;
    
        }

        public void Listar()
        {   //imprimimos en un renglon los datos de un cliente
            Console.WriteLine("|{0}|{1}|{2}|{3}|{4}|",codigo, nombre, apellido, direccion, localidad);
            
        }

        private string AnunciarDomicilio()
        {
            string anunciar=("Vivo en: " +direccion+ " - " +localidad);
            return anunciar;
        }

        public string AnunciarEdad()
        {   //calculamos edad y la mostramos en un texto
            int edad;
            DateTime hoy = DateTime.Now;
            edad = hoy.Year - FechaNac.Year;
            string anunciared=("Nací en el año " + FechaNac.Year + " y tengo " + edad + " años de edad");
            return anunciared;
        }

        public void Hablar()
        {
            Console.WriteLine(Presentarse());
            Console.WriteLine(AnunciarDomicilio());
            Console.WriteLine(AnunciarEdad());
        }
}
 

    }

