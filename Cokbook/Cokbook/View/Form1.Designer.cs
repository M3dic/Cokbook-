namespace Cokbook
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.register = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cook = new System.Windows.Forms.Button();
            this.chefName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.regPanel = new System.Windows.Forms.Panel();
            this.backBTN = new System.Windows.Forms.Button();
            this.reggender = new System.Windows.Forms.ComboBox();
            this.regemail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.regage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.regpassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.regname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.regPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(88, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cook);
            this.panel1.Controls.Add(this.chefName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Snow;
            this.panel1.Location = new System.Drawing.Point(331, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 314);
            this.panel1.TabIndex = 1;
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Tan;
            this.register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.register.Font = new System.Drawing.Font("Viner Hand ITC", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.DarkRed;
            this.register.Location = new System.Drawing.Point(177, 193);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(135, 41);
            this.register.TabIndex = 4;
            this.register.Text = "BECOME CHEF";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.Register_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(178, 146);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(265, 28);
            this.password.TabIndex = 2;
            this.password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // cook
            // 
            this.cook.BackColor = System.Drawing.Color.Tan;
            this.cook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cook.Font = new System.Drawing.Font("Viner Hand ITC", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cook.ForeColor = System.Drawing.Color.DarkRed;
            this.cook.Location = new System.Drawing.Point(318, 194);
            this.cook.Name = "cook";
            this.cook.Size = new System.Drawing.Size(125, 41);
            this.cook.TabIndex = 3;
            this.cook.Text = "COOK";
            this.cook.UseVisualStyleBackColor = false;
            this.cook.Click += new System.EventHandler(this.Cook_Click);
            // 
            // chefName
            // 
            this.chefName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chefName.Location = new System.Drawing.Point(178, 105);
            this.chefName.Name = "chefName";
            this.chefName.Size = new System.Drawing.Size(265, 28);
            this.chefName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chef";
            // 
            // regPanel
            // 
            this.regPanel.BackColor = System.Drawing.Color.Transparent;
            this.regPanel.Controls.Add(this.backBTN);
            this.regPanel.Controls.Add(this.reggender);
            this.regPanel.Controls.Add(this.regemail);
            this.regPanel.Controls.Add(this.label7);
            this.regPanel.Controls.Add(this.label6);
            this.regPanel.Controls.Add(this.regage);
            this.regPanel.Controls.Add(this.label5);
            this.regPanel.Controls.Add(this.regpassword);
            this.regPanel.Controls.Add(this.label3);
            this.regPanel.Controls.Add(this.button2);
            this.regPanel.Controls.Add(this.regname);
            this.regPanel.Controls.Add(this.label4);
            this.regPanel.ForeColor = System.Drawing.Color.Snow;
            this.regPanel.Location = new System.Drawing.Point(331, 94);
            this.regPanel.Name = "regPanel";
            this.regPanel.Size = new System.Drawing.Size(471, 314);
            this.regPanel.TabIndex = 5;
            this.regPanel.Visible = false;
            // 
            // backBTN
            // 
            this.backBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.backBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBTN.FlatAppearance.BorderSize = 0;
            this.backBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBTN.Font = new System.Drawing.Font("Viner Hand ITC", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBTN.ForeColor = System.Drawing.Color.Black;
            this.backBTN.Location = new System.Drawing.Point(30, 12);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(103, 49);
            this.backBTN.TabIndex = 11;
            this.backBTN.Text = "BACK";
            this.backBTN.UseVisualStyleBackColor = false;
            this.backBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // reggender
            // 
            this.reggender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reggender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reggender.FormattingEnabled = true;
            this.reggender.Items.AddRange(new object[] {
            "male",
            "female"});
            this.reggender.Location = new System.Drawing.Point(188, 138);
            this.reggender.Name = "reggender";
            this.reggender.Size = new System.Drawing.Size(254, 30);
            this.reggender.TabIndex = 7;
            // 
            // regemail
            // 
            this.regemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regemail.Location = new System.Drawing.Point(187, 173);
            this.regemail.Name = "regemail";
            this.regemail.Size = new System.Drawing.Size(255, 28);
            this.regemail.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 31);
            this.label7.TabIndex = 9;
            this.label7.Text = "Email*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Gender*";
            // 
            // regage
            // 
            this.regage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regage.Location = new System.Drawing.Point(188, 105);
            this.regage.Name = "regage";
            this.regage.Size = new System.Drawing.Size(255, 28);
            this.regage.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 31);
            this.label5.TabIndex = 5;
            this.label5.Text = "Age*";
            // 
            // regpassword
            // 
            this.regpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regpassword.Location = new System.Drawing.Point(187, 207);
            this.regpassword.Name = "regpassword";
            this.regpassword.Size = new System.Drawing.Size(255, 28);
            this.regpassword.TabIndex = 9;
            this.regpassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password*";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tan;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Viner Hand ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(187, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(255, 41);
            this.button2.TabIndex = 10;
            this.button2.Text = "JOIN CHEF FORM";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // regname
            // 
            this.regname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regname.Location = new System.Drawing.Point(188, 71);
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(255, 28);
            this.regname.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chef*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Viner Hand ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(791, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "V1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 520);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regPanel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COKBOOK - CATALOG FOR CHEF";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.regPanel.ResumeLayout(false);
            this.regPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel regPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button backBTN;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox reggender;
        public System.Windows.Forms.TextBox regemail;
        public System.Windows.Forms.TextBox regage;
        public System.Windows.Forms.TextBox regpassword;
        public System.Windows.Forms.TextBox regname;
        public System.Windows.Forms.TextBox password;
        public System.Windows.Forms.TextBox chefName;
    }
}

