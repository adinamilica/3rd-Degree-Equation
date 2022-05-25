namespace _3rdDegreeEquation
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
            this.RootsCalculator = new System.Windows.Forms.Button();
            this.Coefficient_a_re = new System.Windows.Forms.TextBox();
            this.Coefficient_b_re = new System.Windows.Forms.TextBox();
            this.Coefficient_c_re = new System.Windows.Forms.TextBox();
            this.Coefficient_d_re = new System.Windows.Forms.TextBox();
            this.Root1 = new System.Windows.Forms.Label();
            this.Root2 = new System.Windows.Forms.Label();
            this.Root3 = new System.Windows.Forms.Label();
            this.Coefficient_d_Im = new System.Windows.Forms.TextBox();
            this.Coefficient_c_Im = new System.Windows.Forms.TextBox();
            this.Coefficient_b_Im = new System.Windows.Forms.TextBox();
            this.Coefficient_a_Im = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RootsCalculator
            // 
            this.RootsCalculator.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RootsCalculator.Font = new System.Drawing.Font("Bebas Neue", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RootsCalculator.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RootsCalculator.Location = new System.Drawing.Point(178, 401);
            this.RootsCalculator.Name = "RootsCalculator";
            this.RootsCalculator.Size = new System.Drawing.Size(219, 74);
            this.RootsCalculator.TabIndex = 0;
            this.RootsCalculator.Text = "Calculeaza";
            this.RootsCalculator.UseVisualStyleBackColor = false;
            this.RootsCalculator.Click += new System.EventHandler(this.RootsCalculator_Click);
            // 
            // Coefficient_a_re
            // 
            this.Coefficient_a_re.Location = new System.Drawing.Point(116, 107);
            this.Coefficient_a_re.Name = "Coefficient_a_re";
            this.Coefficient_a_re.Size = new System.Drawing.Size(125, 27);
            this.Coefficient_a_re.TabIndex = 1;
            // 
            // Coefficient_b_re
            // 
            this.Coefficient_b_re.Location = new System.Drawing.Point(116, 179);
            this.Coefficient_b_re.Name = "Coefficient_b_re";
            this.Coefficient_b_re.Size = new System.Drawing.Size(125, 27);
            this.Coefficient_b_re.TabIndex = 2;
            // 
            // Coefficient_c_re
            // 
            this.Coefficient_c_re.Location = new System.Drawing.Point(116, 253);
            this.Coefficient_c_re.Name = "Coefficient_c_re";
            this.Coefficient_c_re.Size = new System.Drawing.Size(125, 27);
            this.Coefficient_c_re.TabIndex = 3;
            // 
            // Coefficient_d_re
            // 
            this.Coefficient_d_re.Location = new System.Drawing.Point(116, 334);
            this.Coefficient_d_re.Name = "Coefficient_d_re";
            this.Coefficient_d_re.Size = new System.Drawing.Size(125, 27);
            this.Coefficient_d_re.TabIndex = 4;
            // 
            // Root1
            // 
            this.Root1.AutoSize = true;
            this.Root1.Location = new System.Drawing.Point(831, 107);
            this.Root1.Name = "Root1";
            this.Root1.Size = new System.Drawing.Size(67, 20);
            this.Root1.TabIndex = 5;
            this.Root1.Text = "Solutia 1";
            // 
            // Root2
            // 
            this.Root2.AutoSize = true;
            this.Root2.Location = new System.Drawing.Point(831, 172);
            this.Root2.Name = "Root2";
            this.Root2.Size = new System.Drawing.Size(67, 20);
            this.Root2.TabIndex = 6;
            this.Root2.Text = "Solutia 2";
            // 
            // Root3
            // 
            this.Root3.AutoSize = true;
            this.Root3.Location = new System.Drawing.Point(831, 239);
            this.Root3.Name = "Root3";
            this.Root3.Size = new System.Drawing.Size(67, 20);
            this.Root3.TabIndex = 7;
            this.Root3.Text = "Solutia 3";
            // 
            // Coefficient_d_Im
            // 
            this.Coefficient_d_Im.Location = new System.Drawing.Point(331, 334);
            this.Coefficient_d_Im.Name = "Coefficient_d_Im";
            this.Coefficient_d_Im.Size = new System.Drawing.Size(125, 27);
            this.Coefficient_d_Im.TabIndex = 11;
            // 
            // Coefficient_c_Im
            // 
            this.Coefficient_c_Im.Location = new System.Drawing.Point(331, 253);
            this.Coefficient_c_Im.Name = "Coefficient_c_Im";
            this.Coefficient_c_Im.Size = new System.Drawing.Size(125, 27);
            this.Coefficient_c_Im.TabIndex = 10;
            // 
            // Coefficient_b_Im
            // 
            this.Coefficient_b_Im.Location = new System.Drawing.Point(331, 179);
            this.Coefficient_b_Im.Name = "Coefficient_b_Im";
            this.Coefficient_b_Im.Size = new System.Drawing.Size(125, 27);
            this.Coefficient_b_Im.TabIndex = 9;
            // 
            // Coefficient_a_Im
            // 
            this.Coefficient_a_Im.Location = new System.Drawing.Point(331, 107);
            this.Coefficient_a_Im.Name = "Coefficient_a_Im";
            this.Coefficient_a_Im.Size = new System.Drawing.Size(125, 27);
            this.Coefficient_a_Im.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 573);
            this.Controls.Add(this.Coefficient_d_Im);
            this.Controls.Add(this.Coefficient_c_Im);
            this.Controls.Add(this.Coefficient_b_Im);
            this.Controls.Add(this.Coefficient_a_Im);
            this.Controls.Add(this.Root3);
            this.Controls.Add(this.Root2);
            this.Controls.Add(this.Root1);
            this.Controls.Add(this.Coefficient_d_re);
            this.Controls.Add(this.Coefficient_c_re);
            this.Controls.Add(this.Coefficient_b_re);
            this.Controls.Add(this.Coefficient_a_re);
            this.Controls.Add(this.RootsCalculator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RootsCalculator;
        private TextBox Coefficient_a_re;
        private TextBox Coefficient_b_re;
        private TextBox Coefficient_c_re;
        private TextBox Coefficient_d_re;
        private Label Root1;
        private Label Root2;
        private Label Root3;
        private TextBox Coefficient_d_Im;
        private TextBox Coefficient_c_Im;
        private TextBox Coefficient_b_Im;
        private TextBox Coefficient_a_Im;
    }
}