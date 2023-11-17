using System;
using System.Collections.Generic;
using System.Text;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel
    {
        private PersonRepository personRepo = new PersonRepository();
        public List<PersonViewModel> PersonsVM { get; set; }

        public MainViewModel()
        {
            PersonsVM = new List<PersonViewModel>();
            foreach (Person person in personRepo.GetAll())
            {
                PersonViewModel PVM = new PersonViewModel(person);
                PersonsVM.Add(PVM);
            }
        }

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

    }
}
