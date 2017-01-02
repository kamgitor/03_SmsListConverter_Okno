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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(133, 119);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(89, 23);
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
            this.txt_filename.Size = new System.Drawing.Size(110, 20);
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
            this.debug.Location = new System.Drawing.Point(18, 119);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(65, 23);
            this.debug.TabIndex = 10;
            this.debug.Text = "Debug";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Visible = false;
            this.debug.Click += new System.EventHandler(this.debug_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(14, 154);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(210, 85);
            this.textBox1.TabIndex = 17;
            this.textBox1.Tag = "";
            this.textBox1.Text = "Z Androida konwertujemy: SMS to Text\r\nDo Excela konwertujemy używając\r\nkodowania " +
                "65001 Unicode UTF-8\r\n(na samym dole listy)\r\nFormat danych w kolumnie - text\r\nMes" +
                "sage formatuj komórki - zawijaj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 251);
            this.Controls.Add(this.textBox1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Tag = "Name of file ";
            this.Text = "Sms list converter";
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

