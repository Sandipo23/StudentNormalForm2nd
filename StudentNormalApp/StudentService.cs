using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNormalApp
{
    internal class StudentService
    {
        public string[] GetAllCourses()
        {
             string[] courses = { "Select Course", "BCA", "BBA", "B.Tech", "MCA", "MBA" };
             return courses;
        }
    }
}
