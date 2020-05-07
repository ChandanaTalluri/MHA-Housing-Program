namespace MHA_UserInterface
{
    partial class Update
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.insertGrid = new System.Windows.Forms.DataGridView();
            this.btnInsert = new System.Windows.Forms.Button();
            this.rbUnit = new System.Windows.Forms.RadioButton();
            this.rbOwner = new System.Windows.Forms.RadioButton();
            this.rbMortgager = new System.Windows.Forms.RadioButton();
            this.rbCensus = new System.Windows.Forms.RadioButton();
            this.rbBuilding = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.insertGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(616, 326);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 3;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(697, 326);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Update table:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 178);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 23);
            this.btnRefresh.TabIndex = 28;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // insertGrid
            // 
            this.insertGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.insertGrid.Location = new System.Drawing.Point(118, 12);
            this.insertGrid.Name = "insertGrid";
            this.insertGrid.Size = new System.Drawing.Size(654, 308);
            this.insertGrid.TabIndex = 27;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 152);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 20);
            this.btnInsert.TabIndex = 26;
            this.btnInsert.Text = "Update";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // rbUnit
            // 
            this.rbUnit.Location = new System.Drawing.Point(12, 129);
            this.rbUnit.Name = "rbUnit";
            this.rbUnit.Size = new System.Drawing.Size(100, 20);
            this.rbUnit.TabIndex = 25;
            this.rbUnit.TabStop = true;
            this.rbUnit.Text = "Unit";
            this.rbUnit.UseVisualStyleBackColor = true;
            // 
            // rbOwner
            // 
            this.rbOwner.Location = new System.Drawing.Point(12, 103);
            this.rbOwner.Name = "rbOwner";
            this.rbOwner.Size = new System.Drawing.Size(100, 20);
            this.rbOwner.TabIndex = 24;
            this.rbOwner.TabStop = true;
            this.rbOwner.Text = "Owner";
            this.rbOwner.UseVisualStyleBackColor = true;
            // 
            // rbMortgager
            // 
            this.rbMortgager.Location = new System.Drawing.Point(12, 79);
            this.rbMortgager.Name = "rbMortgager";
            this.rbMortgager.Size = new System.Drawing.Size(100, 20);
            this.rbMortgager.TabIndex = 23;
            this.rbMortgager.TabStop = true;
            this.rbMortgager.Text = "Mortgager";
            this.rbMortgager.UseVisualStyleBackColor = true;
            // 
            // rbCensus
            // 
            this.rbCensus.Location = new System.Drawing.Point(12, 55);
            this.rbCensus.Name = "rbCensus";
            this.rbCensus.Size = new System.Drawing.Size(100, 20);
            this.rbCensus.TabIndex = 22;
            this.rbCensus.TabStop = true;
            this.rbCensus.Text = "Census Tract";
            this.rbCensus.UseVisualStyleBackColor = true;
            // 
            // rbBuilding
            // 
            this.rbBuilding.Location = new System.Drawing.Point(12, 32);
            this.rbBuilding.Name = "rbBuilding";
            this.rbBuilding.Size = new System.Drawing.Size(100, 20);
            this.rbBuilding.TabIndex = 21;
            this.rbBuilding.TabStop = true;
            this.rbBuilding.Text = "Building";
            this.rbBuilding.UseVisualStyleBackColor = true;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.insertGrid);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.rbUnit);
            this.Controls.Add(this.rbOwner);
            this.Controls.Add(this.rbMortgager);
            this.Controls.Add(this.rbCensus);
            this.Controls.Add(this.rbBuilding);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_Exit);
            this.Name = "Update";
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.insertGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView insertGrid;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.RadioButton rbUnit;
        private System.Windows.Forms.RadioButton rbOwner;
        private System.Windows.Forms.RadioButton rbMortgager;
        private System.Windows.Forms.RadioButton rbCensus;
        private System.Windows.Forms.RadioButton rbBuilding;
    }
}