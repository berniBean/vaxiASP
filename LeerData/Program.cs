using System.Threading;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using LeerData;

namespace leerdata
{
    class Program
    {
        static async Task Main(string[] args)
        {
           var task = new Task(()=>
           {
                using  (var db = new AppVentaCursosContext())
                {                    
                    var cursos = db.Curso.AsNoTracking();
                    foreach (var item in cursos)
                    {
                        System.Console.WriteLine(item.Titulo);
                    }
                }
           });
           task.Start();

           await task;

            await Trabajo2();
            await ComentariosAsync();


           Console.WriteLine("He terminado la tarea");



        }
            public static async Task ComentariosAsync(){
                var task = new Task(()=>{
                    using  (var db = new AppVentaCursosContext()){
                        var Cursos = db.Curso.Include(c => c.ComentarioLista).AsNoTracking();

                        foreach (var curso in Cursos)
                        {
                            Console.WriteLine(curso.Titulo);
                            foreach (var comentario in curso.ComentarioLista)
                            {
                                System.Console.WriteLine("************"+comentario.ComentarioTexto);
                            }
                        }
                    }
                });
                task.Start();
                await task;
            }


            public static async Task Trabajo2(){
            var task = new Task(()=>{
            using  (var db = new AppVentaCursosContext())
            {
                System.Console.WriteLine("hola mundo");
                var cursos = db.Curso.AsNoTracking();
                foreach (var item in cursos)
                {
                    System.Console.WriteLine(item.Titulo);
                }

                var precio = db.Curso.Include(p=>p.PrecioPromocion).AsNoTracking();
                foreach (var curso in precio)
                {
                    System.Console.WriteLine(curso.Titulo+"----------"+curso.PrecioPromocion.PrecioActual);
                }
                }
               });
               task.Start();
               await task;

           }
    }
}
