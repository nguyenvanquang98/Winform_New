using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuangLySinhVien
{
    public class Student
    {
        public Student(string mssv, string name, string gender)
        {
            GetMssv = mssv;
            GetName = name;
            getGender = gender;
        }
        public string GetMssv { get; set; }
        public string GetName { get; set; }

        public string getGender { get; set; }

    }
}
