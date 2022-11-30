
namespace NormalDistributionGraph
{
    partial class View
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
            this.components = new System.ComponentModel.Container();
            this.lblValid = new System.Windows.Forms.Label();
            this.ProbabilityPanel = new System.Windows.Forms.Panel();
            this.lblPA_X_BCalculation = new System.Windows.Forms.Label();
            this.lblPXBCalculation = new System.Windows.Forms.Label();
            this.lblPXACalculation = new System.Windows.Forms.Label();
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
            this.errorProviderMean = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderStdDev = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderA1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderA2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderB1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderB2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.curve1 = new NormalDistributionGraph.Curve();
            this.ProbabilityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStdDev)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderB2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblValid
            // 
            this.lblValid.AutoSize = true;
            this.lblValid.Location = new System.Drawing.Point(183, 66);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(0, 16);
            this.lblValid.TabIndex = 24;
            // 
            // ProbabilityPanel
            // 
            this.ProbabilityPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ProbabilityPanel.Controls.Add(this.lblPA_X_BCalculation);
            this.ProbabilityPanel.Controls.Add(this.lblPXBCalculation);
            this.ProbabilityPanel.Controls.Add(this.lblPXACalculation);
            this.ProbabilityPanel.Controls.Add(this.textBoxB2);
            this.ProbabilityPanel.Controls.Add(this.label7);
            this.ProbabilityPanel.Controls.Add(this.lblPXB);
            this.ProbabilityPanel.Controls.Add(this.lblB2);
            this.ProbabilityPanel.Controls.Add(this.lblPXA);
            this.ProbabilityPanel.Controls.Add(this.textBoxB1);
            this.ProbabilityPanel.Controls.Add(this.textBoxA2);
            this.ProbabilityPanel.Controls.Add(this.textBoxA1);
            this.ProbabilityPanel.Controls.Add(this.lblB1);
            this.ProbabilityPanel.Controls.Add(this.lblA2);
            this.ProbabilityPanel.Controls.Add(this.lblA1);
            this.ProbabilityPanel.Enabled = false;
            this.ProbabilityPanel.Location = new System.Drawing.Point(396, 12);
            this.ProbabilityPanel.Name = "ProbabilityPanel";
            this.ProbabilityPanel.Size = new System.Drawing.Size(753, 146);
            this.ProbabilityPanel.TabIndex = 23;
            // 
            // lblPA_X_BCalculation
            // 
            this.lblPA_X_BCalculation.AutoSize = true;
            this.lblPA_X_BCalculation.Location = new System.Drawing.Point(614, 66);
            this.lblPA_X_BCalculation.Name = "lblPA_X_BCalculation";
            this.lblPA_X_BCalculation.Size = new System.Drawing.Size(137, 16);
            this.lblPA_X_BCalculation.TabIndex = 19;
            this.lblPA_X_BCalculation.Text = "lblPA_X_BCalculation";
            // 
            // lblPXBCalculation
            // 
            this.lblPXBCalculation.AutoSize = true;
            this.lblPXBCalculation.Location = new System.Drawing.Point(389, 106);
            this.lblPXBCalculation.Name = "lblPXBCalculation";
            this.lblPXBCalculation.Size = new System.Drawing.Size(114, 16);
            this.lblPXBCalculation.TabIndex = 18;
            this.lblPXBCalculation.Text = "lblPXBCalculation";
            // 
            // lblPXACalculation
            // 
            this.lblPXACalculation.AutoSize = true;
            this.lblPXACalculation.Location = new System.Drawing.Point(399, 23);
            this.lblPXACalculation.Name = "lblPXACalculation";
            this.lblPXACalculation.Size = new System.Drawing.Size(114, 16);
            this.lblPXACalculation.TabIndex = 17;
            this.lblPXACalculation.Text = "lblPXACalculation";
            // 
            // textBoxB2
            // 
            this.textBoxB2.Location = new System.Drawing.Point(324, 62);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(100, 22);
            this.textBoxB2.TabIndex = 16;
            this.textBoxB2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxB2.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Probability (A<x<B):";
            // 
            // lblPXB
            // 
            this.lblPXB.AutoSize = true;
            this.lblPXB.Location = new System.Drawing.Point(301, 106);
            this.lblPXB.Name = "lblPXB";
            this.lblPXB.Size = new System.Drawing.Size(108, 16);
            this.lblPXB.TabIndex = 14;
            this.lblPXB.Text = "Probability (x>B):";
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.Location = new System.Drawing.Point(301, 65);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(20, 16);
            this.lblB2.TabIndex = 13;
            this.lblB2.Text = "B:";
            // 
            // lblPXA
            // 
            this.lblPXA.AutoSize = true;
            this.lblPXA.Location = new System.Drawing.Point(301, 24);
            this.lblPXA.Name = "lblPXA";
            this.lblPXA.Size = new System.Drawing.Size(114, 16);
            this.lblPXA.TabIndex = 12;
            this.lblPXA.Text = "Probability (x < A):";
            // 
            // textBoxB1
            // 
            this.textBoxB1.Location = new System.Drawing.Point(74, 103);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(100, 22);
            this.textBoxB1.TabIndex = 6;
            this.textBoxB1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxB1.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(74, 63);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(100, 22);
            this.textBoxA2.TabIndex = 5;
            this.textBoxA2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxA2.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(74, 23);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(100, 22);
            this.textBoxA1.TabIndex = 4;
            this.textBoxA1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxA1.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Location = new System.Drawing.Point(27, 106);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(20, 16);
            this.lblB1.TabIndex = 8;
            this.lblB1.Text = "B:";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Location = new System.Drawing.Point(27, 66);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(20, 16);
            this.lblA2.TabIndex = 7;
            this.lblA2.Text = "A:";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(27, 26);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(20, 16);
            this.lblA1.TabIndex = 6;
            this.lblA1.Text = "A:";
            // 
            // btnGenNormDist
            // 
            this.btnGenNormDist.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnGenNormDist.Enabled = false;
            this.btnGenNormDist.Location = new System.Drawing.Point(83, 137);
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
            this.lblStdDev.Location = new System.Drawing.Point(95, 105);
            this.lblStdDev.Name = "lblStdDev";
            this.lblStdDev.Size = new System.Drawing.Size(126, 16);
            this.lblStdDev.TabIndex = 22;
            this.lblStdDev.Text = "Standard Deviation:";
            // 
            // textBoxStdDev
            // 
            this.textBoxStdDev.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxStdDev.Location = new System.Drawing.Point(199, 101);
            this.textBoxStdDev.Name = "textBoxStdDev";
            this.textBoxStdDev.Size = new System.Drawing.Size(110, 22);
            this.textBoxStdDev.TabIndex = 20;
            this.textBoxStdDev.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxStdDev.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // textBoxMean
            // 
            this.textBoxMean.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxMean.Location = new System.Drawing.Point(199, 62);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(110, 22);
            this.textBoxMean.TabIndex = 19;
            this.textBoxMean.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_Validating);
            this.textBoxMean.Validated += new System.EventHandler(this.textBox_Validated);
            // 
            // lblMean
            // 
            this.lblMean.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(152, 66);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(48, 16);
            this.lblMean.TabIndex = 18;
            this.lblMean.Text = "Mean: ";
            // 
            // errorProviderMean
            // 
            this.errorProviderMean.ContainerControl = this;
            // 
            // errorProviderStdDev
            // 
            this.errorProviderStdDev.ContainerControl = this;
            // 
            // errorProviderA1
            // 
            this.errorProviderA1.ContainerControl = this;
            // 
            // errorProviderA2
            // 
            this.errorProviderA2.ContainerControl = this;
            // 
            // errorProviderB1
            // 
            this.errorProviderB1.ContainerControl = this;
            // 
            // errorProviderB2
            // 
            this.errorProviderB2.ContainerControl = this;
            // 
            // curve1
            // 
            this.curve1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.curve1.Location = new System.Drawing.Point(83, 202);
            this.curve1.Name = "curve1";
            this.curve1.Size = new System.Drawing.Size(1066, 507);
            this.curve1.TabIndex = 25;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 837);
            this.Controls.Add(this.curve1);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.ProbabilityPanel);
            this.Controls.Add(this.btnGenNormDist);
            this.Controls.Add(this.lblStdDev);
            this.Controls.Add(this.textBoxStdDev);
            this.Controls.Add(this.textBoxMean);
            this.Controls.Add(this.lblMean);
            this.Name = "View";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.View_Load);
            this.ProbabilityPanel.ResumeLayout(false);
            this.ProbabilityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStdDev)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderB2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValid;
        private System.Windows.Forms.Panel ProbabilityPanel;
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
        private System.Windows.Forms.ErrorProvider errorProviderMean;
        private System.Windows.Forms.ErrorProvider errorProviderStdDev;
        private System.Windows.Forms.ErrorProvider errorProviderA1;
        private System.Windows.Forms.ErrorProvider errorProviderA2;
        private System.Windows.Forms.ErrorProvider errorProviderB1;
        private System.Windows.Forms.ErrorProvider errorProviderB2;
        private Curve curve1;
    }
}

