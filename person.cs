using System;
using System.Collections.Generic;
using System.Text;
namespace project
{
    public class DataStore<T>
    {
        public T Data { get; set; }
    }
    class Help : IComparer<Person>
    {
        public int Compare(Person s, Person s1)
        {
            if ((s.Name).CompareTo(s1.Name) > 0)
            {
                return 1;
            }
            else if ((s.Name).CompareTo(s1.Name) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
    public interface IComparable<in T>
    {

    }
     public class Person:college , IComparable<Person> 
    { 
        public string name;
        public int age;
        public long number;
        public long id;
        public personType gender;
        public personType Gender{get;set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public long Number { get; set; }
        public long Id { get; set; }
        public Department Department { get; internal set; }
       

        public  virtual string  ToString()
        {
            return $"[ Name: {Name} " +
                $"Age: {Age}" +
                $"phone num.:{Number}" +
                $"ID : {Id}" +
                $"Gender : {Gender}";
        }
        public Person() { }    
        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }

       
    }
}
