namespace ABU_Cards.AnswerBox
{
    partial class CheckBoxStackVertical
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkPattern = new MaterialSkin.Controls.MaterialCheckBox();
            this.picPattern = new System.Windows.Forms.PictureBox();
            this.lblPattern = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).BeginInit();
            this.SuspendLayout();
            // 
            // chkPattern
            // 
            this.chkPattern.AutoSize = true;
            this.chkPattern.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkPattern.Depth = 0;
            this.chkPattern.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkPattern.Location = new System.Drawing.Point(67, 14);
            this.chkPattern.Margin = new System.Windows.Forms.Padding(0);
            this.chkPattern.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkPattern.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkPattern.Name = "chkPattern";
            this.chkPattern.Ripple = true;
            this.chkPattern.Size = new System.Drawing.Size(26, 30);
            this.chkPattern.TabIndex = 4;
            this.chkPattern.UseVisualStyleBackColor = false;
            // 
            // picPattern
            // 
            this.picPattern.Location = new System.Drawing.Point(134, 17);
            this.picPattern.Name = "picPattern";
            this.picPattern.Size = new System.Drawing.Size(25, 25);
            this.picPattern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPattern.TabIndex = 6;
            this.picPattern.TabStop = false;
            // 
            // lblPattern
            // 
            this.lblPattern.AutoSize = true;
            this.lblPattern.Depth = 0;
            this.lblPattern.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPattern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPattern.Location = new System.Drawing.Point(31, 20);
            this.lblPattern.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPattern.Name = "lblPattern";
            this.lblPattern.Size = new System.Drawing.Size(34, 19);
            this.lblPattern.TabIndex = 7;
            this.lblPattern.Text = "text";
            this.lblPattern.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CheckBoxStackVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.picPattern);
            this.Controls.Add(this.chkPattern);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CheckBoxStackVertical";
            this.Size = new System.Drawing.Size(279, 174);
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox chkPattern;
        private System.Windows.Forms.PictureBox picPattern;
        private MaterialSkin.Controls.MaterialLabel lblPattern;
    }
}
