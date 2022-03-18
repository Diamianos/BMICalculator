
namespace Ch14Lab3
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpMeasurementSystem = new System.Windows.Forms.GroupBox();
            this.rbnMetric = new System.Windows.Forms.RadioButton();
            this.rbnImperial = new System.Windows.Forms.RadioButton();
            this.grpMeasurements = new System.Windows.Forms.GroupBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWeightValue = new System.Windows.Forms.Label();
            this.lblHeightValue = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.grpResult = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMeasurementSystem.SuspendLayout();
            this.grpMeasurements.SuspendLayout();
            this.grpResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMeasurementSystem
            // 
            this.grpMeasurementSystem.Controls.Add(this.rbnMetric);
            this.grpMeasurementSystem.Controls.Add(this.rbnImperial);
            this.grpMeasurementSystem.Location = new System.Drawing.Point(11, 11);
            this.grpMeasurementSystem.Name = "grpMeasurementSystem";
            this.grpMeasurementSystem.Size = new System.Drawing.Size(235, 73);
            this.grpMeasurementSystem.TabIndex = 0;
            this.grpMeasurementSystem.TabStop = false;
            this.grpMeasurementSystem.Text = "Measurement System";
            // 
            // rbnMetric
            // 
            this.rbnMetric.AutoSize = true;
            this.rbnMetric.Location = new System.Drawing.Point(144, 26);
            this.rbnMetric.Name = "rbnMetric";
            this.rbnMetric.Size = new System.Drawing.Size(69, 24);
            this.rbnMetric.TabIndex = 1;
            this.rbnMetric.TabStop = true;
            this.rbnMetric.Text = "&Metric";
            this.rbnMetric.UseVisualStyleBackColor = true;
            this.rbnMetric.CheckedChanged += new System.EventHandler(this.rbnMetric_CheckedChanged);
            // 
            // rbnImperial
            // 
            this.rbnImperial.AutoSize = true;
            this.rbnImperial.Checked = true;
            this.rbnImperial.Location = new System.Drawing.Point(17, 26);
            this.rbnImperial.Name = "rbnImperial";
            this.rbnImperial.Size = new System.Drawing.Size(82, 24);
            this.rbnImperial.TabIndex = 0;
            this.rbnImperial.TabStop = true;
            this.rbnImperial.Text = "&Imperial";
            this.rbnImperial.UseVisualStyleBackColor = true;
            this.rbnImperial.CheckedChanged += new System.EventHandler(this.rbnImperial_CheckedChanged);
            // 
            // grpMeasurements
            // 
            this.grpMeasurements.Controls.Add(this.txtWeight);
            this.grpMeasurements.Controls.Add(this.txtHeight);
            this.grpMeasurements.Controls.Add(this.lblWeightValue);
            this.grpMeasurements.Controls.Add(this.lblHeightValue);
            this.grpMeasurements.Controls.Add(this.lblWeight);
            this.grpMeasurements.Controls.Add(this.lblHeight);
            this.grpMeasurements.Location = new System.Drawing.Point(12, 90);
            this.grpMeasurements.Name = "grpMeasurements";
            this.grpMeasurements.Size = new System.Drawing.Size(234, 106);
            this.grpMeasurements.TabIndex = 1;
            this.grpMeasurements.TabStop = false;
            this.grpMeasurements.Text = "Measurements";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(79, 70);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 27);
            this.txtWeight.TabIndex = 3;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(79, 28);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 27);
            this.txtHeight.TabIndex = 1;
            // 
            // lblWeightValue
            // 
            this.lblWeightValue.AutoSize = true;
            this.lblWeightValue.Location = new System.Drawing.Point(185, 73);
            this.lblWeightValue.Name = "lblWeightValue";
            this.lblWeightValue.Size = new System.Drawing.Size(28, 20);
            this.lblWeightValue.TabIndex = 3;
            this.lblWeightValue.Text = "lbs";
            // 
            // lblHeightValue
            // 
            this.lblHeightValue.AutoSize = true;
            this.lblHeightValue.Location = new System.Drawing.Point(185, 31);
            this.lblHeightValue.Name = "lblHeightValue";
            this.lblHeightValue.Size = new System.Drawing.Size(21, 20);
            this.lblHeightValue.TabIndex = 2;
            this.lblHeightValue.Text = "in";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(14, 73);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 20);
            this.lblWeight.TabIndex = 2;
            this.lblWeight.Text = "&Weight:";
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(16, 31);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(57, 20);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "&Height:";
            // 
            // grpResult
            // 
            this.grpResult.Controls.Add(this.lblResult);
            this.grpResult.Location = new System.Drawing.Point(11, 202);
            this.grpResult.Name = "grpResult";
            this.grpResult.Size = new System.Drawing.Size(235, 130);
            this.grpResult.TabIndex = 2;
            this.grpResult.TabStop = false;
            this.grpResult.Text = "Result";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(10, 23);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(212, 94);
            this.lblResult.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 338);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(98, 46);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(116, 338);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(61, 46);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(183, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 46);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(258, 396);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.grpResult);
            this.Controls.Add(this.grpMeasurements);
            this.Controls.Add(this.grpMeasurementSystem);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.grpMeasurementSystem.ResumeLayout(false);
            this.grpMeasurementSystem.PerformLayout();
            this.grpMeasurements.ResumeLayout(false);
            this.grpMeasurements.PerformLayout();
            this.grpResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMeasurementSystem;
        private System.Windows.Forms.RadioButton rbnMetric;
        private System.Windows.Forms.RadioButton rbnImperial;
        private System.Windows.Forms.GroupBox grpMeasurements;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWeightValue;
        private System.Windows.Forms.Label lblHeightValue;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox grpResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

