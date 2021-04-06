using System.Collections.Generic;

using System.CodeDom.Compiler;
using System.Security.Cryptography.X509Certificates;
using System;
namespace LeerData
{
    public class Curso
    {
        public int CursoId {get; set;}
        public string Titulo {get; set;}
        public string Descripcion {get; set;}
        public DateTime FechaPublicacion {get; set;}
        
        public Precio PrecioPromocion{get; set;}
        public ICollection <Comentario> ComentarioLista {get; set;}
        
    }
}