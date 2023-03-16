namespace SecondsTryApp
{
    partial class FullForm
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.autoRunBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(316, 31);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "yyyy-MM-dd HH:mm:ss";
            // 
            // autoRunBtn
            // 
            this.autoRunBtn.Location = new System.Drawing.Point(318, -1);
            this.autoRunBtn.Name = "autoRunBtn";
            this.autoRunBtn.Size = new System.Drawing.Size(21, 23);
            this.autoRunBtn.TabIndex = 1;
            this.autoRunBtn.UseVisualStyleBackColor = true;
            this.autoRunBtn.Click += new System.EventHandler(this.autoRunBtn_Click);
            // 
            // FullForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 52);
            this.Controls.Add(this.autoRunBtn);
            this.Controls.Add(this.timeLabel);
            this.MaximumSize = new System.Drawing.Size(354, 91);
            this.MinimumSize = new System.Drawing.Size(354, 91);
            this.Name = "FullForm";
            this.ShowIcon = false;
            this.Text = "SystemClock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button autoRunBtn;
    }
}

