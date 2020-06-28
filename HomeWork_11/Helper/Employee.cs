using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_11
{
    abstract class Employee
    {
        public virtual string Position { get; private protected set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public long Phone { get; private set; }
        public virtual int Salary { get; private protected set; }

        public Employee(string FirstName, string LastName, long Phone)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
        }
    }
}
