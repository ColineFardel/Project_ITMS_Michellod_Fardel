using System;
using System.Windows.Forms;

namespace WindowsFormsWebService
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
            this.buttonAddMoneyUsername = new System.Windows.Forms.Button();
            this.textBoxAmountUsername = new System.Windows.Forms.TextBox();
            this.buttonAddMoneyUID = new System.Windows.Forms.Button();
            this.textBoxAmountUID = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddMoneyUsername
            // 
            this.buttonAddMoneyUsername.Location = new System.Drawing.Point(440, 41);
            this.buttonAddMoneyUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddMoneyUsername.Name = "buttonAddMoneyUsername";
            this.buttonAddMoneyUsername.Size = new System.Drawing.Size(112, 35);
            this.buttonAddMoneyUsername.TabIndex = 2;
            this.buttonAddMoneyUsername.Text = "Add Money";
            this.buttonAddMoneyUsername.UseVisualStyleBackColor = true;
            this.buttonAddMoneyUsername.Click += new System.EventHandler(this.buttonAddMoneyUsername_Click);
            // 
            // textBoxAmountUsername
            // 
            this.textBoxAmountUsername.Location = new System.Drawing.Point(244, 50);
            this.textBoxAmountUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAmountUsername.Name = "textBoxAmountUsername";
            this.textBoxAmountUsername.Size = new System.Drawing.Size(148, 26);
            this.textBoxAmountUsername.TabIndex = 1;
            this.textBoxAmountUsername.Text = "Amount";
            // 
            // buttonAddMoneyUID
            // 
            this.buttonAddMoneyUID.Location = new System.Drawing.Point(440, 157);
            this.buttonAddMoneyUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAddMoneyUID.Name = "buttonAddMoneyUID";
            this.buttonAddMoneyUID.Size = new System.Drawing.Size(112, 35);
            this.buttonAddMoneyUID.TabIndex = 3;
            this.buttonAddMoneyUID.Text = "Add Money";
            this.buttonAddMoneyUID.UseVisualStyleBackColor = true;
            this.buttonAddMoneyUID.Click += new System.EventHandler(this.buttonAddMoneyUID_Click);
            // 
            // textBoxAmountUID
            // 
            this.textBoxAmountUID.Location = new System.Drawing.Point(244, 166);
            this.textBoxAmountUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAmountUID.Name = "textBoxAmountUID";
            this.textBoxAmountUID.Size = new System.Drawing.Size(148, 26);
            this.textBoxAmountUID.TabIndex = 4;
            this.textBoxAmountUID.Text = "Amount";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(40, 50);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(148, 26);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "Username";
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(40, 166);
            this.textBoxUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(148, 26);
            this.textBoxUID.TabIndex = 5;
            this.textBoxUID.Text = "UID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 423);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.textBoxAmountUID);
            this.Controls.Add(this.buttonAddMoneyUID);
            this.Controls.Add(this.buttonAddMoneyUsername);
            this.Controls.Add(this.textBoxAmountUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMoneyUsername;
        private System.Windows.Forms.Button buttonAddMoneyUID;
        private System.Windows.Forms.TextBox textBoxAmountUsername;
        private System.Windows.Forms.TextBox textBoxAmountUID;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxUID;
    }


}


