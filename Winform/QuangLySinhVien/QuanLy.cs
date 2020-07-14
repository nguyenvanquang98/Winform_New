using QuangLySinhVien.Model;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System.Data;

namespace QuangLySinhVien
{
    public partial class QuanLy : Form
    {
        private List<Class> listClass;
        public QuanLy()
        {
       
            listClass = new List<Class>();

            listADD();

            InitializeComponent();
        }
        private void listADD()
        {
            List<Student> listSt = new List<Student>
            {
                new Student("4", "D", "Nam"),
                new Student("2", "E", "Nu"),
                new Student("3", "F", "Nam")
            };

            List<Student> listSt1 = new List<Student>
            {
                new Student("2", "D", "Nam"),
                new Student("3", "E", "Nu"),
                new Student("4", "F", "Nam")
            };

            List<Student> listSt2 = new List<Student>
            {
                new Student("2", "D", "Nam"),
                new Student("51", "E", "Nu"),
                new Student("65", "F", "Nam")
            };

            List<Student> listSt3 = new List<Student>
            {
                new Student("42", "D", "Nam"),
                new Student("53", "E", "Nu"),
                new Student("64", "F", "Nam")
            };

            listClass.Add(new Class("Toan", "ToanA1", listSt));
            listClass.Add(new Class("Ly", "Ly học", listSt1));
            listClass.Add(new Class("Hoa", "Hoa học", listSt2));
            listClass.Add(new Class("Sinh", "Sinh Hoc", listSt3));

        }

        public void hienThiCombobbox()
        {
            foreach (Class classA in listClass)
            {
                _ = comboBox1.Items.Add(classA.GetNameClass);
            }
        }

        internal void ChangeStudentInformation(string mssv, string name, string gender)
        {
            string err1 = "";
            string err2 = "";
            string err3 = "";
            string err4 = "";
            if (mssv == "")
            {
                err1 = "Bạn điền thiếu mã sinh viên";
                MessageBox.Show(err1);
            }
            else if (name == "")
            {
                err2 = "Bạn điền thiếu thông tin tên sinh viên";
                MessageBox.Show(err2);
            }
            else if (gender == "")
            {
                err3 = "Bạn vui lòng chọn giới tính";
                MessageBox.Show(err3);
            }
            else
            {
                string className = comboBox1.SelectedItem.ToString();
                int count = 0;
                foreach (Class listB in listClass)
                {
                    if (listB.GetNameClass.Equals(className))
                    {
                        foreach (Student ls_student in listB.getListStudent)
                        {
                            if (ls_student.GetMssv.Equals(mssv))
                            {
                                ls_student.GetMssv = mssv;
                                ls_student.GetName = name;
                                ls_student.getGender = gender;
                            }
                            else
                            {
                                count++;
                            }
                        }
                    }
                }
            }
        }

        DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
        {
            HeaderText = "Delete",
            Name = "buttonDelet",
            Text = "Xóa",
            UseColumnTextForButtonValue = true
        };

        DataGridViewButtonColumn btnFix = new DataGridViewButtonColumn
        {
            HeaderText = "Fix",
            Name = "buttonFix",
            Text = "Fix",
            UseColumnTextForButtonValue = true,

        };

        public void hienthiList()
        {
            gv_student.Rows.Clear();
            string className = comboBox1.SelectedItem.ToString();
            if (gv_student.Columns["buttonDelet"] == null)
            {
                gv_student.Columns.Insert(3, btnDelete);
            }
            if (gv_student.Columns["buttonFix"] == null)
            {
                gv_student.Columns.Insert(4, btnFix);
            }

            foreach (Class listB in listClass)
            {
                if (listB.GetNameClass.Equals(className))
                {
                    foreach (Student ls_student in listB.getListStudent)
                    {
                        _ = gv_student.Rows.Add(ls_student.GetMssv, ls_student.GetName, ls_student.getGender);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hienThiCombobbox();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                /*string name = cb.SelectedItem.ToString();*/
                hienthiList();
            }
            else
            {
                _ = MessageBox.Show("Không chọn combobox nào");
            }
        }

        private void gv_student_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                Fix fix = new Fix(gv_student.Rows[e.RowIndex], this);
                fix.Show();
            }

            if (e.ColumnIndex == 3)
            {
                string mssv1 = Convert.ToString(gv_student.Rows[e.RowIndex].Cells[0].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete student " + mssv1, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    deleteStudent(mssv1);
                    hienthiList();
                }
            }
        }
        public void deleteStudent(string mssv)
        {
            string className = comboBox1.SelectedItem.ToString();
            int count = 0;
            foreach (Class listB in listClass)
            {
                if (listB.GetNameClass.Equals(className))
                {
                    foreach (Student ls_student in listB.getListStudent)
                    {
                        if (ls_student.GetMssv.Equals(mssv))
                        {
                            listB.getListStudent.Remove(ls_student);
                            hienthiList();
                            break;
                        }
                        else
                        {
                            count++;
                        }
                    }
                }
            }
        }
 
        private void btn_add_Click(object sender, EventArgs e)
        {

            AddStudent addStudent = new AddStudent(listClass,this);
            addStudent.Show();
            
        }
    }
}
