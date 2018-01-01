namespace SmsListConverter
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btn_convert = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_filename = new System.Windows.Forms.TextBox();
			this.char_1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.char_2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.char_3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.debug = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_convert
			// 
			this.btn_convert.Location = new System.Drawing.Point(112, 119);
			this.btn_convert.Name = "btn_convert";
			this.btn_convert.Size = new System.Drawing.Size(112, 23);
			this.btn_convert.TabIndex = 0;
			this.btn_convert.Text = "Convert";
			this.btn_convert.UseVisualStyleBackColor = true;
			this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "File name";
			// 
			// txt_filename
			// 
			this.txt_filename.Location = new System.Drawing.Point(112, 13);
			this.txt_filename.Name = "txt_filename";
			this.txt_filename.Size = new System.Drawing.Size(174, 20);
			this.txt_filename.TabIndex = 3;
			// 
			// char_1
			// 
			this.char_1.Location = new System.Drawing.Point(112, 39);
			this.char_1.Name = "char_1";
			this.char_1.Size = new System.Drawing.Size(18, 20);
			this.char_1.TabIndex = 5;
			this.char_1.Tag = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Char to convert";
			// 
			// char_2
			// 
			this.char_2.Location = new System.Drawing.Point(112, 65);
			this.char_2.Name = "char_2";
			this.char_2.Size = new System.Drawing.Size(18, 20);
			this.char_2.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Char after convert";
			// 
			// char_3
			// 
			this.char_3.Location = new System.Drawing.Point(112, 91);
			this.char_3.Name = "char_3";
			this.char_3.Size = new System.Drawing.Size(18, 20);
			this.char_3.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Char replaced";
			// 
			// debug
			// 
			this.debug.Location = new System.Drawing.Point(13, 119);
			this.debug.Name = "debug";
			this.debug.Size = new System.Drawing.Size(65, 23);
			this.debug.TabIndex = 10;
			this.debug.Text = "Debug";
			this.debug.UseVisualStyleBackColor = true;
			this.debug.Visible = false;
			this.debug.Click += new System.EventHandler(this.debug_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(4, 56);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "kodowania 65001 Unicode UTF-8";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(174, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "Do Excela konwertujemy używając ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Location = new System.Drawing.Point(13, 163);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(235, 99);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Info";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 72);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 13);
			this.label6.TabIndex = 17;
			this.label6.Text = "(na samym dole listy)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(5, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(192, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Z Androida konwertujemy: SMS to Text";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(312, 282);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.debug);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.char_3);
			this.Controls.Add(this.char_2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.char_1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txt_filename);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_convert);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Tag = "Name of file ";
			this.Text = "Sms list converter V1.1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_convert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_filename;
        private System.Windows.Forms.TextBox char_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox char_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox char_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button debug;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

