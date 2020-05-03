namespace MHA_UserInterface
{
    partial class Delete
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
            this.deleteGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rbBuilding = new System.Windows.Forms.RadioButton();
            this.rbCensus = new System.Windows.Forms.RadioButton();
            this.rbMortgager = new System.Windows.Forms.RadioButton();
            this.rbOwner = new System.Windows.Forms.RadioButton();
            this.rbUnit = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.deleteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(32, 24);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(618, 358);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // deleteGrid
            // 
            this.deleteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deleteGrid.Location = new System.Drawing.Point(182, 35);
            this.deleteGrid.Name = "deleteGrid";
            this.deleteGrid.Size = new System.Drawing.Size(594, 304);
            this.deleteGrid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Delete From:";
            // 
            // rbBuilding
            // 
            this.rbBuilding.AutoSize = true;
            this.rbBuilding.Location = new System.Drawing.Point(55, 136);
            this.rbBuilding.Name = "rbBuilding";
            this.rbBuilding.Size = new System.Drawing.Size(62, 17);
            this.rbBuilding.TabIndex = 6;
            this.rbBuilding.TabStop = true;
            this.rbBuilding.Text = "Building";
            this.rbBuilding.UseVisualStyleBackColor = true;
            // 
            // rbCensus
            // 
            this.rbCensus.AutoSize = true;
            this.rbCensus.Location = new System.Drawing.Point(55, 159);
            this.rbCensus.Name = "rbCensus";
            this.rbCensus.Size = new System.Drawing.Size(85, 17);
            this.rbCensus.TabIndex = 7;
            this.rbCensus.TabStop = true;
            this.rbCensus.Text = "CensusTract";
            this.rbCensus.UseVisualStyleBackColor = true;
            // 
            // rbMortgager
            // 
            this.rbMortgager.AutoSize = true;
            this.rbMortgager.Location = new System.Drawing.Point(55, 182);
            this.rbMortgager.Name = "rbMortgager";
            this.rbMortgager.Size = new System.Drawing.Size(73, 17);
            this.rbMortgager.TabIndex = 8;
            this.rbMortgager.TabStop = true;
            this.rbMortgager.Text = "Mortgager";
            this.rbMortgager.UseVisualStyleBackColor = true;
            // 
            // rbOwner
            // 
            this.rbOwner.AutoSize = true;
            this.rbOwner.Location = new System.Drawing.Point(55, 205);
            this.rbOwner.Name = "rbOwner";
            this.rbOwner.Size = new System.Drawing.Size(56, 17);
            this.rbOwner.TabIndex = 9;
            this.rbOwner.TabStop = true;
            this.rbOwner.Text = "Owner";
            this.rbOwner.UseVisualStyleBackColor = true;
            // 
            // rbUnit
            // 
            this.rbUnit.AutoSize = true;
            this.rbUnit.Location = new System.Drawing.Point(55, 228);
            this.rbUnit.Name = "rbUnit";
            this.rbUnit.Size = new System.Drawing.Size(44, 17);
            this.rbUnit.TabIndex = 10;
            this.rbUnit.TabStop = true;
            this.rbUnit.Text = "Unit";
            this.rbUnit.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(277, 358);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(55, 251);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.rbUnit);
            this.Controls.Add(this.rbOwner);
            this.Controls.Add(this.rbMortgager);
            this.Controls.Add(this.rbCensus);
            this.Controls.Add(this.rbBuilding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteGrid);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Exit);
            this.Name = "Delete";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.deleteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.DataGridView deleteGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBuilding;
        private System.Windows.Forms.RadioButton rbCensus;
        private System.Windows.Forms.RadioButton rbMortgager;
        private System.Windows.Forms.RadioButton rbOwner;
        private System.Windows.Forms.RadioButton rbUnit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
    }
}