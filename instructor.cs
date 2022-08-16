using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
   
    class instructor: Person
    {
        private string email;
        private int salary;
        private Department department;
        public Department Department { get; set; }
        public instructor() : base() { }
        public int Salary { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()} Salary : {Salary}" +
                $" E-mai : {Email}" +
                $"  Department : {Department} ]";
        }
        public  void DisplayMale()
        {
            if (lst != null)
            {
                List<instructor> m = new List<instructor>();

                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i] is instructor)
                    {
                        if ((lst[i].Gender) == personType.Male)
                        {
                            m.Add((instructor)lst[i]); // (instructor) ???????????
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("list is empty");
                }

        }
        
    }
}
