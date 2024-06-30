﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_To_Object_And_Query_Operators
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //Foereign Key

        public int UniversityId { get; set; } 

        //Method

        public void ShowInfo() 
        {
            Console.WriteLine("Student {0} with id, Gender {2} and Age{3} from university with the Id {4}",
                Name,Id,Gender,Age,UniversityId);
        }

    }
}
