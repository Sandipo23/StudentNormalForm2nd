using Newtonsoft.Json;
using StudentNormalApp;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentNormalApp
{
    internal class StudentService
    {
        // Fields
        private int _id;

        // Constant
        public const string _fee = "3,50,000";
        public const string _format = "dd/MM/yyyy";

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

        public string[] GetAllHobbies()
        {
            string[] hobbies = { "Music", "Dance", "Hiking", "Programming", "Swimming" };
            return hobbies;
        }

        public void Save(Student student) // this method is used to save the data of student into database or file.
        {
            //string json = JsonConvert.SerializeObject(student); // this line is used to serialize the Student object into json format.
            var existingStudents = GetExistingStudents(); // this line is used to get all the existing data of student from database or file.
            existingStudents.Add(student); // this line is used to add the new Student object into the list of existing Student object.
            string json = JsonConvert.SerializeObject(existingStudents);
            string path = Path.Combine(_folderLocation, "student.json");
            File.WriteAllText(path, json);
        }

        public void SaveImage(string source, string destination)
        {
            File.Copy(source, destination, true);
        }




        public List<StudentRead> GetAll()  // this method is used to get all the data of student from database or file.
        {
            var studentList = GetExistingStudents();
            if (studentList.Count > 0) // this line is used to check if the list of Student object is not empty.
            {
                var students = StudentUtility.ConvertToStudentRead(studentList); // this line is used to convert
                                                                  // the list of Student object into list of StudentRead object.
                return students;
            }

            return new List<StudentRead>();
        }

        private List<Student> GetExistingStudents() // this method is used to get all the existing data of student from database or file.
        {
            string path = Path.Combine(_folderLocation, "student.json"); // this line is used to get the path of the student.json file which is present in the folder location.
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                var students = JsonConvert.DeserializeObject<List<Student>>(json);
                return students;
            }

            return new List<Student>();  // this line is used to return an empty list of Student object if the student.json file is not present in the folder location.
        }

    }
}
