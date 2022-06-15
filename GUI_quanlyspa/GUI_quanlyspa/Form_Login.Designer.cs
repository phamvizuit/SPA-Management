
namespace GUI_quanlyspa
{
    partial class Form_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.label4 = new System.Windows.Forms.Label();
            this.remember_cb = new Bunifu.Framework.UI.BunifuCheckbox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.exit_lb = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.password_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.login_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user_tb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Login";
            // 
            // remember_cb
            // 
            this.remember_cb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(145)))), ((int)(((byte)(50)))));
            this.remember_cb.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.remember_cb.Checked = true;
            this.remember_cb.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(145)))), ((int)(((byte)(50)))));
            this.remember_cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.remember_cb.ForeColor = System.Drawing.Color.White;
            this.remember_cb.Location = new System.Drawing.Point(435, 361);
            this.remember_cb.Name = "remember_cb";
            this.remember_cb.Size = new System.Drawing.Size(20, 20);
            this.remember_cb.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Gray;
            this.textBox3.Location = new System.Drawing.Point(458, 362);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 24);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Remember Me";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 16;
            this.bunifuElipse1.TargetControl = this;
            // 
            // exit_lb
            // 
            this.exit_lb.AutoSize = true;
            this.exit_lb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_lb.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.exit_lb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(145)))), ((int)(((byte)(50)))));
            this.exit_lb.Location = new System.Drawing.Point(772, 5);
            this.exit_lb.Name = "exit_lb";
            this.exit_lb.Size = new System.Drawing.Size(24, 22);
            this.exit_lb.TabIndex = 17;
            this.exit_lb.Text = "X";
            this.exit_lb.Click += new System.EventHandler(this.exit_lb_Click);
            // 
            // password_tb
            // 
            this.password_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_tb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.password_tb.HintForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.password_tb.HintText = "Type Your Password";
            this.password_tb.isPassword = true;
            this.password_tb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(234)))), ((int)(((byte)(102)))));
            this.password_tb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(145)))), ((int)(((byte)(50)))));
            this.password_tb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(234)))), ((int)(((byte)(102)))));
            this.password_tb.LineThickness = 4;
            this.password_tb.Location = new System.Drawing.Point(413, 313);
            this.password_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(250, 40);
            this.password_tb.TabIndex = 19;
            this.password_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.password_tb.OnValueChanged += new System.EventHandler(this.password_tb_OnValueChanged);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.BackgroundImage = global::GUI_quanlyspa.Properties.Resources.login_button;
            this.login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Location = new System.Drawing.Point(488, 402);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(101, 41);
            this.login_button.TabIndex = 16;
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI_quanlyspa.Properties.Resources.user_logo1;
            this.pictureBox2.Location = new System.Drawing.Point(475, 60);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(120, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::GUI_quanlyspa.Properties.Resources.leftside_panel1;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 540);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::GUI_quanlyspa.Properties.Resources.lotus;
            this.pictureBox1.Location = new System.Drawing.Point(75, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Software";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Spa Management";
            // 
            // user_tb
            // 
            this.user_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.user_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.user_tb.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_tb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.user_tb.HintForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.user_tb.HintText = "Username";
            this.user_tb.isPassword = false;
            this.user_tb.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(234)))), ((int)(((byte)(102)))));
            this.user_tb.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(145)))), ((int)(((byte)(50)))));
            this.user_tb.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(234)))), ((int)(((byte)(102)))));
            this.user_tb.LineThickness = 4;
            this.user_tb.Location = new System.Drawing.Point(413, 259);
            this.user_tb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.user_tb.Name = "user_tb";
            this.user_tb.Size = new System.Drawing.Size(250, 44);
            this.user_tb.TabIndex = 18;
            this.user_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.user_tb);
            this.Controls.Add(this.exit_lb);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.remember_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCheckbox remember_cb;
        private System.Windows.Forms.TextBox textBox3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button login_button;
        private Bunifu.Framework.UI.BunifuCustomLabel exit_lb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password_tb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox user_tb;
    }
}