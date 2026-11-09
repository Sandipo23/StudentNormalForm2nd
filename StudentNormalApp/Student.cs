using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNormalApp
{
    internal class Student // this is a model class which is used to store the data of student
    {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public bool Gender { get; set; }
            public bool Agree { get; set; }
            public string Course { get; set; }
            public string Profile { get; set; }
        
    }
}
