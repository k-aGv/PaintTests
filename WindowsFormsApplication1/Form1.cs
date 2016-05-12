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
        bool status3 = false;

        /* 2 graphics.
         * Why we didnt do it before?Because we had CreateGraphics() function.
         * Now,we save/hold our graphics via PaintEventArgs e (build in shit)
         */
        Graphics g,gp,gtp;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Clean2Btn_Click(object sender, EventArgs e)
        {
            status2 = false;
            panel1.Refresh();
            
        }
        //----------PaintEventArgs.Not EventArgs------
        //                                           |
        //                                           |
        //                                           V
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (status)
            {
                Pen p =new Pen( Color.Black);
                g = e.Graphics;
                g.DrawRectangle(p, 10, 10, 20, 20);
            }
            
            if (status2)
            {
                Pen p2 = new Pen(Color.Red);
                gp = e.Graphics;
                gp.DrawRectangle(p2, 20, 20, 40, 40);
            }
            if (status3)
            {
                Pen p3 = new Pen(Color.Green);
                gtp = e.Graphics;
                gtp.DrawRectangle(p3, 30, 30, 60, 60);
            }
             
        }

        private void Paint1Btn_Click(object sender, EventArgs e)
        {
            status = true;
            panel1.Refresh();
        }

        private void Clean1Btn_Click(object sender, EventArgs e)
        {
            status = false;    
            panel1.Refresh();
        }

        private void Paint2Btn_Click(object sender, EventArgs e)
        {
            status2 = true;
            panel1.Refresh();
        }

        private void Paint3Btn_Click(object sender, EventArgs e)
        {
            status3 = true;
            panel1.Refresh();
        }

        private void Clean3Btn_Click(object sender, EventArgs e)
        {
            status3 = false;
            panel1.Refresh();
        }

     
    }
}
