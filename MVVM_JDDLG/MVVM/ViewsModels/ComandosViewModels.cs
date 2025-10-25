using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_JDDLG.MVVM.ViewsModels
{
    internal class ComandosViewModels
    {
        public ICommand ClickCommand { get; }

        public ICommand SearchCommand { get; }

        public string SearchData { get; set; }
        public ComandosViewModels()
        {
            ClickCommand = new Command(() =>
            {
                App.Current.MainPage.DisplayAlert("Title", "Mensaje", "Aceptar");
            }); 
            SearchCommand = new Command((s) =>
            {
                var data = s;
            });

        }

        private void Alert()
        {
            
        }
    }
}
