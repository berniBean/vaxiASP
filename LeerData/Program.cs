using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using LeerData;

namespace leerdata
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new AppVentaCursosContext())
            {
                // var cursos = db.Curso.AsNoTracking();
                // foreach (var item in cursos)
                // {
                //     System.Console.WriteLine(item.Titulo);
                // }

                // var cursos = db.Curso.Include(p=>p.PrecioPromocion).AsNoTracking();
                // foreach (var curso in cursos)
                // {
                //     System.Console.WriteLine(curso.Titulo+"----------"+curso.PrecioPromocion.PrecioActual);
                // }

                var cursos = db.Curso.Include(c=>c.ComentarioLista).AsNoTracking();
                foreach (var item in cursos)
                {
                    System.Console.WriteLine(item.Titulo);
                    foreach (var comentario in cursos.ComentarioLista)
                    {
                        System.Console.WriteLine(comentario.ComentarioTexto);
                    }
 
                }
            }
        }
    }
}
