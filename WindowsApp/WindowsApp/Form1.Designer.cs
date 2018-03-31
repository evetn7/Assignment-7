namespace WindowsApp
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
            this.Result = new System.Windows.Forms.Label();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.valueLabels = new System.Windows.Forms.Label();
            this.ResultLable = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Heading = new System.Windows.Forms.Label();
            this.DescriptionCalc = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Result.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.Yellow;
            this.Result.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Result.Location = new System.Drawing.Point(13, 332);
            this.Result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Result.MinimumSize = new System.Drawing.Size(100, 35);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(259, 35);
            this.Result.TabIndex = 0;
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // Value1
            // 
            this.Value1.Location = new System.Drawing.Point(32, 209);
            this.Value1.MaximumSize = new System.Drawing.Size(100, 35);
            this.Value1.MinimumSize = new System.Drawing.Size(100, 35);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(100, 35);
            this.Value1.TabIndex = 1;
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(138, 209);
            this.Value2.MaximumSize = new System.Drawing.Size(100, 35);
            this.Value2.MinimumSize = new System.Drawing.Size(100, 35);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(100, 35);
            this.Value2.TabIndex = 2;
            this.Value2.TextChanged += new System.EventHandler(this.Value2_TextChanged);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Image = ((System.Drawing.Image)(resources.GetObject("Add.Image")));
            this.Add.Location = new System.Drawing.Point(24, 137);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(79, 79);
            this.Add.TabIndex = 3;
            this.Add.Text = "\r\n";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Multiply
            // 
            this.Multiply.Image = ((System.Drawing.Image)(resources.GetObject("Multiply.Image")));
            this.Multiply.Location = new System.Drawing.Point(109, 137);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(79, 79);
            this.Multiply.TabIndex = 4;
            this.Multiply.Text = "\r\n";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(33, 344);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(143, 57);
            this.Reset.TabIndex = 5;
            this.Reset.Text = " Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.Reset);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.Multiply);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(279, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 455);
            this.panel1.TabIndex = 6;
            // 
            // valueLabels
            // 
            this.valueLabels.AutoSize = true;
            this.valueLabels.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabels.Location = new System.Drawing.Point(81, 178);
            this.valueLabels.Name = "valueLabels";
            this.valueLabels.Size = new System.Drawing.Size(103, 19);
            this.valueLabels.TabIndex = 7;
            this.valueLabels.Text = "Input Values";
            // 
            // ResultLable
            // 
            this.ResultLable.AutoSize = true;
            this.ResultLable.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLable.Location = new System.Drawing.Point(106, 302);
            this.ResultLable.Name = "ResultLable";
            this.ResultLable.Size = new System.Drawing.Size(58, 19);
            this.ResultLable.TabIndex = 9;
            this.ResultLable.Text = "Result";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Heading);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(479, 58);
            this.panel3.TabIndex = 10;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Heading.Location = new System.Drawing.Point(129, 7);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(218, 39);
            this.Heading.TabIndex = 11;
            this.Heading.Text = "SIMPLE CALC";
            // 
            // DescriptionCalc
            // 
            this.DescriptionCalc.AutoSize = true;
            this.DescriptionCalc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionCalc.Location = new System.Drawing.Point(8, 77);
            this.DescriptionCalc.Name = "DescriptionCalc";
            this.DescriptionCalc.Size = new System.Drawing.Size(265, 66);
            this.DescriptionCalc.TabIndex = 11;
            this.DescriptionCalc.Text = "Simple Calc helps you find the\r\nresult of two values through \r\naddition and multi" +
    "plication.\r\n";
            this.DescriptionCalc.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(479, 455);
            this.Controls.Add(this.DescriptionCalc);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ResultLable);
            this.Controls.Add(this.valueLabels);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.Value1);
            this.Controls.Add(this.Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Reset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label valueLabels;
        private System.Windows.Forms.Label ResultLable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label DescriptionCalc;
    }
}

