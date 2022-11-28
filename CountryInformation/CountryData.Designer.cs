namespace Country_Information
{
    partial class CountryData
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
            this.lstCountries = new System.Windows.Forms.ListBox();
            this.grpCoordsDisplay = new System.Windows.Forms.GroupBox();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lbl_longitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lbl_latitude = new System.Windows.Forms.Label();
            this.txtCountryInput = new System.Windows.Forms.TextBox();
            this.lblLookUpCountry = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pcbMap = new System.Windows.Forms.PictureBox();
            this.grpCoordsDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMap)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCountries
            // 
            this.lstCountries.Font = new System.Drawing.Font("Swis721 Cn BT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCountries.FormattingEnabled = true;
            this.lstCountries.ItemHeight = 19;
            this.lstCountries.Location = new System.Drawing.Point(53, 88);
            this.lstCountries.Name = "lstCountries";
            this.lstCountries.Size = new System.Drawing.Size(352, 289);
            this.lstCountries.TabIndex = 0;
            this.lstCountries.DoubleClick += new System.EventHandler(this.lstCountries_DoubleClick);
            // 
            // grpCoordsDisplay
            // 
            this.grpCoordsDisplay.BackColor = System.Drawing.SystemColors.Highlight;
            this.grpCoordsDisplay.Controls.Add(this.lblLongitude);
            this.grpCoordsDisplay.Controls.Add(this.lbl_longitude);
            this.grpCoordsDisplay.Controls.Add(this.lblLatitude);
            this.grpCoordsDisplay.Controls.Add(this.lbl_latitude);
            this.grpCoordsDisplay.Font = new System.Drawing.Font("Swis721 BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCoordsDisplay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpCoordsDisplay.Location = new System.Drawing.Point(23, 407);
            this.grpCoordsDisplay.Name = "grpCoordsDisplay";
            this.grpCoordsDisplay.Size = new System.Drawing.Size(416, 100);
            this.grpCoordsDisplay.TabIndex = 1;
            this.grpCoordsDisplay.TabStop = false;
            this.grpCoordsDisplay.Text = "Location Coordinates";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(295, 54);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(0, 19);
            this.lblLongitude.TabIndex = 3;
            // 
            // lbl_longitude
            // 
            this.lbl_longitude.AutoSize = true;
            this.lbl_longitude.Location = new System.Drawing.Point(205, 55);
            this.lbl_longitude.Name = "lbl_longitude";
            this.lbl_longitude.Size = new System.Drawing.Size(87, 19);
            this.lbl_longitude.TabIndex = 2;
            this.lbl_longitude.Text = "Longitude:";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(113, 55);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(0, 19);
            this.lblLatitude.TabIndex = 1;
            // 
            // lbl_latitude
            // 
            this.lbl_latitude.AutoSize = true;
            this.lbl_latitude.Location = new System.Drawing.Point(35, 54);
            this.lbl_latitude.Name = "lbl_latitude";
            this.lbl_latitude.Size = new System.Drawing.Size(72, 19);
            this.lbl_latitude.TabIndex = 0;
            this.lbl_latitude.Text = "Latitude:";
            // 
            // txtCountryInput
            // 
            this.txtCountryInput.Location = new System.Drawing.Point(188, 50);
            this.txtCountryInput.Name = "txtCountryInput";
            this.txtCountryInput.Size = new System.Drawing.Size(100, 26);
            this.txtCountryInput.TabIndex = 2;
            this.txtCountryInput.Enter += new System.EventHandler(this.txtCountryInput_Enter);
            // 
            // lblLookUpCountry
            // 
            this.lblLookUpCountry.AutoSize = true;
            this.lblLookUpCountry.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblLookUpCountry.Font = new System.Drawing.Font("Swis721 Blk BT", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLookUpCountry.ForeColor = System.Drawing.Color.White;
            this.lblLookUpCountry.Location = new System.Drawing.Point(12, 54);
            this.lblLookUpCountry.Name = "lblLookUpCountry";
            this.lblLookUpCountry.Size = new System.Drawing.Size(161, 19);
            this.lblLookUpCountry.TabIndex = 3;
            this.lblLookUpCountry.Text = "Look Up Country:";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Swis721 BT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(317, 46);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 36);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pcbMap
            // 
            this.pcbMap.Image = global::Country_Information.Properties.Resources.world_political_map_new;
            this.pcbMap.Location = new System.Drawing.Point(456, 1);
            this.pcbMap.Name = "pcbMap";
            this.pcbMap.Size = new System.Drawing.Size(544, 576);
            this.pcbMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMap.TabIndex = 5;
            this.pcbMap.TabStop = false;
            // 
            // CountryData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 600);
            this.Controls.Add(this.pcbMap);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblLookUpCountry);
            this.Controls.Add(this.txtCountryInput);
            this.Controls.Add(this.grpCoordsDisplay);
            this.Controls.Add(this.lstCountries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "CountryData";
            this.Text = "Country Data";
            this.Load += new System.EventHandler(this.CountryData_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CountryData_KeyPress);
            this.grpCoordsDisplay.ResumeLayout(false);
            this.grpCoordsDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCountries;
        private System.Windows.Forms.GroupBox grpCoordsDisplay;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lbl_longitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lbl_latitude;
        private System.Windows.Forms.TextBox txtCountryInput;
        private System.Windows.Forms.Label lblLookUpCountry;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox pcbMap;
    }
}

