namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ac_on_off = new System.Windows.Forms.Button();
            this.heat32 = new System.Windows.Forms.Button();
            this.heat25 = new System.Windows.Forms.Button();
            this.heat22 = new System.Windows.Forms.Button();
            this.cold18 = new System.Windows.Forms.Button();
            this.cold23 = new System.Windows.Forms.Button();
            this.fan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "get data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 34);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(58, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "off";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(58, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "on";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ac_on_off
            // 
            this.ac_on_off.Location = new System.Drawing.Point(15, 99);
            this.ac_on_off.Name = "ac_on_off";
            this.ac_on_off.Size = new System.Drawing.Size(58, 23);
            this.ac_on_off.TabIndex = 13;
            this.ac_on_off.Text = "ac on off";
            this.ac_on_off.UseVisualStyleBackColor = true;
            this.ac_on_off.Click += new System.EventHandler(this.ac_on_off_Click);
            // 
            // heat32
            // 
            this.heat32.Location = new System.Drawing.Point(15, 128);
            this.heat32.Name = "heat32";
            this.heat32.Size = new System.Drawing.Size(58, 23);
            this.heat32.TabIndex = 14;
            this.heat32.Text = "heat32";
            this.heat32.UseVisualStyleBackColor = true;
            this.heat32.Click += new System.EventHandler(this.heat32_Click);
            // 
            // heat25
            // 
            this.heat25.Location = new System.Drawing.Point(15, 157);
            this.heat25.Name = "heat25";
            this.heat25.Size = new System.Drawing.Size(58, 23);
            this.heat25.TabIndex = 15;
            this.heat25.Text = "heat25";
            this.heat25.UseVisualStyleBackColor = true;
            this.heat25.Click += new System.EventHandler(this.heat25_Click);
            // 
            // heat22
            // 
            this.heat22.Location = new System.Drawing.Point(15, 186);
            this.heat22.Name = "heat22";
            this.heat22.Size = new System.Drawing.Size(58, 23);
            this.heat22.TabIndex = 16;
            this.heat22.Text = "heat22";
            this.heat22.UseVisualStyleBackColor = true;
            this.heat22.Click += new System.EventHandler(this.heat22_Click);
            // 
            // cold18
            // 
            this.cold18.Location = new System.Drawing.Point(79, 128);
            this.cold18.Name = "cold18";
            this.cold18.Size = new System.Drawing.Size(58, 23);
            this.cold18.TabIndex = 17;
            this.cold18.Text = "cold18";
            this.cold18.UseVisualStyleBackColor = true;
            this.cold18.Click += new System.EventHandler(this.cold18_Click);
            // 
            // cold23
            // 
            this.cold23.Location = new System.Drawing.Point(79, 157);
            this.cold23.Name = "cold23";
            this.cold23.Size = new System.Drawing.Size(58, 23);
            this.cold23.TabIndex = 18;
            this.cold23.Text = "cold23";
            this.cold23.UseVisualStyleBackColor = true;
            this.cold23.Click += new System.EventHandler(this.cold23_Click);
            // 
            // fan
            // 
            this.fan.Location = new System.Drawing.Point(79, 186);
            this.fan.Name = "fan";
            this.fan.Size = new System.Drawing.Size(58, 23);
            this.fan.TabIndex = 19;
            this.fan.Text = "fan";
            this.fan.UseVisualStyleBackColor = true;
            this.fan.Click += new System.EventHandler(this.fan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 221);
            this.Controls.Add(this.fan);
            this.Controls.Add(this.cold23);
            this.Controls.Add(this.cold18);
            this.Controls.Add(this.heat22);
            this.Controls.Add(this.heat25);
            this.Controls.Add(this.heat32);
            this.Controls.Add(this.ac_on_off);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ac_on_off;
        private System.Windows.Forms.Button heat32;
        private System.Windows.Forms.Button heat25;
        private System.Windows.Forms.Button heat22;
        private System.Windows.Forms.Button cold18;
        private System.Windows.Forms.Button cold23;
        private System.Windows.Forms.Button fan;
    }
}

