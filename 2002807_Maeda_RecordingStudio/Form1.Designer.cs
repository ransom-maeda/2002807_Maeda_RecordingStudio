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
            this.nameInput = new System.Windows.Forms.TextBox();
            this.minutesInput = new System.Windows.Forms.TextBox();
            this.labelUsed = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCharge = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.singleCharge = new System.Windows.Forms.TextBox();
            this.groupNumber = new System.Windows.Forms.TextBox();
            this.averageCharge = new System.Windows.Forms.TextBox();
            this.totalCharge = new System.Windows.Forms.TextBox();
            this.boxCharges = new System.Windows.Forms.GroupBox();
            this.boxCharges.SuspendLayout();
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
            this.calculate.Location = new System.Drawing.Point(12, 274);
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
            this.clear.Location = new System.Drawing.Point(93, 274);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 2;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(167, 6);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 6;
            // 
            // minutesInput
            // 
            this.minutesInput.Location = new System.Drawing.Point(167, 36);
            this.minutesInput.Name = "minutesInput";
            this.minutesInput.Size = new System.Drawing.Size(100, 20);
            this.minutesInput.TabIndex = 9;
            this.minutesInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelUsed
            // 
            this.labelUsed.AutoSize = true;
            this.labelUsed.Location = new System.Drawing.Point(19, 40);
            this.labelUsed.Name = "labelUsed";
            this.labelUsed.Size = new System.Drawing.Size(72, 13);
            this.labelUsed.TabIndex = 12;
            this.labelUsed.Text = "Minutes Used";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(19, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 13);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Group Name";
            // 
            // labelCharge
            // 
            this.labelCharge.AutoSize = true;
            this.labelCharge.Location = new System.Drawing.Point(6, 30);
            this.labelCharge.Name = "labelCharge";
            this.labelCharge.Size = new System.Drawing.Size(117, 13);
            this.labelCharge.TabIndex = 14;
            this.labelCharge.Text = "Total charges for group";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(6, 60);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(68, 13);
            this.labelAmount.TabIndex = 16;
            this.labelAmount.Text = "Total Groups";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(6, 90);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(84, 13);
            this.labelAverage.TabIndex = 17;
            this.labelAverage.Text = "Average Charge";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(6, 120);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(131, 13);
            this.labelTotal.TabIndex = 18;
            this.labelTotal.Text = "Total Charge for all groups";
            // 
            // singleCharge
            // 
            this.singleCharge.Location = new System.Drawing.Point(154, 27);
            this.singleCharge.Name = "singleCharge";
            this.singleCharge.Size = new System.Drawing.Size(100, 20);
            this.singleCharge.TabIndex = 19;
            // 
            // groupNumber
            // 
            this.groupNumber.Location = new System.Drawing.Point(154, 57);
            this.groupNumber.Name = "groupNumber";
            this.groupNumber.Size = new System.Drawing.Size(100, 20);
            this.groupNumber.TabIndex = 20;
            // 
            // averageCharge
            // 
            this.averageCharge.Location = new System.Drawing.Point(154, 87);
            this.averageCharge.Name = "averageCharge";
            this.averageCharge.Size = new System.Drawing.Size(100, 20);
            this.averageCharge.TabIndex = 21;
            // 
            // totalCharge
            // 
            this.totalCharge.Location = new System.Drawing.Point(154, 117);
            this.totalCharge.Name = "totalCharge";
            this.totalCharge.Size = new System.Drawing.Size(100, 20);
            this.totalCharge.TabIndex = 22;
            // 
            // boxCharges
            // 
            this.boxCharges.Controls.Add(this.labelCharge);
            this.boxCharges.Controls.Add(this.totalCharge);
            this.boxCharges.Controls.Add(this.labelAmount);
            this.boxCharges.Controls.Add(this.averageCharge);
            this.boxCharges.Controls.Add(this.labelAverage);
            this.boxCharges.Controls.Add(this.groupNumber);
            this.boxCharges.Controls.Add(this.labelTotal);
            this.boxCharges.Controls.Add(this.singleCharge);
            this.boxCharges.Location = new System.Drawing.Point(12, 69);
            this.boxCharges.Name = "boxCharges";
            this.boxCharges.Size = new System.Drawing.Size(263, 151);
            this.boxCharges.TabIndex = 23;
            this.boxCharges.TabStop = false;
            this.boxCharges.Text = "Charges";
            // 
            // Form1
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boxCharges);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelUsed);
            this.Controls.Add(this.minutesInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.exit);
            this.Name = "Form1";
            this.Text = "Recording Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxCharges.ResumeLayout(false);
            this.boxCharges.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox minutesInput;
        private System.Windows.Forms.Label labelUsed;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCharge;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox singleCharge;
        private System.Windows.Forms.TextBox groupNumber;
        private System.Windows.Forms.TextBox averageCharge;
        private System.Windows.Forms.TextBox totalCharge;
        private System.Windows.Forms.GroupBox boxCharges;
    }
}

