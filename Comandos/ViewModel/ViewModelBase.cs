using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.ComponentModel;

namespace Comandos.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {
        private string texto;
        public Comandos.ComandoSimple ComandoSencillo { get; set; }
        public Comandos.ComandoConParametros ComandoParametro { get; set; }

        public string Texto
        {
            get { return texto; }
            set
            {
                texto = value;
                OnPropertyChanged("Texto");
            }
        }

        public ViewModelBase()
        {
            ComandoSencillo = new Comandos.ComandoSimple(this);
            ComandoParametro = new Comandos.ComandoConParametros(this);
        }

        public void MostrarMensaje()
        {
            MessageBox.Show("Este es un mensaje sencillo");
        }

        public void MostrarTexto(string textoRecibido)
        {
            Texto = textoRecibido;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string nombrePropiedad)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(nombrePropiedad));
            }
        }
    }
}
