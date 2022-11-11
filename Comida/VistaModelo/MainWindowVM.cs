using Comida.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida.VistaModelo
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> personas;

        public ObservableCollection<Plato> Personas
        {
            get { return personas; }
            set
            {
                personas = value;
                this.NotifyPropertyChanged("Personas");
            }
        }

        private Plato platoSeleccionado;

        public Plato PersonaSeleccionada
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                this.NotifyPropertyChanged("PersonaSeleccionada");
            }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
