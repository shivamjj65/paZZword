
namespace paZZword
{
    partial class paZZword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paZZword));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Cont = new System.Windows.Forms.Button();
            this.passInput = new System.Windows.Forms.RichTextBox();
            this.userInput = new System.Windows.Forms.RichTextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.Bar = new System.Windows.Forms.Panel();
            this.min = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MainPanel.Controls.Add(this.Cont);
            this.MainPanel.Controls.Add(this.passInput);
            this.MainPanel.Controls.Add(this.userInput);
            this.MainPanel.Controls.Add(this.Password);
            this.MainPanel.Controls.Add(this.Username);
            this.MainPanel.Controls.Add(this.SignIn);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1024, 640);
            this.MainPanel.TabIndex = 1;
            // 
            // Cont
            // 
            this.Cont.BackColor = System.Drawing.Color.Transparent;
            this.Cont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cont.FlatAppearance.BorderSize = 0;
            this.Cont.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Cont.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Cont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cont.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cont.ForeColor = System.Drawing.Color.Transparent;
            this.Cont.Location = new System.Drawing.Point(444, 546);
            this.Cont.Name = "Cont";
            this.Cont.Size = new System.Drawing.Size(158, 27);
            this.Cont.TabIndex = 16;
            this.Cont.Text = "Continue Without SignIn";
            this.Cont.UseVisualStyleBackColor = false;
            this.Cont.Click += new System.EventHandler(this.cont_Click);
            // 
            // passInput
            // 
            this.passInput.BackColor = System.Drawing.Color.DimGray;
            this.passInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passInput.EnableAutoDragDrop = true;
            this.passInput.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passInput.ForeColor = System.Drawing.Color.White;
            this.passInput.Location = new System.Drawing.Point(625, 374);
            this.passInput.Name = "passInput";
            this.passInput.Size = new System.Drawing.Size(150, 25);
            this.passInput.TabIndex = 15;
            this.passInput.Text = "";
            // 
            // userInput
            // 
            this.userInput.BackColor = System.Drawing.Color.DimGray;
            this.userInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInput.EnableAutoDragDrop = true;
            this.userInput.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userInput.ForeColor = System.Drawing.Color.White;
            this.userInput.Location = new System.Drawing.Point(323, 375);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(150, 25);
            this.userInput.TabIndex = 14;
            this.userInput.Text = "";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.BackColor = System.Drawing.Color.Transparent;
            this.Password.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.Location = new System.Drawing.Point(530, 375);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(89, 25);
            this.Password.TabIndex = 13;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.BackColor = System.Drawing.Color.Transparent;
            this.Username.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(222, 375);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(95, 25);
            this.Username.TabIndex = 12;
            this.Username.Text = "Username";
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.Transparent;
            this.SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.Transparent;
            this.SignIn.Location = new System.Drawing.Point(443, 415);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(152, 83);
            this.SignIn.TabIndex = 1;
            this.SignIn.Text = "Sign In";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(987, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(25, 25);
            this.close.TabIndex = 2;
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Bar.Controls.Add(this.min);
            this.Bar.Controls.Add(this.close);
            this.Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(1024, 30);
            this.Bar.TabIndex = 3;
            this.Bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseDown);
            this.Bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseMove);
            this.Bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Bar_MouseUp);
            // 
            // min
            // 
            this.min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.min.FlatAppearance.BorderSize = 0;
            this.min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.min.Image = ((System.Drawing.Image)(resources.GetObject("min.Image")));
            this.min.Location = new System.Drawing.Point(956, 3);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(25, 25);
            this.min.TabIndex = 3;
            this.min.UseVisualStyleBackColor = false;
            // 
            // paZZword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.Bar);
            this.Controls.Add(this.MainPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "paZZword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paZZword : Your Password Manager";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.Bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.RichTextBox passInput;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Button Cont;
        private System.Windows.Forms.RichTextBox userInput;
    }
}

