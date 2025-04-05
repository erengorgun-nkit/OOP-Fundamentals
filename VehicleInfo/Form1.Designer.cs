namespace VehicleInfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmb_Vehicles = new ComboBox();
            btn_ShowInfo = new Button();
            lbl_Brand = new Label();
            lbl_Year = new Label();
            SuspendLayout();
            // 
            // cmb_Vehicles
            // 
            cmb_Vehicles.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Vehicles.FormattingEnabled = true;
            cmb_Vehicles.Items.AddRange(new object[] { "Car", "Truck", "Motorcycle" });
            cmb_Vehicles.Location = new Point(12, 12);
            cmb_Vehicles.Name = "cmb_Vehicles";
            cmb_Vehicles.Size = new Size(121, 23);
            cmb_Vehicles.TabIndex = 0;
            // 
            // btn_ShowInfo
            // 
            btn_ShowInfo.Location = new Point(139, 12);
            btn_ShowInfo.Name = "btn_ShowInfo";
            btn_ShowInfo.Size = new Size(75, 24);
            btn_ShowInfo.TabIndex = 1;
            btn_ShowInfo.Text = "Show Info";
            btn_ShowInfo.UseVisualStyleBackColor = true;
            btn_ShowInfo.Click += btn_ShowInfo_Click;
            // 
            // lbl_Brand
            // 
            lbl_Brand.AutoSize = true;
            lbl_Brand.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Brand.Location = new Point(12, 47);
            lbl_Brand.Name = "lbl_Brand";
            lbl_Brand.Size = new Size(63, 21);
            lbl_Brand.TabIndex = 2;
            lbl_Brand.Text = "Brand: ";
            // 
            // lbl_Year
            // 
            lbl_Year.AutoSize = true;
            lbl_Year.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_Year.Location = new Point(12, 71);
            lbl_Year.Name = "lbl_Year";
            lbl_Year.Size = new Size(52, 21);
            lbl_Year.TabIndex = 3;
            lbl_Year.Text = "Year: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 110);
            Controls.Add(lbl_Year);
            Controls.Add(lbl_Brand);
            Controls.Add(btn_ShowInfo);
            Controls.Add(cmb_Vehicles);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_Vehicles;
        private Button btn_ShowInfo;
        private Label lbl_Brand;
        private Label lbl_Year;
    }
}
