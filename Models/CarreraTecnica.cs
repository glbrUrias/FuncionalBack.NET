using System.Collections.Generic;
namespace Kalum2020v1.Models
{
    public class CarreraTecnica
    {
        public int CarreraTecnicaId{get;set;}

        public string NombreCarrera{get;set;}
         public virtual List<Clase> Clases{get;set;}//se pone cuando es la relacion: un carrera pueden tener
        //muchas clases, y una clase puede tener muchos carreras
    }
}