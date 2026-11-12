using Newtonsoft.Json;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace StudentNormalApp
{
    internal class StudentService
    {
        // Fields
        private int _id;

        // Constant
        public const string _fee = "3,50,000";

        // Readonly
        public readonly string _folderLocation;
        private readonly string path;

        //public StudentService()
        //{
        //    _folderLocation = "";
        //}
        public StudentService()
        {
            _folderLocation = ConfigurationManager.AppSettings["FolderLocation"];
            path = Path.Combine(_folderLocation, "student.json");
        }
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
            string path = Path.Combine(_folderLocation, "student.json");
            File.WriteAllText(path, json);
        }

        public void SaveImage(string source, string destination)
        {
            File.Copy(source, destination);
        }
        public Student Get()
        {
            string path = Path.Combine(_folderLocation, "student.json"); // this line is used to get the path of the student.json file which is present in the folder location.
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                var student = JsonConvert.DeserializeObject<Student>(json); // this line is used to deserialize the json data into Student object.
                return student;
            }

            return null;
        }
    }
}
