using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Kalum2020v1.DataContext;
using Kalum2020v1.Models;

namespace Kalum2020v1.ModelsViews
{
    public class SalonViewModel : INotifyPropertyChanged, ICommand
    {
        private KalumDbContext dbContext;
     
        private SalonViewModel _Instancia;

        public SalonViewModel Instancia
        {
            get
            {
                return this._Instancia;
            }
            set
            {
                this._Instancia = value;
                NotificarCambio("Instancia");
            }
        }
        private Salon _ElementoSeleccionado;

        public Salon ElementoSeleccionado
        {
            get
            {
                return this._ElementoSeleccionado;
            }
            set
            {
                this._ElementoSeleccionado = value;
                NotificarCambio("ElementoSeleccionado");                
            }
        }
        private ObservableCollection<Salon> _ListaSalon;

        public ObservableCollection<Salon> ListaSalon
        {
            get
            {
                if(_ListaSalon == null){
                    _ListaSalon = new ObservableCollection<Salon>(dbContext.Salones.ToList()); // select * from Alumnos
                }
                return _ListaSalon;

            }
            set
            {
                _ListaSalon = value;
            }
        }

        public SalonViewModel()
        {
            this.dbContext = new KalumDbContext();
            this.Instancia = this;
        }
        public event EventHandler CanExecuteChanged;
        public event PropertyChangedEventHandler PropertyChanged;

        public bool CanExecute(object parameter)//CUIDADO SI NO ABRE ESTA LA VENTANA ES PORQUE AQUI NO SE LE PUSO TRUE
        {
            return true;
        }

        public void Execute(object parametro)//aqui hay un problema se copio codigo del profe para que jalara
        //porque con el codigo copidado del video "3era parte", no jalaba
        {
              if(parametro.Equals("Nuevo"))
              {
                  this.ElementoSeleccionado = new Salon();
              } else if( parametro.Equals("Guardar")) {
                  try
                  { 
                      //Religion r =  this.dbContext.Religiones.Find(1); // Select * from Religiones where ReligionId = 1                      
                      //this.ElementoSeleccionado.Religion = r;                      
                      this.dbContext.Salones.Add(this.ElementoSeleccionado); // insert into Alumno values(...)
                      this.dbContext.SaveChanges();
                      
                      this.ListaSalon.Add(this.ElementoSeleccionado);                                            
                      MessageBox.Show("Datos almacenados!!!");
                  }catch(Exception e)
                  {
                      MessageBox.Show(e.Message);
                  }
              }          
        }

        public void NotificarCambio(String propiedad)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }

        }
    }
}