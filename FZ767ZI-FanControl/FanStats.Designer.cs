namespace F767ZI_FanControl
{
    partial class FanStats
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
            this.LBFanName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LBMode = new System.Windows.Forms.Label();
            this.LBReqValue = new System.Windows.Forms.Label();
            this.LBSpeed = new System.Windows.Forms.Label();
            this.LBDutyCycle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBFanName
            // 
            this.LBFanName.AutoSize = true;
            this.LBFanName.Location = new System.Drawing.Point(88, 3);
            this.LBFanName.Name = "LBFanName";
            this.LBFanName.Size = new System.Drawing.Size(38, 13);
            this.LBFanName.TabIndex = 0;
            this.LBFanName.Text = "Fan #:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mode:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Requested value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Duty cycle:";
            // 
            // LBMode
            // 
            this.LBMode.AutoSize = true;
            this.LBMode.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBMode.Location = new System.Drawing.Point(106, 20);
            this.LBMode.Name = "LBMode";
            this.LBMode.Size = new System.Drawing.Size(70, 26);
            this.LBMode.TabIndex = 1;
            this.LBMode.Text = "MODE";
            // 
            // LBReqValue
            // 
            this.LBReqValue.AutoSize = true;
            this.LBReqValue.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBReqValue.Location = new System.Drawing.Point(106, 46);
            this.LBReqValue.Name = "LBReqValue";
            this.LBReqValue.Size = new System.Drawing.Size(69, 26);
            this.LBReqValue.TabIndex = 1;
            this.LBReqValue.Text = "0 RPM";
            // 
            // LBSpeed
            // 
            this.LBSpeed.AutoSize = true;
            this.LBSpeed.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBSpeed.Location = new System.Drawing.Point(106, 72);
            this.LBSpeed.Name = "LBSpeed";
            this.LBSpeed.Size = new System.Drawing.Size(69, 26);
            this.LBSpeed.TabIndex = 1;
            this.LBSpeed.Text = "0 RPM";
            // 
            // LBDutyCycle
            // 
            this.LBDutyCycle.AutoSize = true;
            this.LBDutyCycle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LBDutyCycle.Location = new System.Drawing.Point(106, 98);
            this.LBDutyCycle.Name = "LBDutyCycle";
            this.LBDutyCycle.Size = new System.Drawing.Size(40, 26);
            this.LBDutyCycle.TabIndex = 1;
            this.LBDutyCycle.Text = "0%";
            // 
            // FanStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LBDutyCycle);
            this.Controls.Add(this.LBSpeed);
            this.Controls.Add(this.LBReqValue);
            this.Controls.Add(this.LBMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBFanName);
            this.Name = "FanStats";
            this.Size = new System.Drawing.Size(225, 142);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBFanName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBMode;
        private System.Windows.Forms.Label LBReqValue;
        private System.Windows.Forms.Label LBSpeed;
        private System.Windows.Forms.Label LBDutyCycle;
    }
}
