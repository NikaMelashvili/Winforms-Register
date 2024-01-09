using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaluriMelashvili.Data
{
    internal class Employees
    {
        private int _employeeID;
        private string _firstName;
        private string _lastName;
        private int _age;
        private int _salary;

        public void setId(int employeeID)
        {
            _employeeID = employeeID;
        }
        public void setFirstName(string firstName)
        {
            _firstName = firstName;
        }
        public void setLastName(string lastName)
        {
            _lastName = lastName;
        }
        public void setAge(int age)
        {
            _age = age;
        }
        public void setSalary(int salary)
        {
            _salary = salary;
        }
        public int getEmployeeID()
        {
            return _employeeID;
        }
        public string getFirstName()
        {
            return _firstName;
        }
        public string getLastName()
        {
            return _lastName;
        }
        public int getAge()
        {
            return _age;
        }
        public int getSalary()
        {
            return _salary;
        }
    }
}
