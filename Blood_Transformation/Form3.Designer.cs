﻿namespace Blood_Transformation
{
    partial class order
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
            this.txt_patients_fname = new System.Windows.Forms.TextBox();
            this.txt_patients_lname = new System.Windows.Forms.TextBox();
            this.cont = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button = new MaterialSkin.Controls.MaterialRaisedButton();
            this.continue_button = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Blood_Transformation.Properties.Resources.drone_final;
            this.pictureBox1.Location = new System.Drawing.Point(13, 86);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 331);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txt_patients_fname
            // 
            this.txt_patients_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patients_fname.ForeColor = System.Drawing.Color.Silver;
            this.txt_patients_fname.Location = new System.Drawing.Point(364, 142);
            this.txt_patients_fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_patients_fname.Name = "txt_patients_fname";
            this.txt_patients_fname.Size = new System.Drawing.Size(396, 32);
            this.txt_patients_fname.TabIndex = 1;
            this.txt_patients_fname.Text = "i.e john";
            this.txt_patients_fname.Enter += new System.EventHandler(this.txt_patients_fname_Enter);
            this.txt_patients_fname.Leave += new System.EventHandler(this.txt_patients_fname_Leave);
            // 
            // txt_patients_lname
            // 
            this.txt_patients_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_patients_lname.ForeColor = System.Drawing.Color.Silver;
            this.txt_patients_lname.Location = new System.Drawing.Point(367, 260);
            this.txt_patients_lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_patients_lname.Name = "txt_patients_lname";
            this.txt_patients_lname.Size = new System.Drawing.Size(396, 32);
            this.txt_patients_lname.TabIndex = 1;
            this.txt_patients_lname.Text = "i.e doe";
            this.txt_patients_lname.Enter += new System.EventHandler(this.txt_patients_lname_Enter);
            this.txt_patients_lname.Leave += new System.EventHandler(this.txt_patients_lname_Leave);
            // 
            // cont
            // 
            this.cont.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cont.Location = new System.Drawing.Point(365, 347);
            this.cont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cont.Name = "cont";
            this.cont.Size = new System.Drawing.Size(171, 37);
            this.cont.TabIndex = 2;
            this.cont.Text = "CONTINUE";
            this.cont.UseVisualStyleBackColor = true;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(589, 350);
            this.back.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(168, 37);
            this.back.TabIndex = 2;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Patient\'s First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient\'s Last Name";
            // 
            // back_button
            // 
            this.back_button.Depth = 0;
            this.back_button.Location = new System.Drawing.Point(588, 348);
            this.back_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.back_button.Name = "back_button";
            this.back_button.Primary = true;
            this.back_button.Size = new System.Drawing.Size(168, 37);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // continue_button
            // 
            this.continue_button.Depth = 0;
            this.continue_button.Location = new System.Drawing.Point(365, 348);
            this.continue_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.continue_button.MouseState = MaterialSkin.MouseState.HOVER;
            this.continue_button.Name = "continue_button";
            this.continue_button.Primary = true;
            this.continue_button.Size = new System.Drawing.Size(168, 37);
            this.continue_button.TabIndex = 8;
            this.continue_button.Text = "Continue";
            this.continue_button.UseVisualStyleBackColor = true;
            this.continue_button.Click += new System.EventHandler(this.continue_button_Click);
            // 
            // order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 427);
            this.Controls.Add(this.continue_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.cont);
            this.Controls.Add(this.txt_patients_fname);
            this.Controls.Add(this.txt_patients_lname);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "order";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_patients_fname;
        private System.Windows.Forms.TextBox txt_patients_lname;
        private System.Windows.Forms.Button cont;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialRaisedButton back_button;
        private MaterialSkin.Controls.MaterialRaisedButton continue_button;
    }
}