
namespace School_Managment_System___Davit_Kldiashvili
{
    partial class Dashboard
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
            this.Navbar = new System.Windows.Forms.Panel();
            this.Slidebar = new System.Windows.Forms.Panel();
            this.Content = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Navbar.SuspendLayout();
            this.Slidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Navbar
            // 
            this.Navbar.BackColor = System.Drawing.Color.Lime;
            this.Navbar.Controls.Add(this.label1);
            this.Navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navbar.Location = new System.Drawing.Point(0, 0);
            this.Navbar.Name = "Navbar";
            this.Navbar.Size = new System.Drawing.Size(904, 75);
            this.Navbar.TabIndex = 0;
            // 
            // Slidebar
            // 
            this.Slidebar.Controls.Add(this.Content);
            this.Slidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Slidebar.Location = new System.Drawing.Point(0, 75);
            this.Slidebar.Name = "Slidebar";
            this.Slidebar.Size = new System.Drawing.Size(400, 511);
            this.Slidebar.TabIndex = 1;
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(400, 511);
            this.Content.TabIndex = 1;
            // 
            // panel4
            // 
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Managment Sytem";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 586);
            this.ControlBox = false;
            this.Controls.Add(this.Slidebar);
            this.Controls.Add(this.Navbar);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Navbar.ResumeLayout(false);
            this.Navbar.PerformLayout();
            this.Slidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Navbar;
        public System.Windows.Forms.Panel Slidebar;
        public System.Windows.Forms.Panel Content;
        private System.Windows.Forms.Label label1;
    }
}

