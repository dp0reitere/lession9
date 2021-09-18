﻿using System;

namespace Lekcija3
{
    public class Person
    {
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get;  }
        private int _age;
        public int Age
        
        { 
            get
            {
                return _age;
                
            }
            set
            {
                _age = Math.Abs(value);
            }
         }
        public double Money { get; set; }
        public bool IsMale { get; set; }
        public char Initial { get; set; }

        public string GetGreeting()
        {
            string greeting = "Hello my name is" + Name + "and I am " + Age + "year old";

            return greeting;
        }

    }
}
