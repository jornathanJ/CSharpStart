using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class SampleForm1 : Form
    {
        public SampleForm1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("dfsdfsdsfdf");
            MessageBox.Show("개발 도중에 바꾸고 싶어요");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnEdit_Click");
            MessageBox.Show("개발 도중에 바꾸고 싶어요");
        }
        
        private void btnSaveToDB_click(object sender, EventArgs e)
        {
            this.ButtonClickHandle(sender, e);


        }

        private void ButtonClickHandle(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.ToUpper() == "SAVE")
            {
                Console.WriteLine("btnSaveToDB_click");
                MessageBox.Show("개발 도중에 바꾸고 싶어요");
            }
            else
            {

            }
        }

        
    }
}
