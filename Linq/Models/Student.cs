using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Linq.Models
{
    public class Students
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Students> GetAllStudents()
        {
            List<Students> listStudents = new List<Students>();

            Students student1 = new Students
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };
            listStudents.Add(student1);

            Students student2 = new Students
            {
                ID = 102,
                Name = "Mary",
                Gender = "Female"
            };
            listStudents.Add(student2);

            Students student3 = new Students
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };
            listStudents.Add(student3);

            Students student4 = new Students
            {
                ID = 104,
                Name = "Steve",
                Gender = "Male"
            };
            listStudents.Add(student4);

            Students student5 = new Students
            {
                ID = 105,
                Name = "Pam",
                Gender = "Female"
            };
            listStudents.Add(student5);

            return listStudents;
        }
    }
}