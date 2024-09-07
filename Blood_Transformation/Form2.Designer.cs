namespace Blood_Transformation
{
    partial class Form2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_con_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.next_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.back_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Blood_Transformation.Properties.Resources.drone_final;
            this.pictureBox1.Location = new System.Drawing.Point(15, 116);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(347, 338);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Silver;
            this.txt_email.Location = new System.Drawing.Point(372, 117);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(396, 32);
            this.txt_email.TabIndex = 2;
            this.txt_email.Text = "i.e johndoe@gmail.com";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Location = new System.Drawing.Point(372, 220);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(396, 32);
            this.txt_password.TabIndex = 2;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_con_password
            // 
            this.txt_con_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_con_password.ForeColor = System.Drawing.Color.Black;
            this.txt_con_password.Location = new System.Drawing.Point(372, 339);
            this.txt_con_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_con_password.Name = "txt_con_password";
            this.txt_con_password.Size = new System.Drawing.Size(396, 32);
            this.txt_con_password.TabIndex = 2;
            this.txt_con_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password (at least 8 characters)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password";
            // 
            // next_button
            // 
            this.next_button.Depth = 0;
            this.next_button.Location = new System.Drawing.Point(372, 437);
            this.next_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.next_button.Name = "next_button";
            this.next_button.Primary = true;
            this.next_button.Size = new System.Drawing.Size(188, 39);
            this.next_button.TabIndex = 7;
            this.next_button.Text = "next";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.next_button_Click);
            // 
            // back_button
            // 
            this.back_button.Depth = 0;
            this.back_button.Location = new System.Drawing.Point(581, 437);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_button.Name = "back_button";
            this.back_button.Primary = true;
            this.back_button.Size = new System.Drawing.Size(187, 39);
            this.back_button.TabIndex = 8;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(372, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(129, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(368, 376);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(181, 21);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Show Confirm Password";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_con_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "SIGN UP";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_con_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MaterialSkin.Controls.MaterialRaisedButton next_button;
        private MaterialSkin.Controls.MaterialRaisedButton back_button;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}