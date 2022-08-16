using System;
using System.Collections.Generic;
using System.Text;

namespace project
{
    public interface IMainOperation<T> 
    {

        void add(T item);
        void search(T item);
        void delete(T item);
       
    }
}
