namespace Homework1
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
            this.doSomething = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CheckIntB = new System.Windows.Forms.Button();
            this.roundB = new System.Windows.Forms.Button();
            this.RollDieB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doSomething
            // 
            this.doSomething.BackColor = System.Drawing.Color.Fuchsia;
            this.doSomething.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.doSomething.Location = new System.Drawing.Point(100, 89);
            this.doSomething.Name = "doSomething";
            this.doSomething.Size = new System.Drawing.Size(111, 53);
            this.doSomething.TabIndex = 0;
            this.doSomething.Text = "AI Project";
            this.doSomething.UseVisualStyleBackColor = false;
            this.doSomething.Click += new System.EventHandler(this.doSomething_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(426, 199);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(426, 287);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // CheckIntB
            // 
            this.CheckIntB.Location = new System.Drawing.Point(581, 122);
            this.CheckIntB.Name = "CheckIntB";
            this.CheckIntB.Size = new System.Drawing.Size(75, 23);
            this.CheckIntB.TabIndex = 6;
            this.CheckIntB.Text = "Check Integer";
            this.CheckIntB.UseVisualStyleBackColor = true;
            this.CheckIntB.Click += new System.EventHandler(this.button3_Click);
            // 
            // roundB
            // 
            this.roundB.Location = new System.Drawing.Point(581, 199);
            this.roundB.Name = "roundB";
            this.roundB.Size = new System.Drawing.Size(75, 23);
            this.roundB.TabIndex = 7;
            this.roundB.Text = "Round to 2";
            this.roundB.UseVisualStyleBackColor = true;
            this.roundB.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // RollDieB
            // 
            this.RollDieB.Location = new System.Drawing.Point(581, 284);
            this.RollDieB.Name = "RollDieB";
            this.RollDieB.Size = new System.Drawing.Size(75, 23);
            this.RollDieB.TabIndex = 8;
            this.RollDieB.Text = "Roll The Die";
            this.RollDieB.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RollDieB);
            this.Controls.Add(this.roundB);
            this.Controls.Add(this.CheckIntB);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.doSomething);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doSomething;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button CheckIntB;
        private System.Windows.Forms.Button roundB;
        private System.Windows.Forms.Button RollDieB;
    }
}

