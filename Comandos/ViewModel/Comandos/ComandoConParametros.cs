using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Comandos.ViewModel.Comandos
{
   public  class ComandoConParametros : ICommand
    {
       public ViewModelBase vistaModel { get; set; }
       public string TextoRecibido { get; set; }

       public ComandoConParametros(ViewModelBase miVistaModelo)
       {
           vistaModel = miVistaModelo;
       }

       public bool CanExecute(object parameter)
       {
           if (parameter == null)
               return false;
           else
           {
               if(string.IsNullOrEmpty(parameter.ToString()))
                   return false;

               TextoRecibido = parameter.ToString();
               return true;
           }
       }

       public event EventHandler CanExecuteChanged;

       public void Execute(object parameter)
       {
           vistaModel.MostrarTexto(TextoRecibido);
       }
    }
}
