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
            this.buttonGetStudentUsername = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxUID = new System.Windows.Forms.TextBox();
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.buttonGetStudentUID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetStudentUsername
            // 
            this.buttonGetStudentUsername.Location = new System.Drawing.Point(354, 52);
            this.buttonGetStudentUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetStudentUsername.Name = "buttonGetStudent";
            this.buttonGetStudentUsername.Size = new System.Drawing.Size(112, 35);
            this.buttonGetStudentUsername.TabIndex = 2;
            this.buttonGetStudentUsername.Text = "Get Student";
            this.buttonGetStudentUsername.UseVisualStyleBackColor = true;
            this.buttonGetStudentUsername.Click += new System.EventHandler(this.buttonGetStudentUsername_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(69, 56);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(148, 26);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.Text = "username";
            // 
            // textBoxUID
            // 
            this.textBoxUID.Location = new System.Drawing.Point(69, 159);
            this.textBoxUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxUID.Name = "textBoxUID";
            this.textBoxUID.Size = new System.Drawing.Size(148, 26);
            this.textBoxUID.TabIndex = 1;
            this.textBoxUID.Text = "uid";
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(228, 309);
            this.buttonGetAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(112, 35);
            this.buttonGetAll.TabIndex = 3;
            this.buttonGetAll.Text = "Get all students";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            // 
            // buttonGetStudentUID
            // 
            this.buttonGetStudentUID.Location = new System.Drawing.Point(354, 150);
            this.buttonGetStudentUID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGetStudentUID.Name = "buttonGetStudentUID";
            this.buttonGetStudentUID.Size = new System.Drawing.Size(112, 35);
            this.buttonGetStudentUID.TabIndex = 4;
            this.buttonGetStudentUID.Text = "Get Student";
            this.buttonGetStudentUID.UseVisualStyleBackColor = true;
            this.buttonGetStudentUID.Click += new System.EventHandler(this.buttonGetStudentUID_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 423);
            this.Controls.Add(this.buttonGetStudentUID);
            this.Controls.Add(this.buttonGetStudentUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxUID);
            this.Controls.Add(this.buttonGetAll);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetStudentUsername;
        private System.Windows.Forms.Button buttonGetStudentUID;
        private System.Windows.Forms.Button buttonGetAll;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxUID;
     
    }


}


