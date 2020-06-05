using System.Collections.Generic;
namespace Kalum2020v1.Models
{
    public class Religion
    {
        public int ReligionId{get;set;}
        public string Descripcion{get;set;}
        public virtual List<Alumno> Alumnos{get;set;}//se pone cuando es la relacion: un horario pueden tener
        //muchas clases, y una clase puede tener muchos horarios
    }
}