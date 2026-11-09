using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace StudentNormalApp
{
    internal class StudentService
    {
        // Fields
        private int _id;

        // Constant
        public const string _fee = "3,50,000";

        // Readonly
        public readonly string _folderLocation = @"D:\Asp.Net\Project\First_Desktop_Student_Form\files";

        //public StudentService()
        //{
        //    _folderLocation = "";
        //}
        public string[] GetAllCourses()
        {
             string[] courses = { "Select Course", "BCA", "BBA", "B.Tech", "MCA", "MBA" };
             return courses;
        }

        public void Save(Student student)  // this method is used to save the data of student into database or file.
                                           // the Student object is passed as parameter to this method which contains the data of student.
                                           // this method will save the data of student into database or file.
        {
            string json = JsonConvert.SerializeObject(student);
            string path = $@"{_folderLocation}\student.json";
            File.WriteAllText(path, json);
        }
    }
}
