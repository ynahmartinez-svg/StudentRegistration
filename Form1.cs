using System.Collections;

namespace StudentRegistration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnreg_Click(object sender, EventArgs e)
        {
            for (int day = 1; day <= 31; day++)
            {
                cbDay.Items.Add(day);
            }

            string[] months = { "Janaury", "February", "March",
            "April", "May", "June", "July", "August", "September",
            "October", "November", "December"};
            foreach (string month in months)
            {
                cbMonth.Items.Add(month);
            }

            for (int year = 1990; year <= 2026; year++)
            {
                cbYear.Items.Add(year);
            }

            ArrayList programs = new ArrayList();
            programs.Add("BS Computer Science");
            programs.Add("BS Information Technology");
            programs.Add("BS Information Systems");
            programs.Add("BS Computer Engineering");
            foreach (string program in programs)
            {
                cbProgram.Items.Add(program);
            }

            string lastn = txtlastname.Text;
            string firstn = txtfirstname.Text;
            string middlen = txtmiddlename.Text;

            string gender = " ";
            if (rbMale.Checked)
            {
                gender = "Male";
            }
            else if (rbFemale.Checked)
            {
                gender = "Female";
            }

            string Day = cbDay.Text;
            string Month = cbMonth.Text;
            string Year = cbYear.Text;
            string Program = cbProgram.Text;

            string Student = "Student name: " + firstn + " " + middlen + " " + lastn;
            string Gender = "Gender: " + gender;
            string Birth = "Date of birth: " + Day + " / " + Month + " / " + Year;
            string Programs = "Program: " + Program;
            string infos = Student + "\n" + Gender + "\n" + Birth + "\n" + Programs;
            MessageBox.Show(infos);

        }

        private void lblStudentRegform_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
           
           
