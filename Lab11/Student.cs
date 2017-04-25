using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Student: Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            get
            {
                return program;
            }

            set
            {
                program = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        public double Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+", "+year+", $"+fee+".";
        }

        public Student(string name, string address, string program, int year, double fee)
        {
            Name = name;
            Address = address;
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        public Student()
        {

        }
    }
}
