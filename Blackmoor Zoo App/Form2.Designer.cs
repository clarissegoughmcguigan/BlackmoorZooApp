namespace Blackmoor_Zoo_App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.signinForm = new System.Windows.Forms.Panel();
            this.minibtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.signinbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.signinForm.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // signinForm
            // 
            this.signinForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(81)))), ((int)(((byte)(1)))));
            this.signinForm.Controls.Add(this.minibtn);
            this.signinForm.Controls.Add(this.closebtn);
            this.signinForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.signinForm.Location = new System.Drawing.Point(0, 0);
            this.signinForm.Name = "signinForm";
            this.signinForm.Size = new System.Drawing.Size(1029, 43);
            this.signinForm.TabIndex = 0;
            this.signinForm.Paint += new System.Windows.Forms.PaintEventHandler(this.signinForm_Paint);
            this.signinForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.signinForm_MouseDown);
            this.signinForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.signinForm_MouseMove);
            // 
            // minibtn
            // 
            this.minibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minibtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minibtn.ForeColor = System.Drawing.Color.Black;
            this.minibtn.Location = new System.Drawing.Point(933, 0);
            this.minibtn.Name = "minibtn";
            this.minibtn.Size = new System.Drawing.Size(47, 43);
            this.minibtn.TabIndex = 8;
            this.minibtn.Text = "-";
            this.minibtn.UseVisualStyleBackColor = true;
            this.minibtn.Click += new System.EventHandler(this.minibtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(986, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(43, 43);
            this.closebtn.TabIndex = 9;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(81)))), ((int)(((byte)(1)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.passTxt);
            this.panel2.Controls.Add(this.emailTxt);
            this.panel2.Controls.Add(this.registerbtn);
            this.panel2.Controls.Add(this.signinbtn);
            this.panel2.Location = new System.Drawing.Point(140, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(757, 460);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "Don\'t have account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(172, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 41);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // passTxt
            // 
            this.passTxt.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxt.Location = new System.Drawing.Point(179, 171);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(418, 20);
            this.passTxt.TabIndex = 3;
            this.passTxt.UseSystemPasswordChar = true;
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.Location = new System.Drawing.Point(179, 101);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(418, 20);
            this.emailTxt.TabIndex = 2;
            // 
            // registerbtn
            // 
            this.registerbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.registerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerbtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerbtn.Location = new System.Drawing.Point(248, 394);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(249, 54);
            this.registerbtn.TabIndex = 1;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = false;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // signinbtn
            // 
            this.signinbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.signinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinbtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinbtn.Location = new System.Drawing.Point(248, 285);
            this.signinbtn.Name = "signinbtn";
            this.signinbtn.Size = new System.Drawing.Size(249, 54);
            this.signinbtn.TabIndex = 0;
            this.signinbtn.Text = "Sign in";
            this.signinbtn.UseVisualStyleBackColor = false;
            this.signinbtn.Click += new System.EventHandler(this.signinbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 600);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(133, 54);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1029, 666);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.signinForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.signinForm.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel signinForm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button signinbtn;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button minibtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}