using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Person
    {
        private string name;
        private string address;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public override string ToString()
        {
            return name +", "+address;
        }

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
