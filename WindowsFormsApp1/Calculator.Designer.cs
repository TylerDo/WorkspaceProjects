namespace WindowsFormsApp1
{
    partial class Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmd0 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd3 = new System.Windows.Forms.Button();
            this.cmd4 = new System.Windows.Forms.Button();
            this.cmd5 = new System.Windows.Forms.Button();
            this.cmd6 = new System.Windows.Forms.Button();
            this.cmd7 = new System.Windows.Forms.Button();
            this.cmd8 = new System.Windows.Forms.Button();
            this.cmd9 = new System.Windows.Forms.Button();
            this.cmdequal = new System.Windows.Forms.Button();
            this.cmdclear = new System.Windows.Forms.Button();
            this.cmdplus = new System.Windows.Forms.Button();
            this.cmdminus = new System.Windows.Forms.Button();
            this.cmdmultiply = new System.Windows.Forms.Button();
            this.cmddivision = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmd0
            // 
            this.cmd0.Location = new System.Drawing.Point(105, 69);
            this.cmd0.Name = "cmd0";
            this.cmd0.Size = new System.Drawing.Size(75, 23);
            this.cmd0.TabIndex = 1;
            this.cmd0.Text = "0";
            this.cmd0.UseVisualStyleBackColor = true;
            this.cmd0.Click += new System.EventHandler(this.cmd0_Click);
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(186, 69);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(75, 23);
            this.cmd1.TabIndex = 2;
            this.cmd1.Text = "1";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(24, 98);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(75, 23);
            this.cmd2.TabIndex = 3;
            this.cmd2.Text = "2";
            this.cmd2.UseVisualStyleBackColor = true;
            this.cmd2.Click += new System.EventHandler(this.cm2_Click);
            // 
            // cmd3
            // 
            this.cmd3.Location = new System.Drawing.Point(105, 98);
            this.cmd3.Name = "cmd3";
            this.cmd3.Size = new System.Drawing.Size(75, 23);
            this.cmd3.TabIndex = 4;
            this.cmd3.Text = "3";
            this.cmd3.UseVisualStyleBackColor = true;
            this.cmd3.Click += new System.EventHandler(this.cmd3_Click);
            // 
            // cmd4
            // 
            this.cmd4.Location = new System.Drawing.Point(186, 98);
            this.cmd4.Name = "cmd4";
            this.cmd4.Size = new System.Drawing.Size(75, 23);
            this.cmd4.TabIndex = 5;
            this.cmd4.Text = "4";
            this.cmd4.UseVisualStyleBackColor = true;
            this.cmd4.Click += new System.EventHandler(this.cmd4_Click);
            // 
            // cmd5
            // 
            this.cmd5.Location = new System.Drawing.Point(24, 127);
            this.cmd5.Name = "cmd5";
            this.cmd5.Size = new System.Drawing.Size(75, 23);
            this.cmd5.TabIndex = 6;
            this.cmd5.Text = "5";
            this.cmd5.UseVisualStyleBackColor = true;
            this.cmd5.Click += new System.EventHandler(this.cmd5_Click);
            // 
            // cmd6
            // 
            this.cmd6.Location = new System.Drawing.Point(105, 127);
            this.cmd6.Name = "cmd6";
            this.cmd6.Size = new System.Drawing.Size(75, 23);
            this.cmd6.TabIndex = 7;
            this.cmd6.Text = "6";
            this.cmd6.UseVisualStyleBackColor = true;
            this.cmd6.Click += new System.EventHandler(this.cmd6_Click);
            // 
            // cmd7
            // 
            this.cmd7.Location = new System.Drawing.Point(186, 127);
            this.cmd7.Name = "cmd7";
            this.cmd7.Size = new System.Drawing.Size(75, 23);
            this.cmd7.TabIndex = 8;
            this.cmd7.Text = "7";
            this.cmd7.UseVisualStyleBackColor = true;
            this.cmd7.Click += new System.EventHandler(this.cmd7_Click);
            // 
            // cmd8
            // 
            this.cmd8.Location = new System.Drawing.Point(24, 156);
            this.cmd8.Name = "cmd8";
            this.cmd8.Size = new System.Drawing.Size(75, 23);
            this.cmd8.TabIndex = 9;
            this.cmd8.Text = "8";
            this.cmd8.UseVisualStyleBackColor = true;
            this.cmd8.Click += new System.EventHandler(this.cm8_Click);
            // 
            // cmd9
            // 
            this.cmd9.Location = new System.Drawing.Point(105, 156);
            this.cmd9.Name = "cmd9";
            this.cmd9.Size = new System.Drawing.Size(75, 23);
            this.cmd9.TabIndex = 10;
            this.cmd9.Text = "9";
            this.cmd9.UseVisualStyleBackColor = true;
            this.cmd9.Click += new System.EventHandler(this.cmd9_Click);
            // 
            // cmdequal
            // 
            this.cmdequal.Location = new System.Drawing.Point(186, 156);
            this.cmdequal.Name = "cmdequal";
            this.cmdequal.Size = new System.Drawing.Size(75, 23);
            this.cmdequal.TabIndex = 11;
            this.cmdequal.Text = "=";
            this.cmdequal.UseVisualStyleBackColor = true;
            this.cmdequal.Click += new System.EventHandler(this.cmdequal_Click);
            // 
            // cmdclear
            // 
            this.cmdclear.Location = new System.Drawing.Point(24, 69);
            this.cmdclear.Name = "cmdclear";
            this.cmdclear.Size = new System.Drawing.Size(75, 23);
            this.cmdclear.TabIndex = 12;
            this.cmdclear.Text = "C";
            this.cmdclear.UseVisualStyleBackColor = true;
            this.cmdclear.Click += new System.EventHandler(this.cmdclear_Click);
            // 
            // cmdplus
            // 
            this.cmdplus.Location = new System.Drawing.Point(105, 185);
            this.cmdplus.Name = "cmdplus";
            this.cmdplus.Size = new System.Drawing.Size(75, 23);
            this.cmdplus.TabIndex = 13;
            this.cmdplus.Text = "+";
            this.cmdplus.UseVisualStyleBackColor = true;
            this.cmdplus.Click += new System.EventHandler(this.cmdplus_Click);
            // 
            // cmdminus
            // 
            this.cmdminus.Location = new System.Drawing.Point(105, 214);
            this.cmdminus.Name = "cmdminus";
            this.cmdminus.Size = new System.Drawing.Size(75, 23);
            this.cmdminus.TabIndex = 14;
            this.cmdminus.Text = "-";
            this.cmdminus.UseVisualStyleBackColor = true;
            this.cmdminus.Click += new System.EventHandler(this.cmdminus_Click);
            // 
            // cmdmultiply
            // 
            this.cmdmultiply.Location = new System.Drawing.Point(24, 185);
            this.cmdmultiply.Name = "cmdmultiply";
            this.cmdmultiply.Size = new System.Drawing.Size(75, 23);
            this.cmdmultiply.TabIndex = 15;
            this.cmdmultiply.Text = "*";
            this.cmdmultiply.UseVisualStyleBackColor = true;
            this.cmdmultiply.Click += new System.EventHandler(this.cmdmultiply_Click);
            // 
            // cmddivision
            // 
            this.cmddivision.Location = new System.Drawing.Point(24, 214);
            this.cmddivision.Name = "cmddivision";
            this.cmddivision.Size = new System.Drawing.Size(75, 23);
            this.cmddivision.TabIndex = 16;
            this.cmddivision.Text = "/";
            this.cmddivision.UseVisualStyleBackColor = true;
            this.cmddivision.Click += new System.EventHandler(this.cmddivision_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 450);
            this.Controls.Add(this.cmddivision);
            this.Controls.Add(this.cmdmultiply);
            this.Controls.Add(this.cmdminus);
            this.Controls.Add(this.cmdplus);
            this.Controls.Add(this.cmdclear);
            this.Controls.Add(this.cmdequal);
            this.Controls.Add(this.cmd9);
            this.Controls.Add(this.cmd8);
            this.Controls.Add(this.cmd7);
            this.Controls.Add(this.cmd6);
            this.Controls.Add(this.cmd5);
            this.Controls.Add(this.cmd4);
            this.Controls.Add(this.cmd3);
            this.Controls.Add(this.cmd2);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmd0);
            this.Controls.Add(this.textBox1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmd0;
        private System.Windows.Forms.Button cmd1;
        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd3;
        private System.Windows.Forms.Button cmd4;
        private System.Windows.Forms.Button cmd5;
        private System.Windows.Forms.Button cmd6;
        private System.Windows.Forms.Button cmd7;
        private System.Windows.Forms.Button cmd8;
        private System.Windows.Forms.Button cmd9;
        private System.Windows.Forms.Button cmdequal;
        private System.Windows.Forms.Button cmdclear;
        private System.Windows.Forms.Button cmdplus;
        private System.Windows.Forms.Button cmdminus;
        private System.Windows.Forms.Button cmdmultiply;
        private System.Windows.Forms.Button cmddivision;
    }
}

