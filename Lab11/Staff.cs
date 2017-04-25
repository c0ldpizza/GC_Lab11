using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Staff: Person
    {
        private string school;
        private double pay;

        public string School
        {
            get
            {
                return school;
            }

            set
            {
                school = value;
            }
        }

        public double Pay
        {
            get
            {
                return pay;
            }

            set
            {
                pay = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+", "+school+", $"+pay;
        }

        public Staff(string name, string address, string school, double pay)
        {
            Name = name;
            Address = address;
            this.school = school;
            this.pay = pay;
        }
    }
}
