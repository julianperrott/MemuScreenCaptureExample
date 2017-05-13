namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cboMethodOfCapture = new System.Windows.Forms.ComboBox();
            this.labDuration = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Capture";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 800);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cboMethodOfCapture
            // 
            this.cboMethodOfCapture.FormattingEnabled = true;
            this.cboMethodOfCapture.Items.AddRange(new object[] {
            "user32.GetWindowRect()",
            "Managed.Adb Device.Screenshot"});
            this.cboMethodOfCapture.Location = new System.Drawing.Point(226, 8);
            this.cboMethodOfCapture.Name = "cboMethodOfCapture";
            this.cboMethodOfCapture.Size = new System.Drawing.Size(229, 21);
            this.cboMethodOfCapture.TabIndex = 2;
            this.cboMethodOfCapture.SelectedIndexChanged += new System.EventHandler(this.cboMethodOfCapture_SelectedIndexChanged);
            // 
            // labDuration
            // 
            this.labDuration.AutoSize = true;
            this.labDuration.Location = new System.Drawing.Point(223, 38);
            this.labDuration.Name = "labDuration";
            this.labDuration.Size = new System.Drawing.Size(47, 13);
            this.labDuration.TabIndex = 3;
            this.labDuration.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Method of capture:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 866);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labDuration);
            this.Controls.Add(this.cboMethodOfCapture);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboMethodOfCapture;
        private System.Windows.Forms.Label labDuration;
        private System.Windows.Forms.Label label2;
    }
}

