namespace _2002807_Maeda_RecordingStudio
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
            this.exit = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.group1 = new System.Windows.Forms.Label();
            this.group2 = new System.Windows.Forms.Label();
            this.group3 = new System.Windows.Forms.Label();
            this.nameInput1 = new System.Windows.Forms.TextBox();
            this.nameInput2 = new System.Windows.Forms.TextBox();
            this.nameInput3 = new System.Windows.Forms.TextBox();
            this.minutesInput1 = new System.Windows.Forms.TextBox();
            this.minutesInput2 = new System.Windows.Forms.TextBox();
            this.minutesInput3 = new System.Windows.Forms.TextBox();
            this.labelUsed = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // calculate
            // 
            this.calculate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calculate.Location = new System.Drawing.Point(12, 269);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear.Location = new System.Drawing.Point(93, 269);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // group1
            // 
            this.group1.AutoSize = true;
            this.group1.Location = new System.Drawing.Point(123, 9);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(45, 13);
            this.group1.TabIndex = 3;
            this.group1.Text = "Group 1";
            // 
            // group2
            // 
            this.group2.AutoSize = true;
            this.group2.Location = new System.Drawing.Point(288, 9);
            this.group2.Name = "group2";
            this.group2.Size = new System.Drawing.Size(45, 13);
            this.group2.TabIndex = 4;
            this.group2.Text = "Group 2";
            // 
            // group3
            // 
            this.group3.AutoSize = true;
            this.group3.Location = new System.Drawing.Point(453, 9);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(45, 13);
            this.group3.TabIndex = 5;
            this.group3.Text = "Group 3";
            // 
            // nameInput1
            // 
            this.nameInput1.Location = new System.Drawing.Point(93, 32);
            this.nameInput1.Name = "nameInput1";
            this.nameInput1.Size = new System.Drawing.Size(100, 20);
            this.nameInput1.TabIndex = 6;
            // 
            // nameInput2
            // 
            this.nameInput2.Location = new System.Drawing.Point(259, 32);
            this.nameInput2.Name = "nameInput2";
            this.nameInput2.Size = new System.Drawing.Size(100, 20);
            this.nameInput2.TabIndex = 7;
            // 
            // nameInput3
            // 
            this.nameInput3.Location = new System.Drawing.Point(425, 32);
            this.nameInput3.Name = "nameInput3";
            this.nameInput3.Size = new System.Drawing.Size(100, 20);
            this.nameInput3.TabIndex = 8;
            // 
            // minutesInput1
            // 
            this.minutesInput1.Location = new System.Drawing.Point(93, 69);
            this.minutesInput1.Name = "minutesInput1";
            this.minutesInput1.Size = new System.Drawing.Size(100, 20);
            this.minutesInput1.TabIndex = 9;
            this.minutesInput1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // minutesInput2
            // 
            this.minutesInput2.Location = new System.Drawing.Point(259, 70);
            this.minutesInput2.Name = "minutesInput2";
            this.minutesInput2.Size = new System.Drawing.Size(100, 20);
            this.minutesInput2.TabIndex = 10;
            // 
            // minutesInput3
            // 
            this.minutesInput3.Location = new System.Drawing.Point(425, 69);
            this.minutesInput3.Name = "minutesInput3";
            this.minutesInput3.Size = new System.Drawing.Size(100, 20);
            this.minutesInput3.TabIndex = 11;
            // 
            // labelUsed
            // 
            this.labelUsed.AutoSize = true;
            this.labelUsed.Location = new System.Drawing.Point(9, 73);
            this.labelUsed.Name = "labelUsed";
            this.labelUsed.Size = new System.Drawing.Size(72, 13);
            this.labelUsed.TabIndex = 12;
            this.labelUsed.Text = "Minutes Used";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 35);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Group Name";
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(12, 112);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(347, 134);
            this.output.TabIndex = 14;
            this.output.Text = "";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.output);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUsed);
            this.Controls.Add(this.minutesInput3);
            this.Controls.Add(this.minutesInput2);
            this.Controls.Add(this.minutesInput1);
            this.Controls.Add(this.nameInput3);
            this.Controls.Add(this.nameInput2);
            this.Controls.Add(this.nameInput1);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Recording Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label group1;
        private System.Windows.Forms.Label group2;
        private System.Windows.Forms.Label group3;
        private System.Windows.Forms.TextBox nameInput1;
        private System.Windows.Forms.TextBox nameInput2;
        private System.Windows.Forms.TextBox nameInput3;
        private System.Windows.Forms.TextBox minutesInput1;
        private System.Windows.Forms.TextBox minutesInput2;
        private System.Windows.Forms.TextBox minutesInput3;
        private System.Windows.Forms.Label labelUsed;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox output;
    }
}

