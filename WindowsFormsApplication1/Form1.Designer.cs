namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Clean2Btn = new System.Windows.Forms.Button();
            this.Paint1Btn = new System.Windows.Forms.Button();
            this.Clean1Btn = new System.Windows.Forms.Button();
            this.Paint2Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(123, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 200);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Clean2Btn
            // 
            this.Clean2Btn.Location = new System.Drawing.Point(290, 308);
            this.Clean2Btn.Name = "Clean2Btn";
            this.Clean2Btn.Size = new System.Drawing.Size(77, 36);
            this.Clean2Btn.TabIndex = 1;
            this.Clean2Btn.Text = "Clean ";
            this.Clean2Btn.UseVisualStyleBackColor = true;
            this.Clean2Btn.Click += new System.EventHandler(this.Clean2Btn_Click);
            // 
            // Paint1Btn
            // 
            this.Paint1Btn.Location = new System.Drawing.Point(25, 249);
            this.Paint1Btn.Name = "Paint1Btn";
            this.Paint1Btn.Size = new System.Drawing.Size(145, 53);
            this.Paint1Btn.TabIndex = 2;
            this.Paint1Btn.Text = "Paint1";
            this.Paint1Btn.UseVisualStyleBackColor = true;
            this.Paint1Btn.Click += new System.EventHandler(this.Paint1Btn_Click);
            // 
            // Clean1Btn
            // 
            this.Clean1Btn.Location = new System.Drawing.Point(59, 308);
            this.Clean1Btn.Name = "Clean1Btn";
            this.Clean1Btn.Size = new System.Drawing.Size(75, 23);
            this.Clean1Btn.TabIndex = 3;
            this.Clean1Btn.Text = "Clean";
            this.Clean1Btn.UseVisualStyleBackColor = true;
            this.Clean1Btn.Click += new System.EventHandler(this.Clean1Btn_Click);
            // 
            // Paint2Btn
            // 
            this.Paint2Btn.Location = new System.Drawing.Point(271, 244);
            this.Paint2Btn.Name = "Paint2Btn";
            this.Paint2Btn.Size = new System.Drawing.Size(123, 62);
            this.Paint2Btn.TabIndex = 4;
            this.Paint2Btn.Text = "paint2";
            this.Paint2Btn.UseVisualStyleBackColor = true;
            this.Paint2Btn.Click += new System.EventHandler(this.Paint2Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 359);
            this.Controls.Add(this.Paint2Btn);
            this.Controls.Add(this.Clean1Btn);
            this.Controls.Add(this.Paint1Btn);
            this.Controls.Add(this.Clean2Btn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Clean2Btn;
        private System.Windows.Forms.Button Paint1Btn;
        private System.Windows.Forms.Button Clean1Btn;
        private System.Windows.Forms.Button Paint2Btn;
    }
}

