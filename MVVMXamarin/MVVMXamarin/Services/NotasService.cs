using MVVMXamarin.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;

namespace MVVMXamarin.Services
{
    public class NotasService
    {
        public ObservableCollection<Notas> notas { get; set; }

        public NotasService()
        {
            if (notas == null)
            {
                notas = new ObservableCollection<Notas>();
            }
        }

        //Metodos

        public ObservableCollection<Notas> Consultar()
        {
            return notas;
        }
    }
}
