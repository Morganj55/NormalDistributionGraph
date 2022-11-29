﻿
namespace NormalDistributionGraph
{
    partial class Form1
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
            this.lblValid = new System.Windows.Forms.Label();
            this.ProbPanel = new System.Windows.Forms.Panel();
            this.textBoxB2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPXB = new System.Windows.Forms.Label();
            this.lblB2 = new System.Windows.Forms.Label();
            this.lblPXA = new System.Windows.Forms.Label();
            this.textBoxB1 = new System.Windows.Forms.TextBox();
            this.textBoxA2 = new System.Windows.Forms.TextBox();
            this.textBoxA1 = new System.Windows.Forms.TextBox();
            this.lblB1 = new System.Windows.Forms.Label();
            this.lblA2 = new System.Windows.Forms.Label();
            this.lblA1 = new System.Windows.Forms.Label();
            this.btnGenNormDist = new System.Windows.Forms.Button();
            this.lblStdDev = new System.Windows.Forms.Label();
            this.textBoxStdDev = new System.Windows.Forms.TextBox();
            this.textBoxMean = new System.Windows.Forms.TextBox();
            this.lblMean = new System.Windows.Forms.Label();
            this.lblPXACalculation = new System.Windows.Forms.Label();
            this.lblPXBCalculation = new System.Windows.Forms.Label();
            this.lblPA_X_BCalculation = new System.Windows.Forms.Label();
            this.ProbPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(183, 66);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(0, 13);
            this.lblValid.TabIndex = 24;
            // 
            // ProbPanel
            // 
            this.ProbPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProbPanel.Controls.Add(this.lblPA_X_BCalculation);
            this.ProbPanel.Controls.Add(this.lblPXBCalculation);
            this.ProbPanel.Controls.Add(this.lblPXACalculation);
            this.ProbPanel.Controls.Add(this.textBoxB2);
            this.ProbPanel.Controls.Add(this.label7);
            this.ProbPanel.Controls.Add(this.lblPXB);
            this.ProbPanel.Controls.Add(this.lblB2);
            this.ProbPanel.Controls.Add(this.lblPXA);
            this.ProbPanel.Controls.Add(this.textBoxB1);
            this.ProbPanel.Controls.Add(this.textBoxA2);
            this.ProbPanel.Controls.Add(this.textBoxA1);
            this.ProbPanel.Controls.Add(this.lblB1);
            this.ProbPanel.Controls.Add(this.lblA2);
            this.ProbPanel.Controls.Add(this.lblA1);
            this.ProbPanel.Location = new System.Drawing.Point(396, 12);
            this.ProbPanel.Name = "ProbPanel";
            this.ProbPanel.Size = new System.Drawing.Size(753, 146);
            this.ProbPanel.TabIndex = 23;
            // 
            // textBoxB2
            // 
            this.textBoxB2.Location = new System.Drawing.Point(324, 62);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(100, 20);
            this.textBoxB2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Probability (A<x<B):";
            // 
            // lblPXB
            // 
            this.lblPXB.AutoSize = true;
            this.lblPXB.Location = new System.Drawing.Point(301, 106);
            this.lblPXB.Name = "lblPXB";
            this.lblPXB.Size = new System.Drawing.Size(85, 13);
            this.lblPXB.TabIndex = 14;
            this.lblPXB.Text = "Probability (x>B):";
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.Location = new System.Drawing.Point(301, 65);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(17, 13);
            this.lblB2.TabIndex = 13;
            this.lblB2.Text = "B:";
            // 
            // lblPXA
            // 
            this.lblPXA.AutoSize = true;
            this.lblPXA.Location = new System.Drawing.Point(301, 24);
            this.lblPXA.Name = "lblPXA";
            this.lblPXA.Size = new System.Drawing.Size(91, 13);
            this.lblPXA.TabIndex = 12;
            this.lblPXA.Text = "Probability (x < A):";
            // 
            // textBoxB1
            // 
            this.textBoxB1.Location = new System.Drawing.Point(74, 103);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(100, 20);
            this.textBoxB1.TabIndex = 6;
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(74, 63);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(100, 20);
            this.textBoxA2.TabIndex = 5;
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(74, 23);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(100, 20);
            this.textBoxA1.TabIndex = 4;
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Location = new System.Drawing.Point(27, 106);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(17, 13);
            this.lblB1.TabIndex = 8;
            this.lblB1.Text = "B:";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Location = new System.Drawing.Point(27, 66);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(17, 13);
            this.lblA2.TabIndex = 7;
            this.lblA2.Text = "A:";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(27, 26);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(17, 13);
            this.lblA1.TabIndex = 6;
            this.lblA1.Text = "A:";
            // 
            // btnGenNormDist
            // 
            this.btnGenNormDist.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenNormDist.Location = new System.Drawing.Point(67, 118);
            this.btnGenNormDist.Name = "btnGenNormDist";
            this.btnGenNormDist.Size = new System.Drawing.Size(281, 23);
            this.btnGenNormDist.TabIndex = 21;
            this.btnGenNormDist.Text = "Generate Normal Distribution";
            this.btnGenNormDist.UseVisualStyleBackColor = true;
            // 
            // lblStdDev
            // 
            this.lblStdDev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblStdDev.AutoSize = true;
            this.lblStdDev.Location = new System.Drawing.Point(79, 86);
            this.lblStdDev.Name = "lblStdDev";
            this.lblStdDev.Size = new System.Drawing.Size(101, 13);
            this.lblStdDev.TabIndex = 22;
            this.lblStdDev.Text = "Standard Deviation:";
            // 
            // textBoxStdDev
            // 
            this.textBoxStdDev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxStdDev.Location = new System.Drawing.Point(183, 82);
            this.textBoxStdDev.Name = "textBoxStdDev";
            this.textBoxStdDev.Size = new System.Drawing.Size(110, 20);
            this.textBoxStdDev.TabIndex = 20;
            // 
            // textBoxMean
            // 
            this.textBoxMean.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxMean.Location = new System.Drawing.Point(183, 43);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(110, 20);
            this.textBoxMean.TabIndex = 19;
            // 
            // lblMean
            // 
            this.lblMean.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(136, 47);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(40, 13);
            this.lblMean.TabIndex = 18;
            this.lblMean.Text = "Mean: ";
            // 
            // lblPXACalculation
            // 
            this.lblPXACalculation.AutoSize = true;
            this.lblPXACalculation.Location = new System.Drawing.Point(399, 23);
            this.lblPXACalculation.Name = "lblPXACalculation";
            this.lblPXACalculation.Size = new System.Drawing.Size(90, 13);
            this.lblPXACalculation.TabIndex = 17;
            this.lblPXACalculation.Text = "lblPXACalculation";
            // 
            // lblPXBCalculation
            // 
            this.lblPXBCalculation.AutoSize = true;
            this.lblPXBCalculation.Location = new System.Drawing.Point(389, 106);
            this.lblPXBCalculation.Name = "lblPXBCalculation";
            this.lblPXBCalculation.Size = new System.Drawing.Size(90, 13);
            this.lblPXBCalculation.TabIndex = 18;
            this.lblPXBCalculation.Text = "lblPXBCalculation";
            // 
            // lblPA_X_BCalculation
            // 
            this.lblPA_X_BCalculation.AutoSize = true;
            this.lblPA_X_BCalculation.Location = new System.Drawing.Point(614, 66);
            this.lblPA_X_BCalculation.Name = "lblPA_X_BCalculation";
            this.lblPA_X_BCalculation.Size = new System.Drawing.Size(109, 13);
            this.lblPA_X_BCalculation.TabIndex = 19;
            this.lblPA_X_BCalculation.Text = "lblPA_X_BCalculation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 798);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.ProbPanel);
            this.Controls.Add(this.btnGenNormDist);
            this.Controls.Add(this.lblStdDev);
            this.Controls.Add(this.textBoxStdDev);
            this.Controls.Add(this.textBoxMean);
            this.Controls.Add(this.lblMean);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ProbPanel.ResumeLayout(false);
            this.ProbPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Panel ProbPanel;
        private System.Windows.Forms.Label lblPA_X_BCalculation;
        private System.Windows.Forms.Label lblPXBCalculation;
        private System.Windows.Forms.Label lblPXACalculation;
        private System.Windows.Forms.TextBox textBoxB2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPXB;
        private System.Windows.Forms.Label lblB2;
        private System.Windows.Forms.Label lblPXA;
        private System.Windows.Forms.TextBox textBoxB1;
        private System.Windows.Forms.TextBox textBoxA2;
        private System.Windows.Forms.TextBox textBoxA1;
        private System.Windows.Forms.Label lblB1;
        private System.Windows.Forms.Label lblA2;
        private System.Windows.Forms.Label lblA1;
        private System.Windows.Forms.Button btnGenNormDist;
        private System.Windows.Forms.Label lblStdDev;
        private System.Windows.Forms.TextBox textBoxStdDev;
        private System.Windows.Forms.TextBox textBoxMean;
        private System.Windows.Forms.Label lblMean;
    }
}

