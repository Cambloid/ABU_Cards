namespace ABU_Cards.AnswerBox
{
    partial class TextBoxStackVertical
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
            this.picPattern = new System.Windows.Forms.PictureBox();
            this.lblPattern = new MaterialSkin.Controls.MaterialLabel();
            this.txtPattern = new MaterialSkin.Controls.MaterialSingleLineTextField();
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).BeginInit();
            this.SuspendLayout();
            // 
            // picPattern
            // 
            this.picPattern.Location = new System.Drawing.Point(167, 17);
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
            // txtPattern
            // 
            this.txtPattern.Depth = 0;
            this.txtPattern.Hint = "";
            this.txtPattern.Location = new System.Drawing.Point(71, 20);
            this.txtPattern.MaxLength = 32767;
            this.txtPattern.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPattern.Name = "txtPattern";
            this.txtPattern.PasswordChar = '\0';
            this.txtPattern.SelectedText = "";
            this.txtPattern.SelectionLength = 0;
            this.txtPattern.SelectionStart = 0;
            this.txtPattern.Size = new System.Drawing.Size(75, 23);
            this.txtPattern.TabIndex = 8;
            this.txtPattern.TabStop = false;
            this.txtPattern.UseSystemPasswordChar = false;
            // 
            // TextBoxStackVertical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPattern);
            this.Controls.Add(this.lblPattern);
            this.Controls.Add(this.picPattern);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TextBoxStackVertical";
            this.Size = new System.Drawing.Size(279, 174);
            ((System.ComponentModel.ISupportInitialize)(this.picPattern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picPattern;
        private MaterialSkin.Controls.MaterialLabel lblPattern;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPattern;
    }
}
