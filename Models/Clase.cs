using System;
using System.Collections.Generic;
namespace Kalum2020v1.Models
{
    public class Clase
    {
        public int ClaseId{get;set;}
        public string Descripcion{get;set;}
        public int Ciclo{get;set;}
        public int CarreraTecnicaId{get;set;}//llave foranea
        public int SalonId{get;set;}//llave foranea
        public int HorarioId{get;set;}//llave foranea
        public int InstructorId{get;set;}
        public int CupoMinimo{get;set;}
        public int CupoMaximo{get;set;}
        public int CantidadAsignaciones{get;set;}
        public virtual CarreraTecnica CarreraTecnica{get;set;}//esto se coloca cuando hay una relacion de uno a muchos
        //Coomo una carrera tecnia tiene muchas clases 
        public virtual Salon Salon{get;set;}
        public virtual Horario Horario{get;set;}
        public virtual Instructor Instructor{get;set;}
        public virtual List<AsignacionAlumno> AsignacionAlumnos{get;set;}//se coloca asi porque
        //una clase tiene muchas asigancioAlumno
    }
}