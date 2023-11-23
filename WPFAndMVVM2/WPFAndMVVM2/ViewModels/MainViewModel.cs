using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonRepository personRepo = new PersonRepository();

        public ObservableCollection<PersonViewModel> PersonsVM { get; set; }

        public MainViewModel()
        {
            PersonsVM = new ObservableCollection<PersonViewModel>();
            foreach (Person person in personRepo.GetAll())
            {
                PersonViewModel PVM = new PersonViewModel(person);
                PersonsVM.Add(PVM);
            }
        }
        private PersonViewModel selectedPerson;

        public PersonViewModel SelectedPerson
        {
            get { return selectedPerson; }
            set { selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }

        public void AddDefaultPerson()
        {
            Person person = personRepo.Add("Specify FirstName", "Specify Lastname", 0, "Specify Phone");
            PersonViewModel PVM1 = new PersonViewModel(person);
            PersonsVM.Add(PVM1);
            SelectedPerson = PVM1;
        }

        public void DeleteSelectedPerson()
        {
            selectedPerson.DeletePerson(personRepo);
            PersonsVM.Remove(SelectedPerson);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)

        {

            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;

            if (propertyChanged != null)

            {

                propertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }

        }
        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

    }
}
