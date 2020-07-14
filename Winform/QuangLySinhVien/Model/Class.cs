using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuangLySinhVien.Model
{
    public class Class
    {

        public Class(string idClass, string nameClass, List<Student> listStudent)
        {
            getIdClass = idClass;
            GetNameClass = nameClass;
            getListStudent = listStudent;
        }
        public string getIdClass { get; set; }

        public string GetNameClass { get; set; }
        public List<Student> getListStudent { get; set; }
    }
}
