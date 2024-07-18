using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WPF_INotifyPropertyChanged
{
    public class NombreCompleto :INotifyPropertyChanged
    {
        private string _nombres;
        private string _apellidos;
        private string _nombreCompletoTodo;

        public string Nombres
        {
            get { return _nombres; }
            set
            {
                if(_nombres != value)
                {
                    _nombres = value;
                    OnPropertyChanged("Nombres");
                    OnPropertyChanged("NombreCompletoTodo");
                }
            }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set
            {
                if(_apellidos != value)
                {
                    _apellidos = value;
                    OnPropertyChanged("Apellidos");
                    OnPropertyChanged("NombreCompletoTodo");
                }
            }
        }

        public string NombreCompletoTodo
        {
            get { return $"{Nombres} {Apellidos}"; }
            set
            {
                if(_nombreCompletoTodo != value)
                {
                    _nombreCompletoTodo = value;
                    var partes = _nombreCompletoTodo.Split(' ');
                    if(partes.Length >= 2)
                    {
                        Nombres = partes[0];
                        Apellidos = partes[1];
                    }
                    else
                    {
                        Nombres = _nombreCompletoTodo;
                        Apellidos = string.Empty;
                    }
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
