namespace MHA_UserInterface
{
    partial class Update_Unit
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
            this.lbl_NumBaths = new System.Windows.Forms.Label();
            this.lbl_SizeSquareFeet = new System.Windows.Forms.Label();
            this.lbl_Occupied = new System.Windows.Forms.Label();
            this.lbl_AvgOccupancy = new System.Windows.Forms.Label();
            this.lbl_SpecialRemarks = new System.Windows.Forms.Label();
            this.lbl_KitchenAndDining = new System.Windows.Forms.Label();
            this.lbl_LocationInBuilding = new System.Windows.Forms.Label();
            this.lbl_UnitType = new System.Windows.Forms.Label();
            this.lbl_BuildingID = new System.Windows.Forms.Label();
            this.lbl_UnitID = new System.Windows.Forms.Label();
            this.txt_NumBaths = new System.Windows.Forms.TextBox();
            this.txt_SizeSquareFeet = new System.Windows.Forms.TextBox();
            this.txt_Occupied = new System.Windows.Forms.TextBox();
            this.txt_AvgOccupancy = new System.Windows.Forms.TextBox();
            this.txt_BuildingID = new System.Windows.Forms.TextBox();
            this.txt_UnitType = new System.Windows.Forms.TextBox();
            this.txt_LocationInBuilding = new System.Windows.Forms.TextBox();
            this.txt_SpecialRemarks = new System.Windows.Forms.TextBox();
            this.txt_KitchenAndDining = new System.Windows.Forms.TextBox();
            this.txt_UnitID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(12, 299);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(236, 23);
            this.btn_Update.TabIndex = 27;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // lbl_NumBaths
            // 
            this.lbl_NumBaths.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_NumBaths.Location = new System.Drawing.Point(12, 169);
            this.lbl_NumBaths.Name = "lbl_NumBaths";
            this.lbl_NumBaths.Size = new System.Drawing.Size(130, 20);
            this.lbl_NumBaths.TabIndex = 48;
            this.lbl_NumBaths.Text = "Number of bathrooms:";
            this.lbl_NumBaths.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SizeSquareFeet
            // 
            this.lbl_SizeSquareFeet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SizeSquareFeet.Location = new System.Drawing.Point(12, 143);
            this.lbl_SizeSquareFeet.Name = "lbl_SizeSquareFeet";
            this.lbl_SizeSquareFeet.Size = new System.Drawing.Size(130, 20);
            this.lbl_SizeSquareFeet.TabIndex = 47;
            this.lbl_SizeSquareFeet.Text = "Size in square feet:";
            this.lbl_SizeSquareFeet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_Occupied
            // 
            this.lbl_Occupied.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Occupied.Location = new System.Drawing.Point(12, 273);
            this.lbl_Occupied.Name = "lbl_Occupied";
            this.lbl_Occupied.Size = new System.Drawing.Size(130, 20);
            this.lbl_Occupied.TabIndex = 46;
            this.lbl_Occupied.Text = "Occupied:";
            this.lbl_Occupied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_AvgOccupancy
            // 
            this.lbl_AvgOccupancy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_AvgOccupancy.Location = new System.Drawing.Point(12, 247);
            this.lbl_AvgOccupancy.Name = "lbl_AvgOccupancy";
            this.lbl_AvgOccupancy.Size = new System.Drawing.Size(130, 20);
            this.lbl_AvgOccupancy.TabIndex = 45;
            this.lbl_AvgOccupancy.Text = "Average occupancy:";
            this.lbl_AvgOccupancy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_SpecialRemarks
            // 
            this.lbl_SpecialRemarks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_SpecialRemarks.Location = new System.Drawing.Point(12, 221);
            this.lbl_SpecialRemarks.Name = "lbl_SpecialRemarks";
            this.lbl_SpecialRemarks.Size = new System.Drawing.Size(130, 20);
            this.lbl_SpecialRemarks.TabIndex = 44;
            this.lbl_SpecialRemarks.Text = "Special remarks:";
            this.lbl_SpecialRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_KitchenAndDining
            // 
            this.lbl_KitchenAndDining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_KitchenAndDining.Location = new System.Drawing.Point(12, 195);
            this.lbl_KitchenAndDining.Name = "lbl_KitchenAndDining";
            this.lbl_KitchenAndDining.Size = new System.Drawing.Size(130, 20);
            this.lbl_KitchenAndDining.TabIndex = 43;
            this.lbl_KitchenAndDining.Text = "Kitchen and dining:";
            this.lbl_KitchenAndDining.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_LocationInBuilding
            // 
            this.lbl_LocationInBuilding.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_LocationInBuilding.Location = new System.Drawing.Point(12, 117);
            this.lbl_LocationInBuilding.Name = "lbl_LocationInBuilding";
            this.lbl_LocationInBuilding.Size = new System.Drawing.Size(130, 20);
            this.lbl_LocationInBuilding.TabIndex = 42;
            this.lbl_LocationInBuilding.Text = "Location in building:";
            this.lbl_LocationInBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UnitType
            // 
            this.lbl_UnitType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UnitType.Location = new System.Drawing.Point(12, 91);
            this.lbl_UnitType.Name = "lbl_UnitType";
            this.lbl_UnitType.Size = new System.Drawing.Size(130, 20);
            this.lbl_UnitType.TabIndex = 41;
            this.lbl_UnitType.Text = "Unit type:";
            this.lbl_UnitType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_BuildingID
            // 
            this.lbl_BuildingID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BuildingID.Location = new System.Drawing.Point(12, 65);
            this.lbl_BuildingID.Name = "lbl_BuildingID";
            this.lbl_BuildingID.Size = new System.Drawing.Size(130, 20);
            this.lbl_BuildingID.TabIndex = 40;
            this.lbl_BuildingID.Text = "Building ID:";
            this.lbl_BuildingID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UnitID
            // 
            this.lbl_UnitID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_UnitID.Location = new System.Drawing.Point(12, 9);
            this.lbl_UnitID.Name = "lbl_UnitID";
            this.lbl_UnitID.Size = new System.Drawing.Size(130, 20);
            this.lbl_UnitID.TabIndex = 39;
            this.lbl_UnitID.Text = "Unit ID:";
            this.lbl_UnitID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_NumBaths
            // 
            this.txt_NumBaths.Location = new System.Drawing.Point(148, 169);
            this.txt_NumBaths.Name = "txt_NumBaths";
            this.txt_NumBaths.Size = new System.Drawing.Size(100, 20);
            this.txt_NumBaths.TabIndex = 37;
            // 
            // txt_SizeSquareFeet
            // 
            this.txt_SizeSquareFeet.Location = new System.Drawing.Point(148, 143);
            this.txt_SizeSquareFeet.Name = "txt_SizeSquareFeet";
            this.txt_SizeSquareFeet.Size = new System.Drawing.Size(100, 20);
            this.txt_SizeSquareFeet.TabIndex = 36;
            // 
            // txt_Occupied
            // 
            this.txt_Occupied.Location = new System.Drawing.Point(148, 273);
            this.txt_Occupied.Name = "txt_Occupied";
            this.txt_Occupied.Size = new System.Drawing.Size(100, 20);
            this.txt_Occupied.TabIndex = 35;
            // 
            // txt_AvgOccupancy
            // 
            this.txt_AvgOccupancy.Location = new System.Drawing.Point(148, 247);
            this.txt_AvgOccupancy.Name = "txt_AvgOccupancy";
            this.txt_AvgOccupancy.Size = new System.Drawing.Size(100, 20);
            this.txt_AvgOccupancy.TabIndex = 34;
            // 
            // txt_BuildingID
            // 
            this.txt_BuildingID.Location = new System.Drawing.Point(148, 65);
            this.txt_BuildingID.Name = "txt_BuildingID";
            this.txt_BuildingID.Size = new System.Drawing.Size(100, 20);
            this.txt_BuildingID.TabIndex = 33;
            // 
            // txt_UnitType
            // 
            this.txt_UnitType.Location = new System.Drawing.Point(148, 91);
            this.txt_UnitType.Name = "txt_UnitType";
            this.txt_UnitType.Size = new System.Drawing.Size(100, 20);
            this.txt_UnitType.TabIndex = 32;
            // 
            // txt_LocationInBuilding
            // 
            this.txt_LocationInBuilding.Location = new System.Drawing.Point(148, 117);
            this.txt_LocationInBuilding.Name = "txt_LocationInBuilding";
            this.txt_LocationInBuilding.Size = new System.Drawing.Size(100, 20);
            this.txt_LocationInBuilding.TabIndex = 31;
            // 
            // txt_SpecialRemarks
            // 
            this.txt_SpecialRemarks.Location = new System.Drawing.Point(148, 221);
            this.txt_SpecialRemarks.Name = "txt_SpecialRemarks";
            this.txt_SpecialRemarks.Size = new System.Drawing.Size(100, 20);
            this.txt_SpecialRemarks.TabIndex = 30;
            // 
            // txt_KitchenAndDining
            // 
            this.txt_KitchenAndDining.Location = new System.Drawing.Point(148, 195);
            this.txt_KitchenAndDining.Name = "txt_KitchenAndDining";
            this.txt_KitchenAndDining.Size = new System.Drawing.Size(100, 20);
            this.txt_KitchenAndDining.TabIndex = 29;
            // 
            // txt_UnitID
            // 
            this.txt_UnitID.Location = new System.Drawing.Point(148, 9);
            this.txt_UnitID.Name = "txt_UnitID";
            this.txt_UnitID.Size = new System.Drawing.Size(100, 20);
            this.txt_UnitID.TabIndex = 28;
            // 
            // Update_Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 331);
            this.Controls.Add(this.lbl_NumBaths);
            this.Controls.Add(this.lbl_SizeSquareFeet);
            this.Controls.Add(this.lbl_Occupied);
            this.Controls.Add(this.lbl_AvgOccupancy);
            this.Controls.Add(this.lbl_SpecialRemarks);
            this.Controls.Add(this.lbl_KitchenAndDining);
            this.Controls.Add(this.lbl_LocationInBuilding);
            this.Controls.Add(this.lbl_UnitType);
            this.Controls.Add(this.lbl_BuildingID);
            this.Controls.Add(this.lbl_UnitID);
            this.Controls.Add(this.txt_NumBaths);
            this.Controls.Add(this.txt_SizeSquareFeet);
            this.Controls.Add(this.txt_Occupied);
            this.Controls.Add(this.txt_AvgOccupancy);
            this.Controls.Add(this.txt_BuildingID);
            this.Controls.Add(this.txt_UnitType);
            this.Controls.Add(this.txt_LocationInBuilding);
            this.Controls.Add(this.txt_SpecialRemarks);
            this.Controls.Add(this.txt_KitchenAndDining);
            this.Controls.Add(this.txt_UnitID);
            this.Controls.Add(this.btn_Update);
            this.MaximumSize = new System.Drawing.Size(275, 370);
            this.MinimumSize = new System.Drawing.Size(275, 370);
            this.Name = "Update_Unit";
            this.Text = "Update_Unit";
            this.Load += new System.EventHandler(this.Update_Unit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Label lbl_NumBaths;
        private System.Windows.Forms.Label lbl_SizeSquareFeet;
        private System.Windows.Forms.Label lbl_Occupied;
        private System.Windows.Forms.Label lbl_AvgOccupancy;
        private System.Windows.Forms.Label lbl_SpecialRemarks;
        private System.Windows.Forms.Label lbl_KitchenAndDining;
        private System.Windows.Forms.Label lbl_LocationInBuilding;
        private System.Windows.Forms.Label lbl_UnitType;
        private System.Windows.Forms.Label lbl_BuildingID;
        private System.Windows.Forms.Label lbl_UnitID;
        private System.Windows.Forms.TextBox txt_NumBaths;
        private System.Windows.Forms.TextBox txt_SizeSquareFeet;
        private System.Windows.Forms.TextBox txt_Occupied;
        private System.Windows.Forms.TextBox txt_AvgOccupancy;
        private System.Windows.Forms.TextBox txt_BuildingID;
        private System.Windows.Forms.TextBox txt_UnitType;
        private System.Windows.Forms.TextBox txt_LocationInBuilding;
        private System.Windows.Forms.TextBox txt_SpecialRemarks;
        private System.Windows.Forms.TextBox txt_KitchenAndDining;
        private System.Windows.Forms.TextBox txt_UnitID;
    }
}