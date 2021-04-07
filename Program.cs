using System;
using System.Collections.Generic;

namespace Actividad_4
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Articulo> art = new List<Articulo>{ };
            Articulo articulos = new Articulo { };
            DateTime fecha = new DateTime();
            //Prueba codigo

            art.Add(new Articulo(1, "nombre1", "categoria1",1,"",fecha.Date));
           
            int opcion = 0;
            while (opcion != 4)
            {
                Console.WriteLine("Bienvenido" +
                    "\n1.- Ingresar articulo" +
                    "\n2.- Listar inventario" +
                    "\n3.- Buscar articulo" +
                    "\n4.- Terminar");
                opcion = Int32.Parse(Console.ReadLine());
                if (opcion < 4)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese ID");
                            articulos.Id = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Nombre");
                            articulos.Nombre = Console.ReadLine();
                            Console.WriteLine("Ingrese Categoria");
                            articulos.Categoria = Console.ReadLine();
                            Console.WriteLine("Ingrese Cantidad");
                            articulos.Cantidad = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Estado");
                            articulos.Estado = Console.ReadLine();
                            Console.WriteLine("Ingrese Fecha [yyyy-mm-aa]");
                            fecha = DateTime.Parse(Console.ReadLine());
                            articulos.Fecha = (fecha);
                            art.Add(new Articulo(articulos.Id, articulos.Nombre, articulos.Categoria, articulos.Cantidad, articulos.Estado, articulos.Fecha));
                            break;
                        case 2:
                            foreach (Articulo a in art)
                            {
                                Console.WriteLine("[ID: "+a.Id+
                                    " Nombre: "+a.Nombre+
                                    " Categoria: "+a.Categoria+
                                    " Cantidad: "+a.Cantidad+
                                    " Estado: "+a.Estado+
                                    " Fecha: "+a.Fecha.ToString("dd-MM-yyyy")+" ]");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el nombre a buscar");
                            string buscar = Console.ReadLine().Trim();
                            foreach (Articulo a in art)
                            {
                                if (buscar == a.Nombre)
                                {
                                    Console.WriteLine("[ID: " + a.Id +
                                    " Nombre: " + a.Nombre +
                                    " Categoria: " + a.Categoria +
                                    " Cantidad: " + a.Cantidad +
                                    " Estado: " + a.Estado +
                                    " Fecha: " + a.Fecha.ToString("dd-MM-yyyy") + " ]");
                                }
                                else
                                {
                                    Console.WriteLine("Nombre no ingresado");
                                }
                                
                            }
                            break;
                        default:
                            Console.WriteLine("Ingrese una opcion valida!");
                            break;
                    }
                }
            }
            }
    }
}
