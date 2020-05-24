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
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelUID = new System.Windows.Forms.Label();
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
            this.textBoxAmountUsername.Location = new System.Drawing.Point(253, 50);
            this.textBoxAmountUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxAmountUsername.Name = "textBoxAmountUsername";
            this.textBoxAmountUsername.Size = new System.Drawing.Size(148, 26);
            this.textBoxAmountUsername.TabIndex = 1;
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
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(279, 25);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(65, 20);
            this.labelAmount.TabIndex = 0;
            this.labelAmount.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amount";
            // 
            // labelUID
            // 
            this.labelUID.AutoSize = true;
            this.labelUID.Location = new System.Drawing.Point(74, 141);
            this.labelUID.Name = "labelUID";
            this.labelUID.Size = new System.Drawing.Size(38, 20);
            this.labelUID.TabIndex = 7;
            this.labelUID.Text = "UID";
            this.labelUID.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 423);
            this.Controls.Add(this.labelUID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.textBoxAmountUID);
            this.Controls.Add(this.buttonAddMoneyUID);
            this.Controls.Add(this.buttonAddMoneyUsername);
            this.Controls.Add(this.textBoxAmountUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelAmount);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Add Money";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMoneyUsername;
        private System.Windows.Forms.Button buttonAddMoneyUID;
        public System.Windows.Forms.TextBox textBoxAmountUsername;
        public System.Windows.Forms.TextBox textBoxAmountUID;
        public System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxUID;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAmount;
        private Label label1;
        private System.Windows.Forms.Label labelUID;
    }


}


