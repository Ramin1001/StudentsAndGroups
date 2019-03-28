using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P208_Academy.Data
{
    public static class StudentList // Student siyahisinin birge yerinin yaradilmasi
    {
        //Student tipinde List massivinin yaradilmasi
        public static List<Student> Students { get; private set; } 


        //Konstruktor
        static StudentList() 
        {
            // yeni student yaradildiqda Yeni Student tipinde massiv yaradilsin
            Students = new List<Student>();

            // Yalniz test meqsedi ile yazilib
            // studentlerin melumatin Database-de olur
            Students.Add(new Student
            {
                Firstname = "Aqil",
                Lastname = "Atakisiyev",
                Email = "aqil@code.edu.az",
                Group = GroupList.GetGroupById("00001")
            });
            Students.Add(new Student
            {
                Firstname = "Rufet",
                Lastname = "Eliyev",
                Email = "rufetza@code.edu.az",
                Group = GroupList.GetGroupById("00002")
            });
            Students.Add(new Student
            {
                Firstname = "Samir",
                Lastname = "Beydullayev",
                Email = "samirba@code.edu.az",
                Group = GroupList.GetGroupById("00001")
            });
            Students.Add(new Student
            {
                Firstname = "Resul",
                Lastname = "Agarzayev",
                Email = "resul@code.edu.az",
                Group = GroupList.GetGroupById("00002")
            });
            Students.Add(new Student
            {
                Firstname = "Ibrahim",
                Lastname = "Memmedov",
                Email = "ibo@code.edu.az",
                Group = GroupList.GetGroupById("00001")
            });
        }

        // Sonradan yeni Studentin elave edilmesi metodu
        public static void Add(Student student)
        {
            Students.Add(student);
        }


        // email- yazildiqda onun bashqa studentde olubolmadiqinin yoxlanmasi
        public static bool ContainsEmail(string email)
        {
            foreach (var item in Students)
            {
                if (item.Email == email)
                {
                    return true; // eynisi var 
                }
            }
            return false; // bele email yoxdur
        }

        // daxil edilen studentlerin bir masive yiqan metod (Group tipinde bir group veririk)
        public static List<Student> GetStudentsByGroup(Group group)
        {
            // siyahini massive yiqmaq ucun List massivi yaradiriq
            List<Student> studentsInGroup = new List<Student>();

            // student masivini siralayiriq
            foreach (var student in Students)
            {
                // eger student Group-sun ID-si parametrde verilen group ile eynidirse
                // yeni hemin ad orda varsa
                if (student.Group == group)
                {
                    // yeni yaradilmish List array-ine elave edilmesi
                    studentsInGroup.Add(student);
                }
            }
            return studentsInGroup; // sonda hemin siyahinin qaytarilmasi
        }
    }
}
