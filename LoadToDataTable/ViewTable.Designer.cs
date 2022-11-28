namespace LoadToDataTable
{
    partial class ViewTable
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cbxDataTables = new System.Windows.Forms.ComboBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.lblLoading = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Wheat;
            this.pnlMain.Controls.Add(this.lblLoading);
            this.pnlMain.Controls.Add(this.cbxDataTables);
            this.pnlMain.Controls.Add(this.lblDisplay);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1200, 71);
            this.pnlMain.TabIndex = 0;
            // 
            // cbxDataTables
            // 
            this.cbxDataTables.Enabled = false;
            this.cbxDataTables.FormattingEnabled = true;
            this.cbxDataTables.Location = new System.Drawing.Point(211, 14);
            this.cbxDataTables.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxDataTables.Name = "cbxDataTables";
            this.cbxDataTables.Size = new System.Drawing.Size(410, 28);
            this.cbxDataTables.TabIndex = 2;
            this.cbxDataTables.SelectedIndexChanged += new System.EventHandler(this.cbxDataTables_SelectedIndexChanged);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(27, 18);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(170, 20);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "Select a Table to View:";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.dgvInformation);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 71);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(1200, 621);
            this.pnlData.TabIndex = 1;
            // 
            // dgvInformation
            // 
            this.dgvInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInformation.Location = new System.Drawing.Point(0, 0);
            this.dgvInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.RowHeadersWidth = 62;
            this.dgvInformation.Size = new System.Drawing.Size(1200, 621);
            this.dgvInformation.TabIndex = 0;
            this.dgvInformation.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformation_CellContentDoubleClick);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.Location = new System.Drawing.Point(699, 15);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(231, 37);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Loading data...";
            // 
            // ViewTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ViewTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View a Table";
            this.Load += new System.EventHandler(this.ViewTable_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.ComboBox cbxDataTables;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblLoading;
    }
}

