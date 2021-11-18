using MclWcfTest_Form.SRTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MclWcfTest_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var uc = new UserCredentialsDto
            {
                Username = textBox1.Text,
                Password = textBox2.Text
            };
            var srTest = new Service1Client();
            var result = srTest.Login(uc);

            
        }
    }
}
