using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DragAndDrop.Model
{
    class Person : ObservableObject, ICloneable
    {
        
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { Set(ref _name, value); }
        }


        private int _age;
        public int Age
        {
            get { return _age; }
            set { Set(ref _age, value); }
        }

        public override string ToString()
        {
            return $"{Name}  {Age}";
        }

        public object Clone()
        {
            return new Person(this.Name, this.Age) as object;
        }
    }
}
