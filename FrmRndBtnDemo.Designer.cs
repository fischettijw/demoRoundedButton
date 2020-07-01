namespace demoRoundedButton
{
    partial class FrmRndBtnDemo
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
            this.BtnRndDemo = new demoRoundedButton.RoundedButton();
            this.BtnRndAnother = new demoRoundedButton.RoundedButton();
            this.SuspendLayout();
            // 
            // BtnRndDemo
            // 
            this.BtnRndDemo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BtnRndDemo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnRndDemo.FlatAppearance.BorderSize = 10;
            this.BtnRndDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRndDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRndDemo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRndDemo.Location = new System.Drawing.Point(402, 45);
            this.BtnRndDemo.Name = "BtnRndDemo";
            this.BtnRndDemo.Size = new System.Drawing.Size(213, 62);
            this.BtnRndDemo.TabIndex = 0;
            this.BtnRndDemo.Text = "Click";
            this.BtnRndDemo.UseVisualStyleBackColor = false;
            this.BtnRndDemo.Click += new System.EventHandler(this.BtnRndDemo_Click);
            // 
            // BtnRndAnother
            // 
            this.BtnRndAnother.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnRndAnother.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.BtnRndAnother.FlatAppearance.BorderSize = 10;
            this.BtnRndAnother.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRndAnother.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRndAnother.Location = new System.Drawing.Point(355, 235);
            this.BtnRndAnother.Name = "BtnRndAnother";
            this.BtnRndAnother.Size = new System.Drawing.Size(180, 180);
            this.BtnRndAnother.TabIndex = 1;
            this.BtnRndAnother.Text = "Hello";
            this.BtnRndAnother.UseVisualStyleBackColor = false;
            this.BtnRndAnother.Click += new System.EventHandler(this.BtnRndAnother_Click);
            // 
            // FrmRndBtnDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRndAnother);
            this.Controls.Add(this.BtnRndDemo);
            this.Name = "FrmRndBtnDemo";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedButton BtnRndDemo;
        private RoundedButton BtnRndAnother;
    }
}

