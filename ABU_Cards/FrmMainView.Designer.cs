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
            this.lstCards = new System.Windows.Forms.ListView();
            this.rtbQuestion = new System.Windows.Forms.RichTextBox();
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSolution = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCards
            // 
            this.lstCards.FullRowSelect = true;
            this.lstCards.GridLines = true;
            this.lstCards.Location = new System.Drawing.Point(12, 12);
            this.lstCards.Name = "lstCards";
            this.lstCards.Size = new System.Drawing.Size(255, 521);
            this.lstCards.TabIndex = 0;
            this.lstCards.UseCompatibleStateImageBehavior = false;
            this.lstCards.View = System.Windows.Forms.View.Tile;
            // 
            // rtbQuestion
            // 
            this.rtbQuestion.Location = new System.Drawing.Point(273, 12);
            this.rtbQuestion.Name = "rtbQuestion";
            this.rtbQuestion.Size = new System.Drawing.Size(644, 255);
            this.rtbQuestion.TabIndex = 1;
            this.rtbQuestion.Text = "";
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAnswer.Location = new System.Drawing.Point(273, 273);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(644, 207);
            this.pnlAnswer.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(770, 486);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(147, 47);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnSolution
            // 
            this.btnSolution.Location = new System.Drawing.Point(273, 486);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(147, 47);
            this.btnSolution.TabIndex = 4;
            this.btnSolution.Text = "Solution";
            this.btnSolution.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(617, 486);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(147, 47);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // FrmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 545);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.pnlAnswer);
            this.Controls.Add(this.rtbQuestion);
            this.Controls.Add(this.lstCards);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmMainView";
            this.Text = "ABU Kärtchen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstCards;
        private System.Windows.Forms.RichTextBox rtbQuestion;
        private System.Windows.Forms.Panel pnlAnswer;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnNext;
    }
}

