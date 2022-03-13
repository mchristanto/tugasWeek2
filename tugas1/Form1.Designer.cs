namespace tugas1
{
    partial class FormAturWarna
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
            this.btnProses = new System.Windows.Forms.Button();
            this.tBoxInput = new System.Windows.Forms.TextBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProses
            // 
            this.btnProses.Location = new System.Drawing.Point(12, 66);
            this.btnProses.Name = "btnProses";
            this.btnProses.Size = new System.Drawing.Size(75, 23);
            this.btnProses.TabIndex = 0;
            this.btnProses.Text = "Proses";
            this.btnProses.UseVisualStyleBackColor = true;
            this.btnProses.Click += new System.EventHandler(this.btnProses_Click);
            // 
            // tBoxInput
            // 
            this.tBoxInput.Location = new System.Drawing.Point(12, 27);
            this.tBoxInput.Name = "tBoxInput";
            this.tBoxInput.Size = new System.Drawing.Size(329, 23);
            this.tBoxInput.TabIndex = 1;
            this.tBoxInput.TextChanged += new System.EventHandler(this.tBoxInput_TextChanged);
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(12, 9);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(65, 15);
            this.lbl_input.TabIndex = 2;
            this.lbl_input.Text = "Input Data:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Location = new System.Drawing.Point(12, 129);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(68, 21);
            this.lblOutput.TabIndex = 3;
            this.lblOutput.Text = "[EMPTY]";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // FormAturWarna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(353, 186);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.tBoxInput);
            this.Controls.Add(this.btnProses);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormAturWarna";
            this.Text = "Form Pengaturan Warna";
            this.Load += new System.EventHandler(this.FormAturWarna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnProses;
        private TextBox tBoxInput;
        private Label lbl_input;
        private Label lblOutput;
    }
}