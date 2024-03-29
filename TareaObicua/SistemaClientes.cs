﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Cliente
{
    public class SistemaClientes
    {
            ArrayList clientes = new ArrayList ();

            public SistemaClientes()
            {
                Console.WriteLine("Cargando el sistema de clientes");
            }
   
            public void Iniciar()
            {
                Menu();
            }
    
            private void ListarClientes()
            {
                foreach (Cliente cli in clientes)
                {
                    cli.Listar();
                }
            }

            private void BorrarClientes(int id_borrar)
            {
                foreach (Cliente cli in clientes)
                {
                    //si encontro el que coincido con el q quiero borrar
                    //se remueve del arraylist
                    //id_borrar es un parámetro 
                    if (cli.codigo == id_borrar)
                    {
                        clientes.Remove(cli);
                        break;
                    }

                }
            }
        
            private void Menu()
            {
                int opcion = 0;
                while (true)
                  {
                    Console.Clear();
                    Console.WriteLine("CARGA DE CLIENTES");
                    Console.WriteLine("1- Cargar un nuevo cliente");
                    Console.WriteLine("2- Listar clientes cargados");
                    Console.WriteLine("3- Borrar un cliente");
                    Console.WriteLine("4- Salir");
                    Console.WriteLine("Ingrese el numero de la opcion");
                    try
                    {
                        opcion = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Error en la opcion ingresada");
                        
                    }
                    
                    switch (opcion)
                            {
                                case 1:
                                    Cliente cliente = new Cliente();
                                    cliente.CapturarDatos();
                                    clientes.Add(cliente);
                                    break;
                                case 2:
                                    ListarClientes();
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    ListarClientes();
                                    Console.Write("Ingrese el numero de cliente a eliminar:");
                                    int eliminar_cliente= Convert.ToInt32(Console.ReadLine());
                                    BorrarClientes(eliminar_cliente);
                                    ListarClientes();
                                    Console.ReadLine();
                                    break;
                                case 4:
                                    return;
                            }
                   

                        }
                
                }

    
    }
    
}

