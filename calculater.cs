using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num;
        char   count;

        private void BtnExet_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtresualt.Text != "")
            {
                num = float.Parse(txtresualt.Text);
                txtstore.Text = txtresualt.Text ;
                guna2Button1.FillColor = Color.DarkOrchid;
                guna2Button1.ForeColor = Color.Black;
                txtresualt.Clear();
                count = 'f';
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
       
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(txtresualt .Text !="")
            {
                num = float.Parse(txtresualt.Text);
                txtstore.Text = txtresualt.Text ;
                guna2Button3.FillColor = Color.DarkOrchid;
                guna2Button3.ForeColor = Color.Black;
                txtresualt.Clear();
                count ='a'  ;
            }
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            txtresualt.Clear();
            txtstore.Clear();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndot_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + ".";
        }

        private void btnzero_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "0";
        }

        private void btnone_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "1";
        }

        private void btntwo_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "2";
        }

       

        private void btnfour_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "4";
        }

        private void btnthree_Click_1(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "3";

        }

        private void btnfive_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "5";
        }

        private void btnsix_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "6";
        }

        private void btnseven_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "7";
        }

        private void btneight_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "8";
        }

        private void btnnine_Click(object sender, EventArgs e)
        {
            txtresualt.Text = txtresualt.Text + "9";
        }

        private void txtstore_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (txtresualt.Text != "")
            {
                num = float.Parse(txtresualt.Text);
                txtstore.Text = txtresualt.Text ;
                guna2Button4.FillColor = Color.DarkOrchid;
                guna2Button4.ForeColor = Color.Black;
                txtresualt.Clear();
                count = 'b';
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtresualt.Text != "")
            {
                num = float.Parse(txtresualt.Text);
                txtstore.Text = txtresualt.Text ;
                guna2Button2.FillColor = Color.DarkOrchid;
                guna2Button2.ForeColor = Color.Black;
                txtresualt.Clear();
                count = 'c';
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (txtresualt.Text != "")
            {
                num = float.Parse(txtresualt.Text);
                txtstore.Text = txtresualt.Text ;
                guna2Button8.FillColor = Color.DarkOrchid;
                guna2Button8.ForeColor = Color.Black;
                txtresualt.Clear();
                count = 'd';
            }
        }
        

        private void btnequal_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtstore.Text);
            double num2 = double.Parse(txtresualt.Text);
            double num3;


            switch (count)
            {
                case 'a' :
                     num3 = clic.Sup(num1, num2);
                    txtstore.Text = num3.ToString ();
                    txtresualt.Clear();
                    guna2Button3.FillColor = Color.Black ;
                    guna2Button3.ForeColor = Color.DarkOrchid;
                    break;
                case 'b':
                    num3 = clic.Add(num1, num2);
                    txtstore.Text = num3.ToString();
                    guna2Button4.FillColor = Color.Black ;
                    guna2Button4.ForeColor = Color.DarkOrchid;
                    txtresualt.Clear();
                    break;
                case 'c':
                    num3 = clic.Multi(num1, num2);
                    txtstore.Text = num3.ToString();
                    txtresualt.Clear();
                    guna2Button2.FillColor = Color.Black;
                    guna2Button2.ForeColor = Color.DarkOrchid;
                    break;
                case 'f':
                    num3 = clic.Div(num1, num2);
                    txtstore.Text = num3.ToString();
                    txtresualt.Clear();
                    guna2Button1.FillColor = Color.Black;
                    guna2Button1.ForeColor = Color.DarkOrchid;
                    break;
                case 'd':
                    num3 = clic.Mod(num1, num2);
                    txtstore.Text = num3.ToString();
                    txtresualt.Clear();
                    guna2Button8.FillColor = Color.Black;
                    guna2Button8.ForeColor = Color.DarkOrchid;
                    break;

                    

            }
            







        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void txtstore_KeyDown(object sender, KeyEventArgs e)
        {
           

        }
    }
}
