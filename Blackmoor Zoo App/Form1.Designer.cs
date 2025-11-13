namespace Blackmoor_Zoo_App
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.closebtn = new System.Windows.Forms.Button();
            this.minibtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toAnimalbtn = new System.Windows.Forms.Button();
            this.toFacilitiesbtn = new System.Windows.Forms.Button();
            this.toBookbtn = new System.Windows.Forms.Button();
            this.toAccountbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(81)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Controls.Add(this.minibtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 43);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // closebtn
            // 
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(986, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(43, 43);
            this.closebtn.TabIndex = 8;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // minibtn
            // 
            this.minibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minibtn.ForeColor = System.Drawing.Color.Black;
            this.minibtn.Location = new System.Drawing.Point(933, 0);
            this.minibtn.Name = "minibtn";
            this.minibtn.Size = new System.Drawing.Size(47, 43);
            this.minibtn.TabIndex = 7;
            this.minibtn.Text = "-";
            this.minibtn.UseVisualStyleBackColor = true;
            this.minibtn.Click += new System.EventHandler(this.minibtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(81)))), ((int)(((byte)(1)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 460);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(81)))), ((int)(((byte)(1)))));
            this.panel3.Location = new System.Drawing.Point(720, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 460);
            this.panel3.TabIndex = 2;
            // 
            // toAnimalbtn
            // 
            this.toAnimalbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.toAnimalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toAnimalbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAnimalbtn.Location = new System.Drawing.Point(385, 312);
            this.toAnimalbtn.Name = "toAnimalbtn";
            this.toAnimalbtn.Size = new System.Drawing.Size(249, 94);
            this.toAnimalbtn.TabIndex = 3;
            this.toAnimalbtn.Text = "Meet the animals";
            this.toAnimalbtn.UseVisualStyleBackColor = false;
            this.toAnimalbtn.Click += new System.EventHandler(this.toAnimalbtn_Click);
            // 
            // toFacilitiesbtn
            // 
            this.toFacilitiesbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.toFacilitiesbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toFacilitiesbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toFacilitiesbtn.Location = new System.Drawing.Point(385, 437);
            this.toFacilitiesbtn.Name = "toFacilitiesbtn";
            this.toFacilitiesbtn.Size = new System.Drawing.Size(249, 54);
            this.toFacilitiesbtn.TabIndex = 4;
            this.toFacilitiesbtn.Text = "Facilities";
            this.toFacilitiesbtn.UseVisualStyleBackColor = false;
            this.toFacilitiesbtn.Click += new System.EventHandler(this.toFacilitiesbtn_Click);
            // 
            // toBookbtn
            // 
            this.toBookbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.toBookbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toBookbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toBookbtn.Location = new System.Drawing.Point(385, 514);
            this.toBookbtn.Name = "toBookbtn";
            this.toBookbtn.Size = new System.Drawing.Size(249, 54);
            this.toBookbtn.TabIndex = 5;
            this.toBookbtn.Text = "Book now";
            this.toBookbtn.UseVisualStyleBackColor = false;
            this.toBookbtn.Click += new System.EventHandler(this.toBookbtn_Click);
            // 
            // toAccountbtn
            // 
            this.toAccountbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.toAccountbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toAccountbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toAccountbtn.Location = new System.Drawing.Point(385, 600);
            this.toAccountbtn.Name = "toAccountbtn";
            this.toAccountbtn.Size = new System.Drawing.Size(249, 54);
            this.toAccountbtn.TabIndex = 6;
            this.toAccountbtn.Text = "Account";
            this.toAccountbtn.UseVisualStyleBackColor = false;
            this.toAccountbtn.Click += new System.EventHandler(this.toAccountbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(326, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 157);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price for admission is £10.";
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1029, 666);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toAccountbtn);
            this.Controls.Add(this.toBookbtn);
            this.Controls.Add(this.toFacilitiesbtn);
            this.Controls.Add(this.toAnimalbtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeForm";
            this.Text = "Blackmoor Zoo";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button toAnimalbtn;
        private System.Windows.Forms.Button toFacilitiesbtn;
        private System.Windows.Forms.Button toBookbtn;
        private System.Windows.Forms.Button toAccountbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button minibtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

