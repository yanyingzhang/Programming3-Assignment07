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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.calculateGBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.calculateGBox, "calculateGBox");
            this.calculateGBox.Name = "calculateGBox";
            this.calculateGBox.TabStop = false;
            // 
            // calculateResult
            // 
            resources.ApplyResources(this.calculateResult, "calculateResult");
            this.calculateResult.Name = "calculateResult";
            // 
            // calculateBtn
            // 
            this.calculateBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.calculateBtn.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.calculateBtn, "calculateBtn");
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.UseVisualStyleBackColor = false;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // calculateTxt
            // 
            this.calculateTxt.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.calculateTxt, "calculateTxt");
            this.calculateTxt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.calculateTxt.Name = "calculateTxt";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // checkGBox
            // 
            this.checkGBox.Controls.Add(this.checkResult);
            this.checkGBox.Controls.Add(this.checkBtn);
            this.checkGBox.Controls.Add(this.checkTxt);
            this.checkGBox.Controls.Add(this.label2);
            resources.ApplyResources(this.checkGBox, "checkGBox");
            this.checkGBox.Name = "checkGBox";
            this.checkGBox.TabStop = false;
            // 
            // checkResult
            // 
            resources.ApplyResources(this.checkResult, "checkResult");
            this.checkResult.Name = "checkResult";
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkBtn.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.checkBtn, "checkBtn");
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // checkTxt
            // 
            resources.ApplyResources(this.checkTxt, "checkTxt");
            this.checkTxt.Name = "checkTxt";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
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
            resources.ApplyResources(this.displayGBox, "displayGBox");
            this.displayGBox.Name = "displayGBox";
            this.displayGBox.TabStop = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // displayListView
            // 
            resources.ApplyResources(this.displayListView, "displayListView");
            this.displayListView.Name = "displayListView";
            this.displayListView.UseCompatibleStateImageBehavior = false;
            this.displayListView.View = System.Windows.Forms.View.List;
            // 
            // outputTxt
            // 
            resources.ApplyResources(this.outputTxt, "outputTxt");
            this.outputTxt.Name = "outputTxt";
            // 
            // highIndexTxt
            // 
            resources.ApplyResources(this.highIndexTxt, "highIndexTxt");
            this.highIndexTxt.Name = "highIndexTxt";
            // 
            // lowIndexTxt
            // 
            resources.ApplyResources(this.lowIndexTxt, "lowIndexTxt");
            this.lowIndexTxt.Name = "lowIndexTxt";
            // 
            // searchTxt
            // 
            resources.ApplyResources(this.searchTxt, "searchTxt");
            this.searchTxt.Name = "searchTxt";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // displayBtn
            // 
            this.displayBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.displayBtn.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.displayBtn, "displayBtn");
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.UseVisualStyleBackColor = false;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.searchBtn, "searchBtn");
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // generateBtn
            // 
            this.generateBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.generateBtn.ForeColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.generateBtn, "generateBtn");
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.UseVisualStyleBackColor = false;
            this.generateBtn.Click += new System.EventHandler(this.generateBtn_Click);
            // 
            // charRdb
            // 
            resources.ApplyResources(this.charRdb, "charRdb");
            this.charRdb.Name = "charRdb";
            this.charRdb.TabStop = true;
            this.charRdb.UseVisualStyleBackColor = true;
            // 
            // doubleRdb
            // 
            resources.ApplyResources(this.doubleRdb, "doubleRdb");
            this.doubleRdb.Name = "doubleRdb";
            this.doubleRdb.TabStop = true;
            this.doubleRdb.UseVisualStyleBackColor = true;
            // 
            // intRdb
            // 
            resources.ApplyResources(this.intRdb, "intRdb");
            this.intRdb.Name = "intRdb";
            this.intRdb.TabStop = true;
            this.intRdb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.displayGBox);
            this.Controls.Add(this.checkGBox);
            this.Controls.Add(this.calculateGBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
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

