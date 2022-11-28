namespace TicTacToe
{
    partial class TicTacToe
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
            this.btnReset = new System.Windows.Forms.Button();
            this._lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.pcbBottomRight = new System.Windows.Forms.PictureBox();
            this.pcbBottomMiddle = new System.Windows.Forms.PictureBox();
            this.pcbBottomLeft = new System.Windows.Forms.PictureBox();
            this.pcbMiddleRight = new System.Windows.Forms.PictureBox();
            this.pcbTheMiddle = new System.Windows.Forms.PictureBox();
            this.pcbMiddleLeft = new System.Windows.Forms.PictureBox();
            this.pcbTopRight = new System.Windows.Forms.PictureBox();
            this.pcbTopMiddle = new System.Windows.Forms.PictureBox();
            this.pcbTopLeft = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBottomRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBottomMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBottomLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiddleRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTheMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiddleLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTopMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTopLeft)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(449, 490);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 60);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // _lblCurrentPlayer
            // 
            this._lblCurrentPlayer.AutoSize = true;
            this._lblCurrentPlayer.Location = new System.Drawing.Point(17, 22);
            this._lblCurrentPlayer.Name = "_lblCurrentPlayer";
            this._lblCurrentPlayer.Size = new System.Drawing.Size(113, 20);
            this._lblCurrentPlayer.TabIndex = 10;
            this._lblCurrentPlayer.Text = "Current Player:";
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Location = new System.Drawing.Point(136, 22);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(20, 20);
            this.lblCurrentPlayer.TabIndex = 11;
            this.lblCurrentPlayer.Text = "X";
            // 
            // pcbBottomRight
            // 
            this.pcbBottomRight.BackColor = System.Drawing.SystemColors.Window;
            this.pcbBottomRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbBottomRight.Image = global::TicTacToe.Properties.Resources.blankSpace;
            this.pcbBottomRight.Location = new System.Drawing.Point(449, 314);
            this.pcbBottomRight.Name = "pcbBottomRight";
            this.pcbBottomRight.Size = new System.Drawing.Size(100, 100);
            this.pcbBottomRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBottomRight.TabIndex = 8;
            this.pcbBottomRight.TabStop = false;
            this.pcbBottomRight.Click += new System.EventHandler(this.anyPcb_Click);
            // 
            // pcbBottomMiddle
            // 
            this.pcbBottomMiddle.BackColor = System.Drawing.SystemColors.Window;
            this.pcbBottomMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbBottomMiddle.Image = global::TicTacToe.Properties.Resources.blankSpace;
            this.pcbBottomMiddle.Location = new System.Drawing.Point(275, 314);
            this.pcbBottomMiddle.Name = "pcbBottomMiddle";
            this.pcbBottomMiddle.Size = new System.Drawing.Size(100, 100);
            this.pcbBottomMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBottomMiddle.TabIndex = 7;
            this.pcbBottomMiddle.TabStop = false;
            this.pcbBottomMiddle.Click += new System.EventHandler(this.anyPcb_Click);
            // 
            // pcbBottomLeft
            // 
            this.pcbBottomLeft.BackColor = System.Drawing.SystemColors.Window;
            this.pcbBottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbBottomLeft.Image = global::TicTacToe.Properties.Resources.blankSpace;
            this.pcbBottomLeft.Location = new System.Drawing.Point(97, 314);
            this.pcbBottomLeft.Name = "pcbBottomLeft";
            this.pcbBottomLeft.Size = new System.Drawing.Size(100, 100);
            this.pcbBottomLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBottomLeft.TabIndex = 6;
            this.pcbBottomLeft.TabStop = false;
            this.pcbBottomLeft.Click += new System.EventHandler(this.anyPcb_Click);
            // 
            // pcbMiddleRight
            // 
            this.pcbMiddleRight.BackColor = System.Drawing.SystemColors.Window;
            this.pcbMiddleRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbMiddleRight.Image = global::TicTacToe.Properties.Resources.blankSpace;
            this.pcbMiddleRight.Location = new System.Drawing.Point(449, 187);
            this.pcbMiddleRight.Name = "pcbMiddleRight";
            this.pcbMiddleRight.Size = new System.Drawing.Size(100, 100);
            this.pcbMiddleRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMiddleRight.TabIndex = 5;
            this.pcbMiddleRight.TabStop = false;
            this.pcbMiddleRight.Click += new System.EventHandler(this.anyPcb_Click);
            // 
            // pcbTheMiddle
            // 
            this.pcbTheMiddle.BackColor = System.Drawing.SystemColors.Window;
            this.pcbTheMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbTheMiddle.Image = global::TicTacToe.Properties.Resources.blankSpace;
            this.pcbTheMiddle.Location = new System.Drawing.Point(275, 187);
            this.pcbTheMiddle.Name = "pcbTheMiddle";
            this.pcbTheMiddle.Size = new System.Drawing.Size(100, 100);
            this.pcbTheMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTheMiddle.TabIndex = 4;
            this.pcbTheMiddle.TabStop = false;
            this.pcbTheMiddle.Click += new System.EventHandler(this.anyPcb_Click);
            // 
            // pcbMiddleLeft
            // 
            this.pcbMiddleLeft.BackColor = System.Drawing.SystemColors.Window;
            this.pcbMiddleLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbMiddleLeft.Image = global::TicTacToe.Properties.Resources.blankSpace;
            this.pcbMiddleLeft.Location = new System.Drawing.Point(97, 187);
            this.pcbMiddleLeft.Name = "pcbMiddleLeft";
            this.pcbMiddleLeft.Size = new System.Drawing.Size(100, 100);
            this.pcbMiddleLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMiddleLeft.TabIndex = 3;
            this.pcbMiddleLeft.TabStop = false;
            this.pcbMiddleLeft.Click += new System.EventHandler(this.anyPcb_Click);
            // 
            // pcbTopRight
            // 
            this.pcbTopRight.BackColor = System.Drawing.SystemColors.Window;
            this.pcbTopRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbTopRight.Image = global::TicTacToe.Properties.Resources.blankSpace;
            this.pcbTopRight.Location = new System.Drawing.Point(449, 57);
            this.pcbTopRight.Name = "pcbTopRight";
            this.pcbTopRight.Size = new System.Drawing.Size(100, 100);
            this.pcbTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTopRight.TabIndex = 2;
            this.pcbTopRight.TabStop = false;
            this.pcbTopRight.Click += new System.EventHandler(this.anyPcb_Click);
            // 
            // pcbTopMiddle
            // 
            this.pcbTopMiddle.BackColor = System.Drawing.SystemColors.Window;
            this.pcbTopMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbTopMiddle.Image = global::TicTacToe.Properties.Resources.blankSpace;
            this.pcbTopMiddle.Location = new System.Drawing.Point(275, 57);
            this.pcbTopMiddle.Name = "pcbTopMiddle";
            this.pcbTopMiddle.Size = new System.Drawing.Size(100, 100);
            this.pcbTopMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTopMiddle.TabIndex = 1;
            this.pcbTopMiddle.TabStop = false;
            this.pcbTopMiddle.Click += new System.EventHandler(this.anyPcb_Click);
            // 
            // pcbTopLeft
            // 
            this.pcbTopLeft.BackColor = System.Drawing.SystemColors.Window;
            this.pcbTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbTopLeft.Image = global::TicTacToe.Properties.Resources.blankSpace;
            this.pcbTopLeft.Location = new System.Drawing.Point(97, 57);
            this.pcbTopLeft.Name = "pcbTopLeft";
            this.pcbTopLeft.Size = new System.Drawing.Size(100, 100);
            this.pcbTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTopLeft.TabIndex = 0;
            this.pcbTopLeft.TabStop = false;
            this.pcbTopLeft.Click += new System.EventHandler(this.anyPcb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this._lblCurrentPlayer);
            this.groupBox1.Controls.Add(this.lblCurrentPlayer);
            this.groupBox1.Location = new System.Drawing.Point(68, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 71);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TicTacToe.Properties.Resources.Space_Free_PNG_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(630, 627);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pcbBottomRight);
            this.Controls.Add(this.pcbBottomMiddle);
            this.Controls.Add(this.pcbBottomLeft);
            this.Controls.Add(this.pcbMiddleRight);
            this.Controls.Add(this.pcbTheMiddle);
            this.Controls.Add(this.pcbMiddleLeft);
            this.Controls.Add(this.pcbTopRight);
            this.Controls.Add(this.pcbTopMiddle);
            this.Controls.Add(this.pcbTopLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe v2.0";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbBottomRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBottomMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBottomLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiddleRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTheMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMiddleLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTopMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTopLeft)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbTopLeft;
        private System.Windows.Forms.PictureBox pcbTopMiddle;
        private System.Windows.Forms.PictureBox pcbTopRight;
        private System.Windows.Forms.PictureBox pcbMiddleLeft;
        private System.Windows.Forms.PictureBox pcbTheMiddle;
        private System.Windows.Forms.PictureBox pcbMiddleRight;
        private System.Windows.Forms.PictureBox pcbBottomLeft;
        private System.Windows.Forms.PictureBox pcbBottomMiddle;
        private System.Windows.Forms.PictureBox pcbBottomRight;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label _lblCurrentPlayer;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

