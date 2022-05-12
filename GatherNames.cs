using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_GUI
{
    public class GatherNames : INotifyPropertyChanged
    {
        private string nombre, apellido, nombreCompleto;

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre {
            get {return nombre;}  
            set {nombre = value; OnPropertyChanged("NombreCompleto"); } 
            }
        public string Apellido { 
            get {return apellido;} 
            set { apellido = value; OnPropertyChanged("NombreCompleto"); } 
            }
        public string NombreCompleto { get
            {
                nombreCompleto = Nombre + " " + Apellido;
                return nombreCompleto;
            }
            set { nombreCompleto = value; }
        }
    }
}
