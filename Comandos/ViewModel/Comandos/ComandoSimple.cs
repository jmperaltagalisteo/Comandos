using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Comandos.ViewModel.Comandos
{
    class ComandoSimple  : ICommand
    {
        public ViewModelBase vistaModel { get; set; }

        public ComandoSimple(ViewModelBase miVistaModelo)
        {
            vistaModel = miVistaModelo;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            vistaModel.MostrarMensaje();
        }
    }
}
