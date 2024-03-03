namespace FZ767ZI_FanControl
{
    partial class FanCalibrator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBMaxSpeed = new System.Windows.Forms.Label();
            this.LBMinSpeed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.LBMaxSpeed);
            this.groupBox1.Controls.Add(this.LBMinSpeed);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calibration";
            // 
            // LBMaxSpeed
            // 
            this.LBMaxSpeed.AutoSize = true;
            this.LBMaxSpeed.Location = new System.Drawing.Point(6, 68);
            this.LBMaxSpeed.Name = "LBMaxSpeed";
            this.LBMaxSpeed.Size = new System.Drawing.Size(119, 13);
            this.LBMaxSpeed.TabIndex = 1;
            this.LBMaxSpeed.Text = "Max. speed: 0000 RPM";
            // 
            // LBMinSpeed
            // 
            this.LBMinSpeed.AutoSize = true;
            this.LBMinSpeed.Location = new System.Drawing.Point(6, 45);
            this.LBMinSpeed.Name = "LBMinSpeed";
            this.LBMinSpeed.Size = new System.Drawing.Size(110, 13);
            this.LBMinSpeed.TabIndex = 1;
            this.LBMinSpeed.Text = "Min. speed: 000 RPM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calibrate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Probe cal. data";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FanCalibrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FanCalibrator";
            this.Size = new System.Drawing.Size(225, 96);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBMaxSpeed;
        private System.Windows.Forms.Label LBMinSpeed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
