using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        private ValuableRepository valueableRepo;

        public ValuableRepository ValueableRepo
        {
            get { return valueableRepo; }
            set { valueableRepo = value; }
        }

        public List<Book> Books;
        public List<Amulet> Amulets;
        public List<Course> Courses;
        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Courses = new List<Course>();
        }
        public void AddToList(Book book)
        {
            Books.Add(book);
        }
        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
        public void AddToList(Course course)
        {
            Courses.Add(course);
        }
        public void AddToList(IValuable valuable)
        {

        }
    }
}
