namespace ABU_Cards.AnswerBox
{
    partial class YesNoOnly
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
            this.chkNein = new System.Windows.Forms.CheckBox();
            this.chkJa = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkNein
            // 
            this.chkNein.AutoSize = true;
            this.chkNein.Location = new System.Drawing.Point(105, 77);
            this.chkNein.Name = "chkNein";
            this.chkNein.Size = new System.Drawing.Size(67, 24);
            this.chkNein.TabIndex = 2;
            this.chkNein.Text = "Nein";
            this.chkNein.UseVisualStyleBackColor = true;
            // 
            // chkJa
            // 
            this.chkJa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkJa.AutoSize = true;
            this.chkJa.BackColor = System.Drawing.Color.Transparent;
            this.chkJa.Location = new System.Drawing.Point(105, 47);
            this.chkJa.Name = "chkJa";
            this.chkJa.Size = new System.Drawing.Size(52, 24);
            this.chkJa.TabIndex = 3;
            this.chkJa.Text = "Ja";
            this.chkJa.UseVisualStyleBackColor = false;
            // 
            // YesNoOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkJa);
            this.Controls.Add(this.chkNein);
            this.Name = "YesNoOnly";
            this.Size = new System.Drawing.Size(270, 148);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNein;
        private System.Windows.Forms.CheckBox chkJa;
    }
}
