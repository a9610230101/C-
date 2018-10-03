using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//objective:點餐系統
//author:林紘毅
//date:2018.09.26

namespace menuWindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void oder_Click(object sender, EventArgs e)
        {
            //
            result.Text = "";
            if (isMember.Checked == true)
            {
                double total = Math.Round((Convert.ToDouble(redteaQ.Value) * 20 + Convert.ToDouble(greenteaQ.Value * 20) + Convert.ToDouble(milkteaQ.Value) * 25 )* 0.9, MidpointRounding.AwayFromZero);
                result.Text += "您點的餐點為:\n紅茶(20元) :  " + redteaQ.Value + "份\n綠茶(20元) :  " + greenteaQ.Value + "份\n奶茶(25元) :  " + milkteaQ.Value + "份\n\n共 " + total + "元 (9折)";
            }
            else if (isNotMember.Checked == true)
            {
                int total = Convert.ToInt32(redteaQ.Value) * 20 + Convert.ToInt32(greenteaQ.Value * 20) + Convert.ToInt32(milkteaQ.Value) * 25;
                result.Text += "您點的餐點為:\n紅茶(20元) :  " + redteaQ.Value + "份\n綠茶(20元) :  " + greenteaQ.Value + "份\n奶茶(25元) :  " + milkteaQ.Value + "份\n\n共 " + (redteaQ.Value * 20 + greenteaQ.Value * 20 + milkteaQ.Value * 25) + "元";
            }
            else {
                result.Text = "請問您是否為會員?";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void isMember_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
