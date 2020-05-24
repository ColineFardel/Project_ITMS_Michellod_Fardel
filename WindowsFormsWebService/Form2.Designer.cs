using System;
using System.Windows.Forms;

namespace WindowsFormsWebService
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
            this.buttonShowBalanceUsername = new System.Windows.Forms.Button();
            this.buttonShowBalanceUID = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonShowBalanceUsername
            // 
            this.buttonShowBalanceUsername.Location = new System.Drawing.Point(337, 46);
            this.buttonShowBalanceUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShowBalanceUsername.Name = "buttonShowBalanceUsername";
            this.buttonShowBalanceUsername.Size = new System.Drawing.Size(161, 35);
            this.buttonShowBalanceUsername.TabIndex = 2;
            this.buttonShowBalanceUsername.Text = "Show Balance";
            this.buttonShowBalanceUsername.UseVisualStyleBackColor = true;
            this.buttonShowBalanceUsername.Click += new System.EventHandler(this.buttonShowBalanceUsername_Click);
            // 
            // buttonShowBalanceUID
            // 
            this.buttonShowBalanceUID.Location = new System.Drawing.Point(337, 157);
            this.buttonShowBalanceUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonShowBalanceUID.Name = "buttonShowBalanceUID";
            this.buttonShowBalanceUID.Size = new System.Drawing.Size(161, 35);
            this.buttonShowBalanceUID.TabIndex = 3;
            this.buttonShowBalanceUID.Text = "Show Balance";
            this.buttonShowBalanceUID.UseVisualStyleBackColor = true;
            this.buttonShowBalanceUID.Click += new System.EventHandler(this.buttonShowBalanceUID_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(40, 50);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(148, 26);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(40, 166);
            this.textBoxUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(148, 26);
            this.textBoxUID.TabIndex = 5;
            this.textBoxUID.TextChanged += new System.EventHandler(this.textBoxUID_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(74, 25);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 20);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Location = new System.Drawing.Point(95, 141);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(38, 20);
            this.labelUID.TabIndex = 7;
            this.labelUID.Text = "UID";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 423);
            this.Controls.Add(this.labelUID);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.buttonShowBalanceUID);
            this.Controls.Add(this.buttonShowBalanceUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Show Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowBalanceUsername;
        private System.Windows.Forms.Button buttonShowBalanceUID;
        public System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUID;
    }


}


