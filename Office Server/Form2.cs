using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace Office_Server
{
    public partial class Form2 : Form
    {
        string conString;
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conString = "Data Source=ora11g;User Id=16BCS071;Password=16BCS071";
            conn = new OracleConnection(conString);
            conn.Open();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into student(student_id,name,degree,gender,department,dob,address) values('"+student_id.Text+"','"+name.Text+"','"+degree.Text+"','"+gender.Text+"',"+dept_id.Text+",'"+dob.Text+"','"+ address.Text+"')";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Insert Succesful");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            this.Hide();
            f4.ShowDialog();
            this.Close();
        }
    }
};
