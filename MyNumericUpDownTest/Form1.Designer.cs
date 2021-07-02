
namespace MyNumericUpDownTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myNumericUpDown1 = new NumericUpDown.MyNumericUpDown();
            this.SuspendLayout();
            // 
            // myNumericUpDown1
            // 
            this.myNumericUpDown1.BackColor = System.Drawing.Color.Silver;
            this.myNumericUpDown1.DownButtonBackColor = System.Drawing.Color.Silver;
            this.myNumericUpDown1.Location = new System.Drawing.Point(102, 113);
            this.myNumericUpDown1.Maximum = 100;
            this.myNumericUpDown1.Minimum = 0;
            this.myNumericUpDown1.Name = "myNumericUpDown1";
            this.myNumericUpDown1.Size = new System.Drawing.Size(191, 57);
            this.myNumericUpDown1.TabIndex = 1;
            this.myNumericUpDown1.Text = "myNumericUpDown1";
            this.myNumericUpDown1.TextBoxBackColor1 = System.Drawing.Color.OliveDrab;
            this.myNumericUpDown1.UpButtonBackColor = System.Drawing.Color.Silver;
            this.myNumericUpDown1.Value1 = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(416, 288);
            this.Controls.Add(this.myNumericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private NumericUpDown.MyNumericUpDown myNumericUpDown1;
    }
}

