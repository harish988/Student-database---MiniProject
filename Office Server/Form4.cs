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
    public partial class Form4 : Form
    {
        string conString;
        OracleConnection conn;
        public Form4()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conString = "Data Source=ora11g;User Id=16BCS071;Password=16BCS071";
            conn = new OracleConnection(conString);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete co_cirricular where student_id='" + textBox1.Text + "'";
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete extra_cirricular where student_id = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete grade where student_id = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "delete student where student_id = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delete Succesful");
        }

        private void button4_Click(object sender, EventArgs e)
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
    }
};
