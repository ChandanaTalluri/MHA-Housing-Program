﻿namespace MHA_UserInterface
{
    partial class Update_CensusTrack
    {
        private System.ComponentModel.IContainer components = null;

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
            this.btn_Update = new System.Windows.Forms.Button();
            this.lbl_MedianIncome = new System.Windows.Forms.Label();
            this.lbl_TractID = new System.Windows.Forms.Label();
            this.txt_TractID = new System.Windows.Forms.TextBox();
            this.txt_MedianIncome = new System.Windows.Forms.TextBox();
            this.btn_Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(12, 91);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(236, 23);
            this.btn_Update.TabIndex = 27;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_MedianIncome
            // 
            this.lbl_MedianIncome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MedianIncome.Location = new System.Drawing.Point(12, 65);
            this.lbl_MedianIncome.Name = "lbl_MedianIncome";
            this.lbl_MedianIncome.Size = new System.Drawing.Size(130, 20);
            this.lbl_MedianIncome.TabIndex = 41;
            this.lbl_MedianIncome.Text = "Median Income:";
            this.lbl_MedianIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_TractID
            // 
            this.lbl_TractID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TractID.Location = new System.Drawing.Point(12, 9);
            this.lbl_TractID.Name = "lbl_TractID";
            this.lbl_TractID.Size = new System.Drawing.Size(130, 20);
            this.lbl_TractID.TabIndex = 40;
            this.lbl_TractID.Text = "Tract_ID:";
            this.lbl_TractID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_TractID
            // 
            this.txt_TractID.Location = new System.Drawing.Point(148, 9);
            this.txt_TractID.Name = "txt_TractID";
            this.txt_TractID.Size = new System.Drawing.Size(100, 20);
            this.txt_TractID.TabIndex = 33;
            // 
            // txt_MedianIncome
            // 
            this.txt_MedianIncome.Location = new System.Drawing.Point(148, 65);
            this.txt_MedianIncome.Name = "txt_MedianIncome";
            this.txt_MedianIncome.Size = new System.Drawing.Size(100, 20);
            this.txt_MedianIncome.TabIndex = 32;
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 120);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(236, 23);
            this.btn_Back.TabIndex = 42;
            this.btn_Back.Text = "Back to main update form";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // Update_CensusTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 151);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.lbl_MedianIncome);
            this.Controls.Add(this.lbl_TractID);
            this.Controls.Add(this.txt_TractID);
            this.Controls.Add(this.txt_MedianIncome);
            this.Controls.Add(this.btn_Update);
            this.MaximumSize = new System.Drawing.Size(275, 190);
            this.MinimumSize = new System.Drawing.Size(275, 190);
            this.Name = "Update_CensusTrack";
            this.Text = "Update Census Track";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_MedianIncome;
        private System.Windows.Forms.Label lbl_TractID;
        private System.Windows.Forms.TextBox txt_TractID;
        private System.Windows.Forms.TextBox txt_MedianIncome;
        private System.Windows.Forms.Button btn_Back;
    }
}