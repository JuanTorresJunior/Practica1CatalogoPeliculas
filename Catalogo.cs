using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Practica1CatalogoPeliculas
{
    class Catalogo
    {
        // Atributos
        string tituloPelicula;
        string duracion;
        string anio;
        string idioma;
        string casaProductora;
        string director;
        string genero;

        static List<Catalogo> Peliculas = new List<Catalogo>();

        // Constructores
        public Catalogo()
        {
            tituloPelicula = "";
            duracion = "";
            anio = "";
            idioma = "";
            casaProductora = "";
            director = "";
            genero = "";
        }

        // Métodos
        public void AgregarPelicula(string nom, string duracionParametro, string anioParametro, string idiomaParametro, string casaProductoraP, string directorParametro, string generoParametro)
        {
            tituloPelicula = nom;
            duracion = duracionParametro;
            anio = anioParametro;
            idioma = idiomaParametro;
            casaProductora = casaProductoraP;
            director = directorParametro;
            genero = generoParametro;
        }

        public void ActualizarInfo(string nom, string duracionParametro, string anioParametro, string idiomaParametro, string casaProductoraP, string directorParametro, string generoParametro)
        {
            var PeliculasFiltro = from p in Peliculas where p.tituloPelicula.Equals(nom) select p ;
            foreach (var item in PeliculasFiltro)
            {
                tituloPelicula = nom;
                duracion = duracionParametro;
                anio = anioParametro;
                idioma = idiomaParametro;
                casaProductora = casaProductoraP;
                director = directorParametro;
                genero = generoParametro;
            }
        }
        public string VerInfo()
        {
            return $"\nNombre: {tituloPelicula} " +
                $"\nDuracion: {duracion} " +
                $"\nAño: {anio} " +
                $"\nIdioma: {idioma} " +
                $"\nCasa Productora: {casaProductora} " +
                $"\nDirector: {director} " +
                $"\nGenero: {genero} ";
        }

        public void BuscarNombre()
        {
            Console.WriteLine("Ingrese el nombre de la película a buscar: ");
            string buscarNombre = Console.ReadLine();
            Console.WriteLine($"Resultados de la búsqueda de {buscarNombre}...\n");
            for (int i = 0; i <= Peliculas.Count() - 1; i++)
            {
                if (buscarNombre == Peliculas[i].tituloPelicula)
                {
                    Console.WriteLine(Peliculas[i].VerInfo());
                }
                else
                {
                    Console.WriteLine("No se encontraron resultados");
                }
            }
        }
        public void BuscarDirector()
        {
            Console.WriteLine("Ingrese el nombre del director a buscar: ");
            string buscarDirector = Console.ReadLine();
            Console.WriteLine($"Resultados de la búsqueda de {buscarDirector}...\n");
            for (int i = 0; i <= Peliculas.Count() - 1; i++)
            {
                if (buscarDirector == Peliculas[i].director)
                {
                    Console.WriteLine(Peliculas[i].VerInfo());
                }
                else
                {
                    Console.WriteLine("No se encontraron resultados");
                }
            }
        }

        public void BuscarGenero()
        {
            Console.WriteLine("Ingrese el género de la película a buscar: ");
            string buscarGenero = Console.ReadLine();
            Console.WriteLine($"Resultados de la búsqueda de {buscarGenero}...\n");
            for (int i = 0; i <= Peliculas.Count() - 1; i++)
            {
                if (buscarGenero == Peliculas[i].director)
                {
                    Console.WriteLine(Peliculas[i].VerInfo());
                }
                else
                {
                    Console.WriteLine("No se encontraron resultados");
                }
            }
        }

        // Método Main
        public void PuntoAcceso()
        {
            bool mostrarMenu = true;

            Ui Menu = new Ui();
            Console.WriteLine(Menu);

            int contadorArreglo = 0;

            while (mostrarMenu == true)
            {
                
                Console.Write("\nSeleccione una opción: ");

                int opcionMenu = int.Parse(Console.ReadLine());


                switch (opcionMenu)
                {
                    case 1:

                        Peliculas.Add(new Catalogo());
                        Console.Write("\nIngrese el nombre: ");
                        string nom = Console.ReadLine();
                        Console.Write("Ingrese la duración: ");
                        string duracion = Console.ReadLine();
                        Console.Write("Ingrese el año: ");
                        string anio = Console.ReadLine();
                        Console.Write("Ingrese el idioma: ");
                        string idioma = Console.ReadLine();
                        Console.Write("Ingrese la casa Productora: ");
                        string casaProductora = Console.ReadLine();
                        Console.Write("Ingrese el nombre del director: ");
                        string director = Console.ReadLine();
                        Console.Write("Ingrese el género: ");
                        string genero = Console.ReadLine();

                        Peliculas[contadorArreglo].ActualizarInfo(nom, duracion, anio, idioma, casaProductora, director, genero);
                        Peliculas[contadorArreglo].AgregarPelicula(nom, duracion, anio, idioma, casaProductora, director, genero);
                       
                        contadorArreglo += 1;

                        break;

                    case 2:
                        for (int i = 0; i <= Peliculas.Count() - 1; i++)
                        {
                            Console.WriteLine(Peliculas[i].VerInfo());
                        }
                        break;
                    case 3:
                        BuscarNombre();
                        break;
                    case 4:
                        BuscarDirector();
                        break;
                    case 5:
                        BuscarGenero();
                        break;
                    case 0:
                        mostrarMenu = false;
                        break;
                    default: break;
                }
            }
        }
    }
}
