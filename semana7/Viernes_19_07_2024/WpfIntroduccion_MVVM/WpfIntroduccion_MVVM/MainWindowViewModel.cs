using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfIntroduccion_MVVM
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        //Atributos
        private string _firstName;
        private string _lastName;
        private string _fullName;

        //Propiedades
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
                ActualizarFullNamesDesdeNames();
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
                ActualizarFullNamesDesdeNames();
            }
        }

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
                ActualizarNamesDesdeFullNames();
            }
        }

        //Constructor
        public MainWindowViewModel()
        {
            UpdateCommand = new RelayCommand(Update, CanUpdate);
            _firstName = string.Empty;
            _lastName = "";
            ActualizarFullNamesDesdeNames();
        }

        //Metodos
        private void ActualizarFullNamesDesdeNames()
        {
            _fullName = $"{_firstName} {_lastName}";
            OnPropertyChanged(nameof(FullName));
        }

        private void ActualizarNamesDesdeFullNames()
        {
            var names = _fullName.Split(new[] { ' ' }, 2);
            if(names.Length >= 2)
            {
                FirstName = names[0];
                LastName = names[1];
            }
            else
            {
                FirstName = _fullName;
                LastName = string.Empty;
            }
        }

        //ICommand
        public ICommand UpdateCommand { get; }

        public void Update()
        {
            FirstName = "Gabriel";
            LastName = "Retamozo";
        }

        public bool CanUpdate()
        {
            return !string.IsNullOrWhiteSpace(FirstName) && !string.IsNullOrWhiteSpace(LastName);
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
