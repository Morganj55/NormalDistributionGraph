
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.lblValid = new System.Windows.Forms.Label();
            this.ProbabilityPanel = new System.Windows.Forms.Panel();
            this.mike = new System.Windows.Forms.Label();
            this.tony = new System.Windows.Forms.Label();
            this.steve = new System.Windows.Forms.Label();
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
            this.newCurve1 = new CustomControl.CustomCurve();
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
            this.lblValid.Location = new System.Drawing.Point(69, 42);
            this.lblValid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValid.Name = "lblValid";
            this.lblValid.Size = new System.Drawing.Size(0, 16);
            this.lblValid.TabIndex = 24;
            // 
            // ProbabilityPanel
            // 
            this.ProbabilityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ProbabilityPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ProbabilityPanel.Controls.Add(this.mike);
            this.ProbabilityPanel.Controls.Add(this.tony);
            this.ProbabilityPanel.Controls.Add(this.steve);
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
            this.ProbabilityPanel.Location = new System.Drawing.Point(27, 546);
            this.ProbabilityPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ProbabilityPanel.Name = "ProbabilityPanel";
            this.ProbabilityPanel.Size = new System.Drawing.Size(1004, 180);
            this.ProbabilityPanel.TabIndex = 23;
            // 
            // mike
            // 
            this.mike.AutoSize = true;
            this.mike.Location = new System.Drawing.Point(819, 81);
            this.mike.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mike.Name = "mike";
            this.mike.Size = new System.Drawing.Size(0, 16);
            this.mike.TabIndex = 19;
            // 
            // tony
            // 
            this.tony.AutoSize = true;
            this.tony.Location = new System.Drawing.Point(519, 130);
            this.tony.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tony.Name = "tony";
            this.tony.Size = new System.Drawing.Size(0, 16);
            this.tony.TabIndex = 18;
            // 
            // steve
            // 
            this.steve.AutoSize = true;
            this.steve.Location = new System.Drawing.Point(532, 28);
            this.steve.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.steve.Name = "steve";
            this.steve.Size = new System.Drawing.Size(0, 16);
            this.steve.TabIndex = 17;
            // 
            // textBoxB2
            // 
            this.textBoxB2.Location = new System.Drawing.Point(432, 76);
            this.textBoxB2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxB2.Name = "textBoxB2";
            this.textBoxB2.Size = new System.Drawing.Size(132, 22);
            this.textBoxB2.TabIndex = 16;
            this.textBoxB2.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxProbability_Validating);
            this.textBoxB2.Validated += new System.EventHandler(this.textBoxProbability_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(680, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Probability (A<x<B):";
            // 
            // lblPXB
            // 
            this.lblPXB.AutoSize = true;
            this.lblPXB.Location = new System.Drawing.Point(401, 130);
            this.lblPXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPXB.Name = "lblPXB";
            this.lblPXB.Size = new System.Drawing.Size(108, 16);
            this.lblPXB.TabIndex = 14;
            this.lblPXB.Text = "Probability (x>B):";
            // 
            // lblB2
            // 
            this.lblB2.AutoSize = true;
            this.lblB2.Location = new System.Drawing.Point(401, 80);
            this.lblB2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblB2.Name = "lblB2";
            this.lblB2.Size = new System.Drawing.Size(20, 16);
            this.lblB2.TabIndex = 13;
            this.lblB2.Text = "B:";
            // 
            // lblPXA
            // 
            this.lblPXA.AutoSize = true;
            this.lblPXA.Location = new System.Drawing.Point(401, 30);
            this.lblPXA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPXA.Name = "lblPXA";
            this.lblPXA.Size = new System.Drawing.Size(114, 16);
            this.lblPXA.TabIndex = 12;
            this.lblPXA.Text = "Probability (x < A):";
            // 
            // textBoxB1
            // 
            this.textBoxB1.Location = new System.Drawing.Point(99, 127);
            this.textBoxB1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxB1.Name = "textBoxB1";
            this.textBoxB1.Size = new System.Drawing.Size(132, 22);
            this.textBoxB1.TabIndex = 6;
            this.textBoxB1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxProbability_Validating);
            this.textBoxB1.Validated += new System.EventHandler(this.textBoxProbability_Validated);
            // 
            // textBoxA2
            // 
            this.textBoxA2.Location = new System.Drawing.Point(99, 78);
            this.textBoxA2.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxA2.Name = "textBoxA2";
            this.textBoxA2.Size = new System.Drawing.Size(132, 22);
            this.textBoxA2.TabIndex = 5;
            this.textBoxA2.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxProbability_Validating);
            this.textBoxA2.Validated += new System.EventHandler(this.textBoxProbability_Validated);
            // 
            // textBoxA1
            // 
            this.textBoxA1.Location = new System.Drawing.Point(99, 28);
            this.textBoxA1.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxA1.Name = "textBoxA1";
            this.textBoxA1.Size = new System.Drawing.Size(132, 22);
            this.textBoxA1.TabIndex = 4;
            this.textBoxA1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxProbability_Validating);
            this.textBoxA1.Validated += new System.EventHandler(this.textBoxProbability_Validated);
            // 
            // lblB1
            // 
            this.lblB1.AutoSize = true;
            this.lblB1.Location = new System.Drawing.Point(36, 130);
            this.lblB1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblB1.Name = "lblB1";
            this.lblB1.Size = new System.Drawing.Size(20, 16);
            this.lblB1.TabIndex = 8;
            this.lblB1.Text = "B:";
            // 
            // lblA2
            // 
            this.lblA2.AutoSize = true;
            this.lblA2.Location = new System.Drawing.Point(36, 81);
            this.lblA2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA2.Name = "lblA2";
            this.lblA2.Size = new System.Drawing.Size(20, 16);
            this.lblA2.TabIndex = 7;
            this.lblA2.Text = "A:";
            // 
            // lblA1
            // 
            this.lblA1.AutoSize = true;
            this.lblA1.Location = new System.Drawing.Point(36, 32);
            this.lblA1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblA1.Name = "lblA1";
            this.lblA1.Size = new System.Drawing.Size(20, 16);
            this.lblA1.TabIndex = 6;
            this.lblA1.Text = "A:";
            // 
            // btnGenNormDist
            // 
            this.btnGenNormDist.Location = new System.Drawing.Point(691, 36);
            this.btnGenNormDist.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenNormDist.Name = "btnGenNormDist";
            this.btnGenNormDist.Size = new System.Drawing.Size(375, 28);
            this.btnGenNormDist.TabIndex = 21;
            this.btnGenNormDist.Text = "Generate Normal Distribution";
            this.btnGenNormDist.UseVisualStyleBackColor = true;
            this.btnGenNormDist.Click += new System.EventHandler(this.btnGenNormDist_Click);
            // 
            // lblStdDev
            // 
            this.lblStdDev.AutoSize = true;
            this.lblStdDev.Location = new System.Drawing.Point(319, 42);
            this.lblStdDev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStdDev.Name = "lblStdDev";
            this.lblStdDev.Size = new System.Drawing.Size(126, 16);
            this.lblStdDev.TabIndex = 22;
            this.lblStdDev.Text = "Standard Deviation:";
            // 
            // textBoxStdDev
            // 
            this.textBoxStdDev.Location = new System.Drawing.Point(457, 37);
            this.textBoxStdDev.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxStdDev.Name = "textBoxStdDev";
            this.textBoxStdDev.Size = new System.Drawing.Size(145, 22);
            this.textBoxStdDev.TabIndex = 20;
            this.textBoxStdDev.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStats_Validating);
            this.textBoxStdDev.Validated += new System.EventHandler(this.textBoxStats_Validated);
            // 
            // textBoxMean
            // 
            this.textBoxMean.Location = new System.Drawing.Point(91, 37);
            this.textBoxMean.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.Size = new System.Drawing.Size(145, 22);
            this.textBoxMean.TabIndex = 19;
            this.textBoxMean.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxStats_Validating);
            this.textBoxMean.Validated += new System.EventHandler(this.textBoxStats_Validated);
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(28, 42);
            this.lblMean.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            // newCurve1
            // 
            this.newCurve1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newCurve1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newCurve1.graphSDLines = null;
            this.newCurve1.graphXYArray = null;
            this.newCurve1.Location = new System.Drawing.Point(49, 94);
            this.newCurve1.Name = "newCurve1";
            this.newCurve1.rectangleArea = new System.Drawing.Rectangle(3, 3, 959, 387);
            this.newCurve1.Size = new System.Drawing.Size(967, 395);
            this.newCurve1.startingPoint = ((System.Drawing.PointF)(resources.GetObject("newCurve1.startingPoint")));
            this.newCurve1.TabIndex = 25;
            this.newCurve1.Resize += new System.EventHandler(this.customContolResize);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 782);
            this.Controls.Add(this.newCurve1);
            this.Controls.Add(this.lblValid);
            this.Controls.Add(this.ProbabilityPanel);
            this.Controls.Add(this.btnGenNormDist);
            this.Controls.Add(this.lblStdDev);
            this.Controls.Add(this.textBoxStdDev);
            this.Controls.Add(this.textBoxMean);
            this.Controls.Add(this.lblMean);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View";
            this.Text = "MSO-TrainingApp1";
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
        private System.Windows.Forms.Label mike;
        private System.Windows.Forms.Label tony;
        private System.Windows.Forms.Label steve;
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
        private CustomControl.CustomCurve newCurve1;
    }
}

