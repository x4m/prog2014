namespace clock
{
    partial class alarm_pop_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(alarm_pop_up));
            this.alarm_popUp_okButton = new System.Windows.Forms.Button();
            this.alarm_popUp_label1 = new System.Windows.Forms.Label();
            this.alarm_popUp_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // alarm_popUp_okButton
            // 
            this.alarm_popUp_okButton.Location = new System.Drawing.Point(110, 226);
            this.alarm_popUp_okButton.Name = "alarm_popUp_okButton";
            this.alarm_popUp_okButton.Size = new System.Drawing.Size(75, 23);
            this.alarm_popUp_okButton.TabIndex = 6;
            this.alarm_popUp_okButton.Text = "ОК";
            this.alarm_popUp_okButton.UseVisualStyleBackColor = true;
            this.alarm_popUp_okButton.Click += new System.EventHandler(this.alarm_popUp_okButton_Click);
            // 
            // alarm_popUp_label1
            // 
            this.alarm_popUp_label1.AutoSize = true;
            this.alarm_popUp_label1.Font = new System.Drawing.Font("Quartz MS", 30F);
            this.alarm_popUp_label1.Location = new System.Drawing.Point(72, 21);
            this.alarm_popUp_label1.Name = "alarm_popUp_label1";
            this.alarm_popUp_label1.Size = new System.Drawing.Size(133, 49);
            this.alarm_popUp_label1.TabIndex = 4;
            this.alarm_popUp_label1.Text = "00:00";
            this.alarm_popUp_label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // alarm_popUp_textbox
            // 
            this.alarm_popUp_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.alarm_popUp_textbox.Location = new System.Drawing.Point(12, 85);
            this.alarm_popUp_textbox.Multiline = true;
            this.alarm_popUp_textbox.Name = "alarm_popUp_textbox";
            this.alarm_popUp_textbox.ReadOnly = true;
            this.alarm_popUp_textbox.Size = new System.Drawing.Size(260, 135);
            this.alarm_popUp_textbox.TabIndex = 7;
            this.alarm_popUp_textbox.Text = "Вы не ввели текст напоминания.";
            // 
            // alarm_pop_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.alarm_popUp_textbox);
            this.Controls.Add(this.alarm_popUp_okButton);
            this.Controls.Add(this.alarm_popUp_label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "alarm_pop_up";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Напоминание";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button alarm_popUp_okButton;
        public System.Windows.Forms.Label alarm_popUp_label1;
        public System.Windows.Forms.TextBox alarm_popUp_textbox;
    }
}