namespace ABU_Cards
{
    partial class FrmMainView
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
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.lsvCards = new MaterialSkin.Controls.MaterialListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSolution = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCheck = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblText = new MaterialSkin.Controls.MaterialLabel();
            this.btnNext = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.Location = new System.Drawing.Point(182, 177);
            this.pnlAnswer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(430, 135);
            this.pnlAnswer.TabIndex = 2;
            // 
            // lsvCards
            // 
            this.lsvCards.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lsvCards.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvCards.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.lsvCards.Depth = 0;
            this.lsvCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lsvCards.FullRowSelect = true;
            this.lsvCards.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvCards.Location = new System.Drawing.Point(1, 65);
            this.lsvCards.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lsvCards.MouseState = MaterialSkin.MouseState.OUT;
            this.lsvCards.MultiSelect = false;
            this.lsvCards.Name = "lsvCards";
            this.lsvCards.OwnerDraw = true;
            this.lsvCards.Size = new System.Drawing.Size(176, 287);
            this.lsvCards.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lsvCards.TabIndex = 6;
            this.lsvCards.UseCompatibleStateImageBehavior = false;
            this.lsvCards.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "Karten";
            this.colName.Width = 150;
            // 
            // btnSolution
            // 
            this.btnSolution.AutoSize = true;
            this.btnSolution.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSolution.Depth = 0;
            this.btnSolution.Icon = null;
            this.btnSolution.Location = new System.Drawing.Point(182, 316);
            this.btnSolution.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSolution.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Primary = false;
            this.btnSolution.Size = new System.Drawing.Size(87, 36);
            this.btnSolution.TabIndex = 7;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.AutoSize = true;
            this.btnCheck.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheck.Depth = 0;
            this.btnCheck.Icon = null;
            this.btnCheck.Location = new System.Drawing.Point(485, 316);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Primary = false;
            this.btnCheck.Size = new System.Drawing.Size(65, 36);
            this.btnCheck.TabIndex = 8;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Depth = 0;
            this.lblText.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblText.Location = new System.Drawing.Point(183, 70);
            this.lblText.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(38, 19);
            this.lblText.TabIndex = 10;
            this.lblText.Text = "Text";
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext.Depth = 0;
            this.btnNext.Icon = null;
            this.btnNext.Location = new System.Drawing.Point(557, 316);
            this.btnNext.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext.Name = "btnNext";
            this.btnNext.Primary = true;
            this.btnNext.Size = new System.Drawing.Size(55, 36);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // FrmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 354);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lsvCards);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.pnlAnswer);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmMainView";
            this.Text = "ABU Kärtchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlAnswer;
        private MaterialSkin.Controls.MaterialListView lsvCards;
        private MaterialSkin.Controls.MaterialFlatButton btnSolution;
        private MaterialSkin.Controls.MaterialFlatButton btnCheck;
        private System.Windows.Forms.ColumnHeader colName;
        private MaterialSkin.Controls.MaterialLabel lblText;
        private MaterialSkin.Controls.MaterialRaisedButton btnNext;
    }
}

