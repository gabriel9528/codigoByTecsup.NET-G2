using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Intro_MVVM
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
                UpdateFullNameFromnames();
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
                UpdateFullNameFromnames();
            }
        }

        public string FullName
        {
            get { return _fullName; }
            set
            {
                _fullName = value;
                OnPropertyChanged(nameof(FullName));
                UpdateNamesFromFullNames();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;


        public MainWindowViewModel()
        {
            UpdateCommand = new RelayCommand(Update, CanUpdate);
            _firstName = string.Empty;
            _lastName = string.Empty;
            UpdateFullNameFromnames();
        }

        //ICommand
        public ICommand UpdateCommand { get; }

        private void Update()
        {
            FirstName = "NombrePorDefecto";
            LastName = "ApellidoPorDefecto";
        }

        private bool CanUpdate()
        {
            return !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName);
        }

        private void UpdateFullNameFromnames()
        {
            _fullName = $"{_firstName} {_lastName}";
            OnPropertyChanged(nameof(FullName));
        }

        private void UpdateNamesFromFullNames()
        {
            var names = _fullName.Split(new[] { ' ' }, 2);
            if(names.Length == 2)
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
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
