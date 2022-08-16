using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    
    public class student : Person
    {
        private int grade;
        private float gpa;
        private string email;

        public int Grade { get; set; }
        public float Gpa { get; set; }
        public string Email { get; set; }
        private Department department;
        public Department Department { get; set; }       
        public student() : base(){}
       public override string ToString()
        {
            return  $"{base.ToString()}  Grade {Grade}" +
                $"GPA :{Gpa}" +
                $" E-mai :{Email}" +
                $" Department : {Department} ]";
        }
        public static bool operator ==(student s1, student s2)
        {
            return s1.Name == s2.Name && s1.Age == s2.Age;
        }
        public static bool operator !=(student s1, student s2)
        {
            return s1.Name == s2.Name && s1.Age == s2.Age;
        }
    }
}
