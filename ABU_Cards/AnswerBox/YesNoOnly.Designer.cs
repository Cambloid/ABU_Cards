﻿namespace ABU_Cards.AnswerBox
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
            this.chkJa = new MaterialSkin.Controls.MaterialCheckBox();
            this.chkNein = new MaterialSkin.Controls.MaterialCheckBox();
            this.SuspendLayout();
            // 
            // chkJa
            // 
            this.chkJa.AutoSize = true;
            this.chkJa.Depth = 0;
            this.chkJa.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkJa.Location = new System.Drawing.Point(60, 18);
            this.chkJa.Margin = new System.Windows.Forms.Padding(0);
            this.chkJa.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkJa.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkJa.Name = "chkJa";
            this.chkJa.Ripple = true;
            this.chkJa.Size = new System.Drawing.Size(45, 30);
            this.chkJa.TabIndex = 4;
            this.chkJa.Text = "Ja";
            this.chkJa.UseVisualStyleBackColor = true;
            // 
            // chkNein
            // 
            this.chkNein.AutoSize = true;
            this.chkNein.Depth = 0;
            this.chkNein.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkNein.Location = new System.Drawing.Point(60, 48);
            this.chkNein.Margin = new System.Windows.Forms.Padding(0);
            this.chkNein.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkNein.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkNein.Name = "chkNein";
            this.chkNein.Ripple = true;
            this.chkNein.Size = new System.Drawing.Size(58, 30);
            this.chkNein.TabIndex = 5;
            this.chkNein.Text = "Nein";
            this.chkNein.UseVisualStyleBackColor = true;
            // 
            // YesNoOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkNein);
            this.Controls.Add(this.chkJa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "YesNoOnly";
            this.Size = new System.Drawing.Size(180, 96);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox chkJa;
        private MaterialSkin.Controls.MaterialCheckBox chkNein;
    }
}
