using Haley.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfHaley_MVVM.Models;

namespace WpfHaley_MVVM.ViewModels
{
    public class MainViewModel : ChangeNotifier
    {
        private PersonModel _personModel;
        public PersonModel PersonModel
        {
            get { return _personModel; }
            set
            {
                _personModel = value;
                OnPropertyChanged(nameof(PersonModel));
            }
        }

        private ObservableCollection<PersonModel> _observablePersons;
        public ObservableCollection<PersonModel> ObservablePersons
        {
            get { return _observablePersons; }
            set
            {
                _observablePersons = value;

            }
        }

        public void AddPerson()
        {
            ObservablePersons.Add(PersonModel);
            PersonModel = new PersonModel();
        }

        public ICommand AddCommand => new DelegateCommand(AddPerson);

        public MainViewModel()
        {
            //AddCommand = new AddCommand();
            ObservablePersons = new ObservableCollection<PersonModel>();
            PersonModel = new PersonModel();
        }
    }
}
