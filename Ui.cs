using System;
using System.Collections.Generic;
using System.Text;

namespace Practica1CatalogoPeliculas
{
    class Ui
    {
        public override string ToString()
        {
            return "\n**********************************" +
            "\n***** Catálogo de Películas ******" +
            "\n----------------------------------" +
            "\nLista de Opciones" +
            "\n----------------------------------" +
            "\n1. Agregar  nueva película" +
            "\n2. Listar todas las películas" +
            "\n3. Buscar película por nombre" +
            "\n4. Listar películas por director" +
            "\n5. Listar películas por género" +
            "\n0. Salir del Programa";
        }
    }
}
