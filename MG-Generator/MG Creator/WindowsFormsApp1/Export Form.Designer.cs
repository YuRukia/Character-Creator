﻿namespace MG_Creator
{
    partial class Export_Form
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
            this.exportTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // exportTextBox
            // 
            this.exportTextBox.Location = new System.Drawing.Point(13, 13);
            this.exportTextBox.Name = "exportTextBox";
            this.exportTextBox.Size = new System.Drawing.Size(573, 689);
            this.exportTextBox.TabIndex = 0;
            this.exportTextBox.Text = "";
            // 
            // Export_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 714);
            this.Controls.Add(this.exportTextBox);
            this.Name = "Export_Form";
            this.Text = "Export_Form";
            this.Load += new System.EventHandler(this.Export_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox exportTextBox;
    }
}