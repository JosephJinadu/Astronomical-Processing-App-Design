﻿namespace Astronomical_Processing
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
            this.lstBox = new System.Windows.Forms.ListBox();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.BtnSort = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBox
            // 
            this.lstBox.FormattingEnabled = true;
            this.lstBox.ItemHeight = 25;
            this.lstBox.Location = new System.Drawing.Point(100, 29);
            this.lstBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstBox.Name = "lstBox";
            this.lstBox.Size = new System.Drawing.Size(532, 654);
            this.lstBox.TabIndex = 0;
            this.lstBox.SelectedIndexChanged += new System.EventHandler(this.lstBox_SelectedIndexChanged);
            this.lstBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstBox_MouseDown);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(100, 748);
            this.BtnSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(536, 173);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "Search Button";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(100, 698);
            this.txtBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(532, 31);
            this.txtBox.TabIndex = 2;
                        // 
            // BtnSort
            // 
            this.BtnSort.Location = new System.Drawing.Point(648, 29);
            this.BtnSort.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnSort.Name = "BtnSort";
            this.BtnSort.Size = new System.Drawing.Size(536, 173);
            this.BtnSort.TabIndex = 3;
            this.BtnSort.Text = "Sort Button";
            this.BtnSort.UseVisualStyleBackColor = true;
            this.BtnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(648, 271);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(536, 173);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Edit Button";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(648, 513);
            this.BtnGenerate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(536, 173);
            this.BtnGenerate.TabIndex = 5;
            this.BtnGenerate.Text = "Generate Random Numbers";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 1156);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSort);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.lstBox);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button BtnSort;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnGenerate;
    }
}

