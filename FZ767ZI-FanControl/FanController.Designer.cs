namespace FZ767ZI_FanControl
{
    partial class FanController
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
            this.RBDirect = new System.Windows.Forms.RadioButton();
            this.RBPControl = new System.Windows.Forms.RadioButton();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.LBSpeed = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.LBSpeed);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.RBPControl);
            this.groupBox1.Controls.Add(this.RBDirect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // RBDirect
            // 
            this.RBDirect.AutoSize = true;
            this.RBDirect.Location = new System.Drawing.Point(6, 19);
            this.RBDirect.Name = "RBDirect";
            this.RBDirect.Size = new System.Drawing.Size(139, 17);
            this.RBDirect.TabIndex = 0;
            this.RBDirect.Text = "Direct mode (duty cycle)";
            this.RBDirect.UseVisualStyleBackColor = true;
            this.RBDirect.CheckedChanged += new System.EventHandler(this.RBDirect_CheckedChanged);
            // 
            // RBPControl
            // 
            this.RBPControl.AutoSize = true;
            this.RBPControl.Checked = true;
            this.RBPControl.Location = new System.Drawing.Point(6, 42);
            this.RBPControl.Name = "RBPControl";
            this.RBPControl.Size = new System.Drawing.Size(135, 17);
            this.RBPControl.TabIndex = 1;
            this.RBPControl.TabStop = true;
            this.RBPControl.Text = "P-Control mode (speed)";
            this.RBPControl.UseVisualStyleBackColor = true;
            this.RBPControl.CheckedChanged += new System.EventHandler(this.RBPControl_CheckedChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 65);
            this.trackBar1.Maximum = 3000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(216, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // LBSpeed
            // 
            this.LBSpeed.AutoSize = true;
            this.LBSpeed.Location = new System.Drawing.Point(90, 97);
            this.LBSpeed.Name = "LBSpeed";
            this.LBSpeed.Size = new System.Drawing.Size(40, 13);
            this.LBSpeed.TabIndex = 3;
            this.LBSpeed.Text = "0 RPM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(75, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FanController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "FanController";
            this.Size = new System.Drawing.Size(225, 142);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LBSpeed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.RadioButton RBPControl;
        private System.Windows.Forms.RadioButton RBDirect;
    }
}
