
namespace PharmacyManagement
{
    partial class Homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.homepageTitle = new System.Windows.Forms.Label();
            this.homeLoginButton = new System.Windows.Forms.Button();
            this.homeExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // homepageTitle
            // 
            this.homepageTitle.AutoSize = true;
            this.homepageTitle.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homepageTitle.Location = new System.Drawing.Point(123, 21);
            this.homepageTitle.Name = "homepageTitle";
            this.homepageTitle.Size = new System.Drawing.Size(428, 38);
            this.homepageTitle.TabIndex = 0;
            this.homepageTitle.Text = "Pharmacy Management System";
            this.homepageTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // homeLoginButton
            // 
            this.homeLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.homeLoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLoginButton.Location = new System.Drawing.Point(451, 158);
            this.homeLoginButton.Name = "homeLoginButton";
            this.homeLoginButton.Size = new System.Drawing.Size(148, 61);
            this.homeLoginButton.TabIndex = 1;
            this.homeLoginButton.Text = "LOGIN";
            this.homeLoginButton.UseVisualStyleBackColor = false;
            this.homeLoginButton.Click += new System.EventHandler(this.homeLoginButton_Click);
            // 
            // homeExitButton
            // 
            this.homeExitButton.BackColor = System.Drawing.Color.Pink;
            this.homeExitButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeExitButton.Location = new System.Drawing.Point(451, 250);
            this.homeExitButton.Name = "homeExitButton";
            this.homeExitButton.Size = new System.Drawing.Size(148, 61);
            this.homeExitButton.TabIndex = 2;
            this.homeExitButton.Text = "EXIT";
            this.homeExitButton.UseVisualStyleBackColor = false;
            this.homeExitButton.Click += new System.EventHandler(this.homeExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(195)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(654, 457);
            this.Controls.Add(this.homeLoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.homeExitButton);
            this.Controls.Add(this.homepageTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Homepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homepage";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Homepage_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label homepageTitle;
        private System.Windows.Forms.Button homeLoginButton;
        private System.Windows.Forms.Button homeExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}