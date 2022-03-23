using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Person : IPrototype<Person>
    {
        public int Age;
        public DateTime BirthDate;
        public string Name;
        public IdInfo IdInfo;
        public Person? clone()
        {
            return this.MemberwiseClone() as Person;
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = String.Copy(Name);
            return clone;
        }
    }
}
