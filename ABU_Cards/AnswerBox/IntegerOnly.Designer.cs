namespace ABU_Cards.AnswerBox
{
    partial class IntegerOnly
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
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.txtInput = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblText = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // picCheck
            // 
            this.picCheck.Location = new System.Drawing.Point(260, 37);
            this.picCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(38, 38);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 6;
            this.picCheck.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.Depth = 0;
            this.txtInput.Hint = "";
            this.txtInput.Location = new System.Drawing.Point(138, 40);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.MaxLength = 32767;
            this.txtInput.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtInput.Name = "txtInput";
            this.txtInput.PasswordChar = '\0';
            this.txtInput.SelectedText = "";
            this.txtInput.SelectionLength = 0;
            this.txtInput.SelectionStart = 0;
            this.txtInput.Size = new System.Drawing.Size(112, 32);
            this.txtInput.TabIndex = 7;
            this.txtInput.TabStop = false;
            this.txtInput.UseSystemPasswordChar = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Depth = 0;
            this.lblText.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblText.Location = new System.Drawing.Point(56, 42);
            this.lblText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(55, 27);
            this.lblText.TabIndex = 8;
            this.lblText.Text = "Text";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntegerOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.picCheck);
            this.Name = "IntegerOnly";
            this.Size = new System.Drawing.Size(405, 148);
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCheck;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtInput;
        private MaterialSkin.Controls.MaterialLabel lblText;
    }
}
