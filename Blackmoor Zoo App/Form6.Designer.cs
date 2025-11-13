namespace Blackmoor_Zoo_App
{
    partial class bookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.minibtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerBooker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxPeople = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(81)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.minibtn);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 43);
            this.panel1.TabIndex = 4;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // minibtn
            // 
            this.minibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.closebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebtn.Location = new System.Drawing.Point(986, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(43, 43);
            this.closebtn.TabIndex = 9;
            this.closebtn.Text = "X";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.Location = new System.Drawing.Point(12, 600);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(133, 54);
            this.backbtn.TabIndex = 5;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(81)))), ((int)(((byte)(1)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePickerBooker);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonCheckout);
            this.panel2.Controls.Add(this.textBoxTotal);
            this.panel2.Controls.Add(this.textBoxPeople);
            this.panel2.Location = new System.Drawing.Point(12, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 545);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date of visit";
            // 
            // dateTimePickerBooker
            // 
            this.dateTimePickerBooker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBooker.Location = new System.Drawing.Point(33, 112);
            this.dateTimePickerBooker.Name = "dateTimePickerBooker";
            this.dateTimePickerBooker.Size = new System.Drawing.Size(207, 29);
            this.dateTimePickerBooker.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(713, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Persons";
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(0)))));
            this.buttonCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckout.Location = new System.Drawing.Point(267, 444);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(249, 54);
            this.buttonCheckout.TabIndex = 3;
            this.buttonCheckout.Text = "CheckOut";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotal.Location = new System.Drawing.Point(550, 469);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(418, 29);
            this.textBoxTotal.TabIndex = 2;
            // 
            // textBoxPeople
            // 
            this.textBoxPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPeople.Location = new System.Drawing.Point(350, 108);
            this.textBoxPeople.Name = "textBoxPeople";
            this.textBoxPeople.Size = new System.Drawing.Size(418, 29);
            this.textBoxPeople.TabIndex = 1;
            this.textBoxPeople.TextChanged += new System.EventHandler(this.textBoxPeople_TextChanged);
            // 
            // bookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(94)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1029, 666);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bookForm";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.bookForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button minibtn;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxPeople;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerBooker;
    }
}