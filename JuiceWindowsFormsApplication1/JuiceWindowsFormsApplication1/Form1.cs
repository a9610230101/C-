using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuiceWindowsFormsApplication1
{


    //Project : 進階菜單
    //Author : 林紘毅 A107222011
    //Date : 2018.10.03


    public partial class Form1 : Form
    {
        public int fruitQ;
        public int juiceType;
        public double total;

        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            bananaCheckbox.Checked = false;
            appleCheckBox.Checked = false;
            kiwiCheckBox.Checked = false;
            pineappleCheckBox.Checked = false;
            mangoCheckBox.Checked = false;
            mix2.Checked = false;
            mix3.Checked = false;
            mix4.Checked = false;
            isMember.Checked = false;
            isNotMember.Checked = false;
            Q.Value = 0;
            fruitQ = 0;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            fruitQ = 0;

            if (bananaCheckbox.Checked == true)
            {
                fruitQ += 1;
            }
            if (appleCheckBox.Checked == true)
            {
                fruitQ += 1;
            }
            if (kiwiCheckBox.Checked == true)
            {
                fruitQ += 1;
            }
            if (pineappleCheckBox.Checked == true)
            {
                fruitQ += 1;
            }
            if (mangoCheckBox.Checked == true)
            {
                fruitQ += 1;
            }

            if (mix2.Checked == true)
            {
                juiceType = 2;
            }
            else if (mix3.Checked == true)
            {
                juiceType = 3;
            }
            else if (mix4.Checked == true)
            {
                juiceType = 4;
            }


            if (fruitQ != juiceType)
            {
                MessageBox.Show("水果數量選擇錯誤，請重新選擇!!");
            }
            else
            {
                if (mix2.Checked == true)
                {
                    total = 25 * Convert.ToDouble(Q.Value);
                }
                else if (mix3.Checked == true)
                {
                    total = 30 * Convert.ToDouble(Q.Value);
                }
                else if (mix4.Checked == true)
                {
                    total = 40 * Convert.ToDouble(Q.Value);
                }

                if (isMember.Checked == true)
                {
                    total *= 0.9;
                    total = Math.Round(total, MidpointRounding.AwayFromZero);
                    MessageBox.Show("金額總共為:" + total.ToString() + "元");
                }
                else
                {
                    MessageBox.Show("金額總共為:" + total.ToString() + "元");
                }
            }
        }

        private void Q_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}