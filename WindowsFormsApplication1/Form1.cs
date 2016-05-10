using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        bool status = false;
        bool status2 = false;
        Graphics g,gp;
       
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            status2 = false;
            panel1.Refresh();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (status)
            {
                Pen p =new Pen( Color.Black);
                g = e.Graphics;
                g.DrawRectangle(p, 10, 10, 20, 20);
               // g.Dispose();
            }
            
            if (status2)
            {
                Pen p2 = new Pen(Color.Red);
                gp = e.Graphics;
                gp.DrawRectangle(p2, 20, 20, 40, 40);
                //gp.Dispose();
            }
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            status = true;
            panel1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            status = false;    
            panel1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            status2 = true;
            panel1.Refresh();
        }

     
    }
}
