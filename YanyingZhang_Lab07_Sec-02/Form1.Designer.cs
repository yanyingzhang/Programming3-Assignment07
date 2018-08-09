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
            this.calculateGBox = new System.Windows.Forms.GroupBox();
            this.calculateResult = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.calculateTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkGBox = new System.Windows.Forms.GroupBox();
            this.checkResult = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.checkTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displayGBox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.displayListView = new System.Windows.Forms.ListView();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.highIndexTxt = new System.Windows.Forms.TextBox();
            this.lowIndexTxt = new System.Windows.Forms.TextBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.displayBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.generateBtn = new System.Windows.Forms.Button();
            this.charRdb = new System.Windows.Forms.RadioButton();
            this.doubleRdb = new System.Windows.Forms.RadioButton();
            this.intRdb = new System.Windows.Forms.RadioButton();
            this.calculateGBox.SuspendLayout();
            this.checkGBox.SuspendLayout();
            this.displayGBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateGBox
            // 
            this.calculateGBox.Controls.Add(this.calculateResult);
            this.calculateGBox.Controls.Add(this.calculateBtn);
            this.calculateGBox.Controls.Add(this.calculateTxt);
            this.calculateGBox.Controls.Add(this.label1);
            this.calculateGBox.Location = new System.Drawing.Point(12, 12);
            this.calculateGBox.Name = "calculateGBox";
            this.calculateGBox.Size = new System.Drawing.Size(319, 182);
            this.calculateGBox.TabIndex = 0;
            this.calculateGBox.TabStop = false;
            this.calculateGBox.Text = "(1) Calculate Asynchronously";
            // 
            // calculateResult
            // 
            this.calculateResult.AutoSize = true;
            this.calculateResult.Location = new System.Drawing.Point(16, 144);
            this.calculateResult.Name = "calculateResult";
            this.calculateResult.Size = new System.Drawing.Size(0, 20);
            this.calculateResult.TabIndex = 3;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(162, 88);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(98, 40);
            this.calculateBtn.TabIndex = 2;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // calculateTxt
            // 
            this.calculateTxt.Location = new System.Drawing.Point(160, 44);
            this.calculateTxt.Name = "calculateTxt";
            this.calculateTxt.Size = new System.Drawing.Size(100, 26);
            this.calculateTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Factorial of:";
            // 
            // checkGBox
            // 
            this.checkGBox.Controls.Add(this.checkResult);
            this.checkGBox.Controls.Add(this.checkBtn);
            this.checkGBox.Controls.Add(this.checkTxt);
            this.checkGBox.Controls.Add(this.label2);
            this.checkGBox.Location = new System.Drawing.Point(12, 213);
            this.checkGBox.Name = "checkGBox";
            this.checkGBox.Size = new System.Drawing.Size(319, 196);
            this.checkGBox.TabIndex = 1;
            this.checkGBox.TabStop = false;
            this.checkGBox.Text = "(2) Check for Even/Odd";
            // 
            // checkResult
            // 
            this.checkResult.AutoSize = true;
            this.checkResult.Location = new System.Drawing.Point(16, 156);
            this.checkResult.Name = "checkResult";
            this.checkResult.Size = new System.Drawing.Size(0, 20);
            this.checkResult.TabIndex = 3;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(56, 85);
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
            // displayGBox
            // 
            this.displayGBox.Controls.Add(this.label6);
            this.displayGBox.Controls.Add(this.displayListView);
            this.displayGBox.Controls.Add(this.outputTxt);
            this.displayGBox.Controls.Add(this.highIndexTxt);
            this.displayGBox.Controls.Add(this.lowIndexTxt);
            this.displayGBox.Controls.Add(this.searchTxt);
            this.displayGBox.Controls.Add(this.label5);
            this.displayGBox.Controls.Add(this.label4);
            this.displayGBox.Controls.Add(this.label3);
            this.displayGBox.Controls.Add(this.displayBtn);
            this.displayGBox.Controls.Add(this.searchBtn);
            this.displayGBox.Controls.Add(this.generateBtn);
            this.displayGBox.Controls.Add(this.charRdb);
            this.displayGBox.Controls.Add(this.doubleRdb);
            this.displayGBox.Controls.Add(this.intRdb);
            this.displayGBox.Location = new System.Drawing.Point(347, 12);
            this.displayGBox.Name = "displayGBox";
            this.displayGBox.Size = new System.Drawing.Size(500, 397);
            this.displayGBox.TabIndex = 2;
            this.displayGBox.TabStop = false;
            this.displayGBox.Text = "(3) Display List of Values and Search";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Output of values between low and high:";
            // 
            // displayListView
            // 
            this.displayListView.Location = new System.Drawing.Point(19, 98);
            this.displayListView.Name = "displayListView";
            this.displayListView.Size = new System.Drawing.Size(93, 279);
            this.displayListView.TabIndex = 13;
            this.displayListView.UseCompatibleStateImageBehavior = false;
            // 
            // outputTxt
            // 
            this.outputTxt.Location = new System.Drawing.Point(136, 351);
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.Size = new System.Drawing.Size(341, 26);
            this.outputTxt.TabIndex = 12;
            // 
            // highIndexTxt
            // 
            this.highIndexTxt.Location = new System.Drawing.Point(289, 203);
            this.highIndexTxt.Name = "highIndexTxt";
            this.highIndexTxt.Size = new System.Drawing.Size(100, 26);
            this.highIndexTxt.TabIndex = 11;
            // 
            // lowIndexTxt
            // 
            this.lowIndexTxt.Location = new System.Drawing.Point(289, 156);
            this.lowIndexTxt.Name = "lowIndexTxt";
            this.lowIndexTxt.Size = new System.Drawing.Size(100, 26);
            this.lowIndexTxt.TabIndex = 10;
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(289, 102);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(100, 26);
            this.searchTxt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(168, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Input high index:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input Low Index:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Input Value for Search:";
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(402, 169);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 40);
            this.displayBtn.TabIndex = 5;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(402, 95);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 40);
            this.searchBtn.TabIndex = 4;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(317, 37);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 433);
            this.Controls.Add(this.displayGBox);
            this.Controls.Add(this.checkGBox);
            this.Controls.Add(this.calculateGBox);
            this.Name = "Form1";
            this.Text = "Asynchronously Programming";
            this.calculateGBox.ResumeLayout(false);
            this.calculateGBox.PerformLayout();
            this.checkGBox.ResumeLayout(false);
            this.checkGBox.PerformLayout();
            this.displayGBox.ResumeLayout(false);
            this.displayGBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calculateGBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox calculateTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox checkGBox;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.TextBox checkTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox displayGBox;
        private System.Windows.Forms.ListView displayListView;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.TextBox highIndexTxt;
        private System.Windows.Forms.TextBox lowIndexTxt;
        private System.Windows.Forms.TextBox searchTxt;
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

