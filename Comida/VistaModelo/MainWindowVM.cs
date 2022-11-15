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
        private ObservableCollection<Plato> platos;

        public ObservableCollection<Plato> Platos
        {
            get { return platos; }
            set
            {
                platos = value;
                this.NotifyPropertyChanged("Platos");
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

        public MainWindowVM()
        {
            Platos = Plato.GetSamples("C:/Users/alumno/Documents/Recursos-Platos-UT5-Actividad/Platos");
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
