using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AddAClass
{
    internal class Employee
    {
        //field tanımlama
        private string _firstName;
        private string _lastName;
        private List<Employee> _list;

        //property tanımlama
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

        //Expression bodied property Accessors
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        //Auto-implemented Properties
        public int Age { get; set; }

        public List<Employee> Employees => _list;

        //Constructor
        public Employee()
        {
            _list = new List<Employee>();
        }

        //Constructor Overloading
        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _list = new List<Employee>();
        }

        //Override
        public override string? ToString()
        {
            return $"{FirstName,-20} {LastName,-15} {Age,5}";
        }

        //Metot tanımlama
        public void Add(Employee employee)
        {
            _list.Add(employee);
        }

        //params keyword
        public void AddRange(params Employee[] employees)
        {
            _list.AddRange(employees);
        }

        //Expression-bodied Method
        public List<Employee> GetEmployees()
        {
            return _list;
        }
    }
}
