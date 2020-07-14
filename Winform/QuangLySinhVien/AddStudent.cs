using QuangLySinhVien.Model;
using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace QuangLySinhVien
{
    public partial class AddStudent : Form
    {
        public QuanLy quanLy;
        public List<Class> _listClass;
        public AddStudent(List<Class> listClass,QuanLy quanLy)
        {
            InitializeComponent();
            this.quanLy = quanLy;
            _listClass = listClass;
  
        }
        public bool validateStudent()
        {
            
            if (string.IsNullOrEmpty(txt_name.Text) || string.IsNullOrWhiteSpace(txt_name.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(txt_mssv.Text) || string.IsNullOrWhiteSpace(txt_mssv.Text))
            {
                return false;
            }
            else if (!radioMale.Checked && !radio_female.Checked)
            {
                return false;
            }
            return true;
        }
        public void hienThiCombobbox()
        { 
            foreach (Class classA in _listClass)
            {
                _ = cb_add_class.Items.Add(classA.GetNameClass);
            }
        }
        private void AddStudent_Load(object sender, EventArgs e)
        {
            hienThiCombobbox();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_comfim_Click(object sender, EventArgs e)
        {
            
            if (cb_add_class.SelectedIndex > -1)
            {
                string selectNameClass = cb_add_class.SelectedItem.ToString();
                if (validateStudent())
                {
                    String gender = "";
                    if (radioMale.Checked)
                    {
                        gender = "Nam";
                    }

                    if (radio_female.Checked)
                    {
                        gender = "Nu";

                    }
                    string mssv = txt_mssv.Text.Trim();
                    string name = txt_name.Text.Trim();
                    AddStudent1(selectNameClass, mssv, name, gender);
                   /* MessageBox.Show("Change Student Information Success");*/
                    /*Close();*/
                }
                else
                {
                    MessageBox.Show("Data Input is Invalid");
                }
            }
            else
            {
                MessageBox.Show("Vui long chon lớp");
            }
        }
        public void AddStudent1(string selectNameClass,string mssv, string name, string gender)
        {
            int count = 0;
                foreach (Class listC in _listClass)
                {
                    if (listC.GetNameClass.Equals(selectNameClass))
                    {
                        if (check_student(listC.getListStudent, mssv) != true)
                        {
                            listC.getListStudent.Add(new Student(mssv, name, gender));
                            Close();
                    }
                    else
                    {
                        MessageBox.Show("Sinh vien da ton tai");
                    }
                    
               }
               
            }
        }
    
        public bool check_student(List<Student> list, string mssv)
        {
            foreach (Student listS in list)
            {
                if (listS.GetMssv.Equals(mssv))
                {
                    return true;
                }
            }
            return false;
        }



        private void cb_add_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                /*string name = cb.SelectedItem.ToString();*/
              /*  validateStudent();*/
            }
            else
            {
                _ = MessageBox.Show("Không chọn combobox nào");
            }
        }
    }
}
