using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class PersonViewModel
    {
        private Person person;
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}
		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}
		private int age;

		public int Age
		{
			get { return age; }
			set { age = value; }
		}
		private string phone;

		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}

		public PersonViewModel(Person person)
		{
			this.person = person;
			this.firstName = person.FirstName;
			this.lastName = person.LastName;
			this.age = person.Age;
			this.phone = person.Phone;
		}
	}
}
