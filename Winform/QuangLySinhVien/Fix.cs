using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuangLySinhVien
{
    public partial class Fix : Form
    {
        private QuanLy quanLy;
        private DataGridViewRow information;

        public Fix(DataGridViewRow information,QuanLy quanLy)
        {

            InitializeComponent();
            this.quanLy = quanLy;
            this.information = information;

            txt_mssv.Text = this.information.Cells["MSSV"].Value.ToString();
            txt_name.Text = this.information.Cells["NAME"].Value.ToString();
            if (this.information.Cells["GENDER"].Value.ToString().Equals("Nam"))
            {
                radioMale.Checked = true;
            }
            else
            {
                radio_female.Checked = true;

            }
        }
        public bool validateStudent()
        {
            if (String.IsNullOrEmpty(txt_name.Text) || String.IsNullOrWhiteSpace(txt_name.Text))
            {
                return false;
            }
            if (!radioMale.Checked && !radio_female.Checked)
            {
                return false;
            }
            return true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_comfim_Click(object sender, EventArgs e)
        {
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
                quanLy.ChangeStudentInformation(mssv, name, gender);
                MessageBox.Show("Change Student Information Success");
                quanLy.hienthiList();
                Close();
            }
            else
            {
                MessageBox.Show("Data Input is Invalid");
            }
        }

        private void radioMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radio_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Fix_Load(object sender, EventArgs e)
        {

        }
    }
}
