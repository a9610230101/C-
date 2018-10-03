using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    //Project : 溫度轉換器
    //Author : 林紘毅 (a107222011)
    //Date : 2018.09.26
    public partial class Author11 : Form
    {
        public Author11()
        {
            InitializeComponent();
        }

        private void Author11_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
         
            label5.Text = (int.Parse(textBox1.Text) * 9 / 5.0 + 32).ToString();
        

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        
        
             
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

 
        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;

            label5.Text = ((int.Parse(textBox1.Text) + 40) / 1.8 -40 ).ToString();
        }
    }
}
