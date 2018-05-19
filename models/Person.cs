using System;

namespace lab2.models
{
    public class Person
    {
        private String name;
        private String surname;
        private DateTime birth;


        public string Name => name;

        public string Surname => surname;

        public DateTime Birth1 => birth;

        public Person(string name, string surname, DateTime birth)
        {
            this.name = name;
            this.surname = surname;
            this.birth = birth;
        }

        public Person()
        {
            name = "username";
            surname = "sample text";
            birth = new DateTime();
        }

        public int Birth
        {
            get { return birth.Year; }
            set { birth = new DateTime(value, birth.Month, birth.Day); }
        }


        public override string ToString()
        {
            return"Person{" +name + " " + surname + " " + birth+"} ";
        }

        public virtual string toShortString()
        {
            return name + " " + surname;
        }
    }
}