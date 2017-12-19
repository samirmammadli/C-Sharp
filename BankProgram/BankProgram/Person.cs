using System;

namespace BankProgram
{
    [Serializable]
    abstract class Person
    {
        protected Person()
        {
            Name = "";
            Surname = "";
            Mail = "";
            Phone = "";
            Age = 0;
        }
        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
    }
}