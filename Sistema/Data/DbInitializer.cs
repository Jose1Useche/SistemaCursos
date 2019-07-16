using Sistema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaContext context)
        {
            context.Database.EnsureCreated(); //Con este comando creo la base de datos

            //Verificar si existen registros en la tabla categoría
            if (context.Categoria.Any())
            {
                return;
            }
            var categorias = new Categoria[]
            {
                new Categoria{Nombre = "Programación", Descripcion = "Cursos de Programación", Estado = true},
                new Categoria{Nombre = "Diseño Gráfico", Descripcion = "Cursos de Diseño Gráfico", Estado = true}
            };

            foreach (var categoria in categorias)
            {
                context.Categoria.Add(categoria);
            }

            context.SaveChanges(); 
        }
    }
}
