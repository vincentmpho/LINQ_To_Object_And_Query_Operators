using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_To_Object_And_Query_Operators
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Method
        public void ShowInfo () 
        {

            Console.WriteLine("university {0} with id {1}", Name,Id);
        }
    }
}
