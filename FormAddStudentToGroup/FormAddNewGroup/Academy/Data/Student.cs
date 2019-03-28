using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P208_Academy.Data
{
    public class Student
    {
        public string StudentID { get; set; } // Studente verilen ID nomre
        public string Firstname { get; set; } // Studentin adi
        public string Lastname { get; set; }  // Studentin soyadi
        public string Email { get; set; }   // Student Email-i
        public Group Group { get; set; } // Group tipinden Studentin olduqu qrup adi ve ID-si
        private static int StudentIDCounter { get; set; } = 1; // Studentin sayinin hesablanmasi deyisheni

        public Student() //Konstruktor
        {    // studentin ID-sinin 10 simvolu kecmemek alqoritmi
            StudentID = new string('0', 10 - StudentIDCounter.ToString().Length) + StudentIDCounter++;
        }
    }
}
