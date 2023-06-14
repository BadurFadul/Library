using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src.Library
{
    public class Person
    {
        private int _id;

        public string Name {get; set;} = String.Empty;
        public int Id {get {return _id;}}

        public Person(int id, string name)
        {
            Name = name;
            _id = id;
        }

    }
}