using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace MVVMXamarin.Models
{
    public class Notas : INotifyPropertyChanged
    {
        private string idNotas;
        private double valor;
        private string materia;
        private string idUsuario;
        private int semetre;
        //Eventos
        public event PropertyChangedEventHandler PropertyChanged;

        //Metodos
        public string IdNotas
        {
            get { return idNotas; }
            set
            {
                idNotas = value;
                OnPropertyChanged();
            }
        }

        public double Valor
        {
            get { return valor; }
            set
            {
                valor = value;
                OnPropertyChanged();
            }
        }

        public string Materia
        {
            get { return materia; }
            set
            {
                materia = value;
                OnPropertyChanged();
            }
        }

        public string IdUsuario
        {
            get { return idUsuario; }
            set
            {
                idUsuario = value;
                OnPropertyChanged();
            }
        }

        public int Semestre
        {
            get { return semetre; }
            set
            {
                semetre = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName]string nombre = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
