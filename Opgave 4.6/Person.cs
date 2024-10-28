using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_4._6
{
    public class Person
    {
            private int _age;
            private string _name;
            private double _weight;

        public Person(int age, double weight, string name)
        {
            _age = age;
            _weight = weight;
            _name = name;
        }

        public int Age { get { return _age; } set { _age = value; }}    
        public string Name { get { return _name; } set { _name = value; }}  
        public double Weight { get { return _weight; } set { _weight = value; }}


        public override string ToString()
        {
            return $"{Name}, Age: {Age}, Weight: {Weight}";
        }

    }
}
