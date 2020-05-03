﻿namespace MHA_UserInterface
{
    partial class Insert
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
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.rbBuilding = new System.Windows.Forms.RadioButton();
            this.rbCensus = new System.Windows.Forms.RadioButton();
            this.rbMortgager = new System.Windows.Forms.RadioButton();
            this.rbOwner = new System.Windows.Forms.RadioButton();
            this.rbUnit = new System.Windows.Forms.RadioButton();
            this.btnInsert = new System.Windows.Forms.Button();
            this.insertGrid = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.insertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(30, 24);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 10;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(631, 357);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 11;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // rbBuilding
            // 
            this.rbBuilding.AutoSize = true;
            this.rbBuilding.Location = new System.Drawing.Point(43, 132);
            this.rbBuilding.Name = "rbBuilding";
            this.rbBuilding.Size = new System.Drawing.Size(62, 17);
            this.rbBuilding.TabIndex = 12;
            this.rbBuilding.TabStop = true;
            this.rbBuilding.Text = "Building";
            this.rbBuilding.UseVisualStyleBackColor = true;
            // 
            // rbCensus
            // 
            this.rbCensus.AutoSize = true;
            this.rbCensus.Location = new System.Drawing.Point(43, 155);
            this.rbCensus.Name = "rbCensus";
            this.rbCensus.Size = new System.Drawing.Size(88, 17);
            this.rbCensus.TabIndex = 13;
            this.rbCensus.TabStop = true;
            this.rbCensus.Text = "Census Tract";
            this.rbCensus.UseVisualStyleBackColor = true;
            // 
            // rbMortgager
            // 
            this.rbMortgager.AutoSize = true;
            this.rbMortgager.Location = new System.Drawing.Point(43, 179);
            this.rbMortgager.Name = "rbMortgager";
            this.rbMortgager.Size = new System.Drawing.Size(73, 17);
            this.rbMortgager.TabIndex = 14;
            this.rbMortgager.TabStop = true;
            this.rbMortgager.Text = "Mortgager";
            this.rbMortgager.UseVisualStyleBackColor = true;
            // 
            // rbOwner
            // 
            this.rbOwner.AutoSize = true;
            this.rbOwner.Location = new System.Drawing.Point(43, 203);
            this.rbOwner.Name = "rbOwner";
            this.rbOwner.Size = new System.Drawing.Size(56, 17);
            this.rbOwner.TabIndex = 15;
            this.rbOwner.TabStop = true;
            this.rbOwner.Text = "Owner";
            this.rbOwner.UseVisualStyleBackColor = true;
            // 
            // rbUnit
            // 
            this.rbUnit.AutoSize = true;
            this.rbUnit.Location = new System.Drawing.Point(43, 229);
            this.rbUnit.Name = "rbUnit";
            this.rbUnit.Size = new System.Drawing.Size(44, 17);
            this.rbUnit.TabIndex = 16;
            this.rbUnit.TabStop = true;
            this.rbUnit.Text = "Unit";
            this.rbUnit.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(43, 252);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // insertGrid
            // 
            this.insertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertGrid.Location = new System.Drawing.Point(199, 37);
            this.insertGrid.Name = "insertGrid";
            this.insertGrid.Size = new System.Drawing.Size(589, 302);
            this.insertGrid.TabIndex = 18;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(282, 357);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Create New:";
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.insertGrid);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rbUnit);
            this.Controls.Add(this.rbOwner);
            this.Controls.Add(this.rbMortgager);
            this.Controls.Add(this.rbCensus);
            this.Controls.Add(this.rbBuilding);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_back);
            this.Name = "Insert";
            this.Text = "Insert";
            ((System.ComponentModel.ISupportInitialize)(this.insertGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.RadioButton rbBuilding;
        private System.Windows.Forms.RadioButton rbCensus;
        private System.Windows.Forms.RadioButton rbMortgager;
        private System.Windows.Forms.RadioButton rbOwner;
        private System.Windows.Forms.RadioButton rbUnit;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DataGridView insertGrid;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
    }
}