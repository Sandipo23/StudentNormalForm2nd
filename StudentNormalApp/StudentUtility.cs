using System;
using System.Collections.Generic;
using System.Text;

namespace StudentNormalApp
{
    internal static class StudentUtility
    {
        public static List<StudentRead> ConvertToStudentRead(List<Student> students)
        {
            var studentReads = new List<StudentRead>(); 
            foreach (Student student in students)
            {
                studentReads.Add(new StudentRead
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Gender = student.Gender ? "Male" : "Female",
                    Agree = student.Agree ? "Yes" : "No",
                    Course = student.Course,
                    DOB = student.DOB.FormatDate(),  // using the extension method to format the date.
                                                     // DOB is a DateTime object, so we can use the extension method to format it.
                                                     // DateUtility.FormatDate(student.DOB) can also be used to format the date.
                                                     // But we have to pass the date as a parameter to the method.
                                                     // So, we can use the extension method to format the date.
                    Profile = Path.GetFileName(student.Profile)
                });
            }

            return studentReads;
        }

    }
}

