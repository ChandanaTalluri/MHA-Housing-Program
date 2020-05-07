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
            this.rbtn_Unit = new System.Windows.Forms.RadioButton();
            this.rbtn_Owner = new System.Windows.Forms.RadioButton();
            this.rbtn_Mortgager = new System.Windows.Forms.RadioButton();
            this.rbtn_CensusTract = new System.Windows.Forms.RadioButton();
            this.rbtn_Building = new System.Windows.Forms.RadioButton();
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
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // rbtn_Unit
            // 
            this.rbtn_Unit.Location = new System.Drawing.Point(12, 129);
            this.rbtn_Unit.Name = "rbtn_Unit";
            this.rbtn_Unit.Size = new System.Drawing.Size(100, 20);
            this.rbtn_Unit.TabIndex = 25;
            this.rbtn_Unit.TabStop = true;
            this.rbtn_Unit.Text = "Unit";
            this.rbtn_Unit.UseVisualStyleBackColor = true;
            // 
            // rbtn_Owner
            // 
            this.rbtn_Owner.Location = new System.Drawing.Point(12, 103);
            this.rbtn_Owner.Name = "rbtn_Owner";
            this.rbtn_Owner.Size = new System.Drawing.Size(100, 20);
            this.rbtn_Owner.TabIndex = 24;
            this.rbtn_Owner.TabStop = true;
            this.rbtn_Owner.Text = "Owner";
            this.rbtn_Owner.UseVisualStyleBackColor = true;
            // 
            // rbtn_Mortgager
            // 
            this.rbtn_Mortgager.Location = new System.Drawing.Point(12, 79);
            this.rbtn_Mortgager.Name = "rbtn_Mortgager";
            this.rbtn_Mortgager.Size = new System.Drawing.Size(100, 20);
            this.rbtn_Mortgager.TabIndex = 23;
            this.rbtn_Mortgager.TabStop = true;
            this.rbtn_Mortgager.Text = "Mortgager";
            this.rbtn_Mortgager.UseVisualStyleBackColor = true;
            // 
            // rbtn_CensusTract
            // 
            this.rbtn_CensusTract.Location = new System.Drawing.Point(12, 55);
            this.rbtn_CensusTract.Name = "rbtn_CensusTract";
            this.rbtn_CensusTract.Size = new System.Drawing.Size(100, 20);
            this.rbtn_CensusTract.TabIndex = 22;
            this.rbtn_CensusTract.TabStop = true;
            this.rbtn_CensusTract.Text = "Census Tract";
            this.rbtn_CensusTract.UseVisualStyleBackColor = true;
            // 
            // rbtn_Building
            // 
            this.rbtn_Building.Location = new System.Drawing.Point(12, 32);
            this.rbtn_Building.Name = "rbtn_Building";
            this.rbtn_Building.Size = new System.Drawing.Size(100, 20);
            this.rbtn_Building.TabIndex = 21;
            this.rbtn_Building.TabStop = true;
            this.rbtn_Building.Text = "Building";
            this.rbtn_Building.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.rbtn_Unit);
            this.Controls.Add(this.rbtn_Owner);
            this.Controls.Add(this.rbtn_Mortgager);
            this.Controls.Add(this.rbtn_CensusTract);
            this.Controls.Add(this.rbtn_Building);
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
        private System.Windows.Forms.RadioButton rbtn_Unit;
        private System.Windows.Forms.RadioButton rbtn_Owner;
        private System.Windows.Forms.RadioButton rbtn_Mortgager;
        private System.Windows.Forms.RadioButton rbtn_CensusTract;
        private System.Windows.Forms.RadioButton rbtn_Building;
    }
}