namespace YanyingZhang_Lab07_Sec_02
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
            this.calculateGB = new System.Windows.Forms.GroupBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.calculateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkGB = new System.Windows.Forms.GroupBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.checkTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displayGB = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.charRdb = new System.Windows.Forms.RadioButton();
            this.doubleRdb = new System.Windows.Forms.RadioButton();
            this.intRdb = new System.Windows.Forms.RadioButton();
            this.checkResult = new System.Windows.Forms.Label();
            this.calculateResult = new System.Windows.Forms.Label();
            this.calculateGB.SuspendLayout();
            this.checkGB.SuspendLayout();
            this.displayGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateGB
            // 
            this.calculateGB.Controls.Add(this.calculateResult);
            this.calculateGB.Controls.Add(this.calculateBtn);
            this.calculateGB.Controls.Add(this.calculateTxt);
            this.calculateGB.Controls.Add(this.label1);
            this.calculateGB.Location = new System.Drawing.Point(12, 12);
            this.calculateGB.Name = "calculateGB";
            this.calculateGB.Size = new System.Drawing.Size(274, 182);
            this.calculateGB.TabIndex = 0;
            this.calculateGB.TabStop = false;
            this.calculateGB.Text = "(1) Calculate Asynchronously";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(158, 88);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(98, 40);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // calculateTxt
            // 
            this.calculateTxt.Location = new System.Drawing.Point(147, 44);
            this.calculateTxt.Name = "calculateTxt";
            this.calculateTxt.Size = new System.Drawing.Size(100, 26);
            this.calculateTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Factorial of:";
            // 
            // checkGB
            // 
            this.checkGB.Controls.Add(this.checkResult);
            this.checkGB.Controls.Add(this.checkBtn);
            this.checkGB.Controls.Add(this.checkTxt);
            this.checkGB.Controls.Add(this.label2);
            this.checkGB.Location = new System.Drawing.Point(12, 201);
            this.checkGB.Name = "checkGB";
            this.checkGB.Size = new System.Drawing.Size(274, 190);
            this.checkGB.TabIndex = 1;
            this.checkGB.TabStop = false;
            this.checkGB.Text = "(2) Check for Even/Odd";
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(56, 84);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(200, 40);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "Check For Even/Odd";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // checkTxt
            // 
            this.checkTxt.Location = new System.Drawing.Point(147, 46);
            this.checkTxt.Name = "checkTxt";
            this.checkTxt.Size = new System.Drawing.Size(100, 26);
            this.checkTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Input Number:";
            // 
            // displayGB
            // 
            this.displayGB.Controls.Add(this.label6);
            this.displayGB.Controls.Add(this.listView1);
            this.displayGB.Controls.Add(this.textBox6);
            this.displayGB.Controls.Add(this.textBox5);
            this.displayGB.Controls.Add(this.textBox4);
            this.displayGB.Controls.Add(this.textBox3);
            this.displayGB.Controls.Add(this.label5);
            this.displayGB.Controls.Add(this.label4);
            this.displayGB.Controls.Add(this.label3);
            this.displayGB.Controls.Add(this.displayBtn);
            this.displayGB.Controls.Add(this.searchBtn);
            this.displayGB.Controls.Add(this.generateBtn);
            this.displayGB.Controls.Add(this.charRdb);
            this.displayGB.Controls.Add(this.doubleRdb);
            this.displayGB.Controls.Add(this.intRdb);
            this.displayGB.Location = new System.Drawing.Point(302, 12);
            this.displayGB.Name = "displayGB";
            this.displayGB.Size = new System.Drawing.Size(481, 379);
            this.displayGB.TabIndex = 2;
            this.displayGB.TabStop = false;
            this.displayGB.Text = "(3) Display List of Values and Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Output of values between low and high:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(19, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(75, 255);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(118, 327);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(341, 26);
            this.textBox6.TabIndex = 12;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(270, 203);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 26);
            this.textBox5.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(270, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 26);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(270, 102);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 26);
            this.textBox3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Input high index:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input Low Index:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input Value for Search:";
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(376, 189);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 40);
            this.displayBtn.TabIndex = 5;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(376, 95);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 40);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(299, 40);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(160, 40);
            this.generateBtn.TabIndex = 3;
            this.generateBtn.Text = "Generate Values";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // charRdb
            // 
            this.charRdb.AutoSize = true;
            this.charRdb.Location = new System.Drawing.Point(217, 48);
            this.charRdb.Name = "charRdb";
            this.charRdb.Size = new System.Drawing.Size(76, 24);
            this.charRdb.TabIndex = 2;
            this.charRdb.TabStop = true;
            this.charRdb.Text = "Chars";
            this.charRdb.UseVisualStyleBackColor = true;
            // 
            // doubleRdb
            // 
            this.doubleRdb.AutoSize = true;
            this.doubleRdb.Location = new System.Drawing.Point(118, 48);
            this.doubleRdb.Name = "doubleRdb";
            this.doubleRdb.Size = new System.Drawing.Size(93, 24);
            this.doubleRdb.TabIndex = 1;
            this.doubleRdb.TabStop = true;
            this.doubleRdb.Text = "Doubles";
            this.doubleRdb.UseVisualStyleBackColor = true;
            // 
            // intRdb
            // 
            this.intRdb.AutoSize = true;
            this.intRdb.Location = new System.Drawing.Point(19, 48);
            this.intRdb.Name = "intRdb";
            this.intRdb.Size = new System.Drawing.Size(93, 24);
            this.intRdb.TabIndex = 0;
            this.intRdb.TabStop = true;
            this.intRdb.Text = "Integers";
            this.intRdb.UseVisualStyleBackColor = true;
            // 
            // checkResult
            // 
            this.checkResult.AutoSize = true;
            this.checkResult.Location = new System.Drawing.Point(18, 156);
            this.checkResult.Name = "checkResult";
            this.checkResult.Size = new System.Drawing.Size(55, 20);
            this.checkResult.TabIndex = 3;
            this.checkResult.Text = "Result";
            // 
            // calculateResult
            // 
            this.calculateResult.AutoSize = true;
            this.calculateResult.Location = new System.Drawing.Point(18, 138);
            this.calculateResult.Name = "calculateResult";
            this.calculateResult.Size = new System.Drawing.Size(55, 20);
            this.calculateResult.TabIndex = 3;
            this.calculateResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 420);
            this.Controls.Add(this.displayGB);
            this.Controls.Add(this.checkGB);
            this.Controls.Add(this.calculateGB);
            this.Name = "Form1";
            this.Text = "Asynchronously Programming";
            this.calculateGB.ResumeLayout(false);
            this.calculateGB.PerformLayout();
            this.checkGB.ResumeLayout(false);
            this.checkGB.PerformLayout();
            this.displayGB.ResumeLayout(false);
            this.displayGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calculateGB;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox calculateTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox checkGB;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox checkTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox displayGB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.RadioButton charRdb;
        private System.Windows.Forms.RadioButton doubleRdb;
        private System.Windows.Forms.RadioButton intRdb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label checkResult;
        private System.Windows.Forms.Label calculateResult;
    }
}

