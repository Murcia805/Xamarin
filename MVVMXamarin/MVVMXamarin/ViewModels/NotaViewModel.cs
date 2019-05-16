using MVVMXamarin.Models;
using MVVMXamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace MVVMXamarin.ViewModels
{
    public class NotaViewModel : Notas
    {
        //Atributos
        private ObservableCollection<Notas> notas;
        NotasService servicio = new NotasService();
        Notas nota;

        //Constructor
        public NotaViewModel()
        {
            notas = servicio.Consultar();
        }

        //Metodos

        public ObservableCollection<Notas> Notas
        {
            get { return notas; }
            set
            {
                notas = value;
                OnPropertyChanged("Notas");
            }
        }


    }
}
