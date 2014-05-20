namespace clock
{
    partial class main_form
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.date_label = new System.Windows.Forms.Label();
            this.clock_label = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.alarm_groupBox = new System.Windows.Forms.GroupBox();
            this.alarm_toneDirButton = new System.Windows.Forms.Button();
            this.alarm_message_label = new System.Windows.Forms.Label();
            this.alarm_okButton = new System.Windows.Forms.Button();
            this.alarm_checkbox = new System.Windows.Forms.CheckBox();
            this.alarm_textbox = new System.Windows.Forms.TextBox();
            this.alarm_minutes_label = new System.Windows.Forms.Label();
            this.alarm_hour_label = new System.Windows.Forms.Label();
            this.alarm_minutes_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.alarm_hours_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.alarm_clock_label = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.timer_restartButton = new System.Windows.Forms.Button();
            this.timer_label = new System.Windows.Forms.Label();
            this.timer_startButton = new System.Windows.Forms.Button();
            this.timer_groupBox = new System.Windows.Forms.GroupBox();
            this.timer_seconds_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.timer_minutes_label = new System.Windows.Forms.Label();
            this.timer_seconds_label = new System.Windows.Forms.Label();
            this.timer_minutes_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sec_listBox = new System.Windows.Forms.ListBox();
            this.sec_addButton = new System.Windows.Forms.Button();
            this.sec_resetButton = new System.Windows.Forms.Button();
            this.sec_listLabel = new System.Windows.Forms.Label();
            this.sec_startButton = new System.Windows.Forms.Button();
            this.sec_label = new System.Windows.Forms.Label();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.timerTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerSec = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.alarm_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_minutes_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_hours_numericUpDown)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.timer_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer_seconds_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer_minutes_numericUpDown)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(545, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GreenYellow;
            this.tabPage1.Controls.Add(this.date_label);
            this.tabPage1.Controls.Add(this.clock_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(537, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Часы";
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Quartz MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_label.ForeColor = System.Drawing.Color.Crimson;
            this.date_label.Location = new System.Drawing.Point(114, 187);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(291, 58);
            this.date_label.TabIndex = 1;
            this.date_label.Text = "00.00.0000";
            this.date_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clock_label
            // 
            this.clock_label.AutoSize = true;
            this.clock_label.Font = new System.Drawing.Font("Quartz MS", 80F);
            this.clock_label.ForeColor = System.Drawing.Color.Crimson;
            this.clock_label.Location = new System.Drawing.Point(6, 3);
            this.clock_label.Name = "clock_label";
            this.clock_label.Size = new System.Drawing.Size(517, 129);
            this.clock_label.TabIndex = 0;
            this.clock_label.Text = "00:00:00";
            this.clock_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.alarm_groupBox);
            this.tabPage2.Controls.Add(this.alarm_clock_label);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(537, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Будильник";
            // 
            // alarm_groupBox
            // 
            this.alarm_groupBox.Controls.Add(this.alarm_toneDirButton);
            this.alarm_groupBox.Controls.Add(this.alarm_message_label);
            this.alarm_groupBox.Controls.Add(this.alarm_okButton);
            this.alarm_groupBox.Controls.Add(this.alarm_checkbox);
            this.alarm_groupBox.Controls.Add(this.alarm_textbox);
            this.alarm_groupBox.Controls.Add(this.alarm_minutes_label);
            this.alarm_groupBox.Controls.Add(this.alarm_hour_label);
            this.alarm_groupBox.Controls.Add(this.alarm_minutes_numericUpDown);
            this.alarm_groupBox.Controls.Add(this.alarm_hours_numericUpDown);
            this.alarm_groupBox.ForeColor = System.Drawing.Color.White;
            this.alarm_groupBox.Location = new System.Drawing.Point(3, 108);
            this.alarm_groupBox.Name = "alarm_groupBox";
            this.alarm_groupBox.Size = new System.Drawing.Size(528, 141);
            this.alarm_groupBox.TabIndex = 3;
            this.alarm_groupBox.TabStop = false;
            this.alarm_groupBox.Text = "Настроить будильник";
            // 
            // alarm_toneDirButton
            // 
            this.alarm_toneDirButton.ForeColor = System.Drawing.Color.Black;
            this.alarm_toneDirButton.Location = new System.Drawing.Point(219, 79);
            this.alarm_toneDirButton.Name = "alarm_toneDirButton";
            this.alarm_toneDirButton.Size = new System.Drawing.Size(114, 22);
            this.alarm_toneDirButton.TabIndex = 8;
            this.alarm_toneDirButton.Text = "Выбрать мелодию";
            this.alarm_toneDirButton.UseVisualStyleBackColor = true;
            this.alarm_toneDirButton.Click += new System.EventHandler(this.alarm_toneDirButton_Click);
            // 
            // alarm_message_label
            // 
            this.alarm_message_label.AutoSize = true;
            this.alarm_message_label.Location = new System.Drawing.Point(6, 64);
            this.alarm_message_label.Name = "alarm_message_label";
            this.alarm_message_label.Size = new System.Drawing.Size(130, 13);
            this.alarm_message_label.TabIndex = 7;
            this.alarm_message_label.Text = "Сообщение будильника:";
            // 
            // alarm_okButton
            // 
            this.alarm_okButton.BackColor = System.Drawing.Color.Transparent;
            this.alarm_okButton.ForeColor = System.Drawing.Color.Black;
            this.alarm_okButton.Location = new System.Drawing.Point(407, 112);
            this.alarm_okButton.Name = "alarm_okButton";
            this.alarm_okButton.Size = new System.Drawing.Size(112, 25);
            this.alarm_okButton.TabIndex = 4;
            this.alarm_okButton.Text = "Свернуть в трей";
            this.alarm_okButton.UseVisualStyleBackColor = false;
            this.alarm_okButton.Click += new System.EventHandler(this.alarm_okButton_Click);
            // 
            // alarm_checkbox
            // 
            this.alarm_checkbox.AutoSize = true;
            this.alarm_checkbox.Location = new System.Drawing.Point(9, 120);
            this.alarm_checkbox.Name = "alarm_checkbox";
            this.alarm_checkbox.Size = new System.Drawing.Size(75, 17);
            this.alarm_checkbox.TabIndex = 3;
            this.alarm_checkbox.Text = "вкл/выкл";
            this.alarm_checkbox.UseVisualStyleBackColor = true;
            this.alarm_checkbox.CheckedChanged += new System.EventHandler(this.alarm_checkbox_CheckedChanged);
            // 
            // alarm_textbox
            // 
            this.alarm_textbox.Location = new System.Drawing.Point(6, 80);
            this.alarm_textbox.Name = "alarm_textbox";
            this.alarm_textbox.Size = new System.Drawing.Size(207, 20);
            this.alarm_textbox.TabIndex = 3;
            // 
            // alarm_minutes_label
            // 
            this.alarm_minutes_label.AutoSize = true;
            this.alarm_minutes_label.Location = new System.Drawing.Point(176, 26);
            this.alarm_minutes_label.Name = "alarm_minutes_label";
            this.alarm_minutes_label.Size = new System.Drawing.Size(45, 13);
            this.alarm_minutes_label.TabIndex = 3;
            this.alarm_minutes_label.Text = "минуты";
            // 
            // alarm_hour_label
            // 
            this.alarm_hour_label.AutoSize = true;
            this.alarm_hour_label.Location = new System.Drawing.Point(66, 26);
            this.alarm_hour_label.Name = "alarm_hour_label";
            this.alarm_hour_label.Size = new System.Drawing.Size(32, 13);
            this.alarm_hour_label.TabIndex = 6;
            this.alarm_hour_label.Text = "часы";
            // 
            // alarm_minutes_numericUpDown
            // 
            this.alarm_minutes_numericUpDown.Location = new System.Drawing.Point(104, 19);
            this.alarm_minutes_numericUpDown.Name = "alarm_minutes_numericUpDown";
            this.alarm_minutes_numericUpDown.Size = new System.Drawing.Size(56, 20);
            this.alarm_minutes_numericUpDown.TabIndex = 5;
            // 
            // alarm_hours_numericUpDown
            // 
            this.alarm_hours_numericUpDown.Location = new System.Drawing.Point(6, 19);
            this.alarm_hours_numericUpDown.Name = "alarm_hours_numericUpDown";
            this.alarm_hours_numericUpDown.Size = new System.Drawing.Size(54, 20);
            this.alarm_hours_numericUpDown.TabIndex = 4;
            // 
            // alarm_clock_label
            // 
            this.alarm_clock_label.AutoSize = true;
            this.alarm_clock_label.Font = new System.Drawing.Font("Quartz MS", 80F);
            this.alarm_clock_label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.alarm_clock_label.Location = new System.Drawing.Point(6, -20);
            this.alarm_clock_label.Name = "alarm_clock_label";
            this.alarm_clock_label.Size = new System.Drawing.Size(517, 129);
            this.alarm_clock_label.TabIndex = 1;
            this.alarm_clock_label.Text = "00:00:00";
            this.alarm_clock_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Crimson;
            this.tabPage3.Controls.Add(this.timer_restartButton);
            this.tabPage3.Controls.Add(this.timer_label);
            this.tabPage3.Controls.Add(this.timer_startButton);
            this.tabPage3.Controls.Add(this.timer_groupBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(537, 255);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Таймер";
            // 
            // timer_restartButton
            // 
            this.timer_restartButton.Location = new System.Drawing.Point(447, 219);
            this.timer_restartButton.Name = "timer_restartButton";
            this.timer_restartButton.Size = new System.Drawing.Size(75, 23);
            this.timer_restartButton.TabIndex = 7;
            this.timer_restartButton.Text = "Сброс";
            this.timer_restartButton.UseVisualStyleBackColor = true;
            this.timer_restartButton.Click += new System.EventHandler(this.timer_restartButton_Click);
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Quartz MS", 72F);
            this.timer_label.ForeColor = System.Drawing.Color.Black;
            this.timer_label.Location = new System.Drawing.Point(112, -10);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(316, 115);
            this.timer_label.TabIndex = 6;
            this.timer_label.Text = "00:00";
            this.timer_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_startButton
            // 
            this.timer_startButton.ForeColor = System.Drawing.Color.Black;
            this.timer_startButton.Location = new System.Drawing.Point(361, 219);
            this.timer_startButton.Name = "timer_startButton";
            this.timer_startButton.Size = new System.Drawing.Size(75, 23);
            this.timer_startButton.TabIndex = 5;
            this.timer_startButton.Text = "Пуск";
            this.timer_startButton.UseVisualStyleBackColor = true;
            this.timer_startButton.Click += new System.EventHandler(this.timer_startButton_Click);
            // 
            // timer_groupBox
            // 
            this.timer_groupBox.Controls.Add(this.timer_seconds_numericUpDown);
            this.timer_groupBox.Controls.Add(this.timer_minutes_label);
            this.timer_groupBox.Controls.Add(this.timer_seconds_label);
            this.timer_groupBox.Controls.Add(this.timer_minutes_numericUpDown);
            this.timer_groupBox.ForeColor = System.Drawing.Color.White;
            this.timer_groupBox.Location = new System.Drawing.Point(12, 151);
            this.timer_groupBox.Name = "timer_groupBox";
            this.timer_groupBox.Size = new System.Drawing.Size(510, 61);
            this.timer_groupBox.TabIndex = 4;
            this.timer_groupBox.TabStop = false;
            this.timer_groupBox.Text = "Настройки таймера:";
            // 
            // timer_seconds_numericUpDown
            // 
            this.timer_seconds_numericUpDown.CausesValidation = false;
            this.timer_seconds_numericUpDown.Location = new System.Drawing.Point(185, 32);
            this.timer_seconds_numericUpDown.Name = "timer_seconds_numericUpDown";
            this.timer_seconds_numericUpDown.Size = new System.Drawing.Size(42, 20);
            this.timer_seconds_numericUpDown.TabIndex = 3;
            this.timer_seconds_numericUpDown.TabStop = false;
            this.timer_seconds_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timer_seconds_numericUpDown.ValueChanged += new System.EventHandler(this.timer_seconds_numericUpDown_ValueChanged);
            // 
            // timer_minutes_label
            // 
            this.timer_minutes_label.AutoSize = true;
            this.timer_minutes_label.Location = new System.Drawing.Point(6, 34);
            this.timer_minutes_label.Name = "timer_minutes_label";
            this.timer_minutes_label.Size = new System.Drawing.Size(49, 13);
            this.timer_minutes_label.TabIndex = 2;
            this.timer_minutes_label.Text = "Минуты:";
            // 
            // timer_seconds_label
            // 
            this.timer_seconds_label.AutoSize = true;
            this.timer_seconds_label.Location = new System.Drawing.Point(125, 34);
            this.timer_seconds_label.Name = "timer_seconds_label";
            this.timer_seconds_label.Size = new System.Drawing.Size(54, 13);
            this.timer_seconds_label.TabIndex = 2;
            this.timer_seconds_label.Text = "Секунды:";
            // 
            // timer_minutes_numericUpDown
            // 
            this.timer_minutes_numericUpDown.Location = new System.Drawing.Point(61, 32);
            this.timer_minutes_numericUpDown.Name = "timer_minutes_numericUpDown";
            this.timer_minutes_numericUpDown.Size = new System.Drawing.Size(42, 20);
            this.timer_minutes_numericUpDown.TabIndex = 0;
            this.timer_minutes_numericUpDown.TabStop = false;
            this.timer_minutes_numericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timer_minutes_numericUpDown.ValueChanged += new System.EventHandler(this.timer_minutes_numericUpDown_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Navy;
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Controls.Add(this.sec_label);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(537, 255);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Секундомер";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sec_listBox);
            this.groupBox1.Controls.Add(this.sec_addButton);
            this.groupBox1.Controls.Add(this.sec_resetButton);
            this.groupBox1.Controls.Add(this.sec_listLabel);
            this.groupBox1.Controls.Add(this.sec_startButton);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(6, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 141);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Секундомер";
            // 
            // sec_listBox
            // 
            this.sec_listBox.FormattingEnabled = true;
            this.sec_listBox.Location = new System.Drawing.Point(6, 32);
            this.sec_listBox.Name = "sec_listBox";
            this.sec_listBox.Size = new System.Drawing.Size(120, 108);
            this.sec_listBox.TabIndex = 4;
            // 
            // sec_addButton
            // 
            this.sec_addButton.ForeColor = System.Drawing.Color.Black;
            this.sec_addButton.Location = new System.Drawing.Point(428, 82);
            this.sec_addButton.Name = "sec_addButton";
            this.sec_addButton.Size = new System.Drawing.Size(91, 23);
            this.sec_addButton.TabIndex = 5;
            this.sec_addButton.Text = "Круг";
            this.sec_addButton.UseVisualStyleBackColor = true;
            this.sec_addButton.Click += new System.EventHandler(this.sec_addButton_Click);
            // 
            // sec_resetButton
            // 
            this.sec_resetButton.ForeColor = System.Drawing.Color.Black;
            this.sec_resetButton.Location = new System.Drawing.Point(428, 111);
            this.sec_resetButton.Name = "sec_resetButton";
            this.sec_resetButton.Size = new System.Drawing.Size(91, 23);
            this.sec_resetButton.TabIndex = 1;
            this.sec_resetButton.Text = "Перезапуск";
            this.sec_resetButton.UseVisualStyleBackColor = true;
            this.sec_resetButton.Click += new System.EventHandler(this.sec_resetButton_Click);
            // 
            // sec_listLabel
            // 
            this.sec_listLabel.AutoSize = true;
            this.sec_listLabel.ForeColor = System.Drawing.Color.White;
            this.sec_listLabel.Location = new System.Drawing.Point(6, 16);
            this.sec_listLabel.Name = "sec_listLabel";
            this.sec_listLabel.Size = new System.Drawing.Size(109, 13);
            this.sec_listLabel.TabIndex = 6;
            this.sec_listLabel.Text = "Контрольные точки:";
            // 
            // sec_startButton
            // 
            this.sec_startButton.ForeColor = System.Drawing.Color.Black;
            this.sec_startButton.Location = new System.Drawing.Point(331, 111);
            this.sec_startButton.Name = "sec_startButton";
            this.sec_startButton.Size = new System.Drawing.Size(91, 23);
            this.sec_startButton.TabIndex = 0;
            this.sec_startButton.Text = "Старт";
            this.sec_startButton.UseVisualStyleBackColor = true;
            this.sec_startButton.Click += new System.EventHandler(this.sec_startButton_Click);
            // 
            // sec_label
            // 
            this.sec_label.AutoSize = true;
            this.sec_label.Font = new System.Drawing.Font("Quartz MS", 72F);
            this.sec_label.ForeColor = System.Drawing.Color.White;
            this.sec_label.Location = new System.Drawing.Point(112, -10);
            this.sec_label.Name = "sec_label";
            this.sec_label.Size = new System.Drawing.Size(316, 115);
            this.sec_label.TabIndex = 3;
            this.sec_label.Text = "00:00";
            this.sec_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerAlarm
            // 
            this.timerAlarm.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerTimer
            // 
            this.timerTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timerSec
            // 
            this.timerSec.Tick += new System.EventHandler(this.timerSec_Tick);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "Будильник";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 276);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 315);
            this.MinimumSize = new System.Drawing.Size(550, 315);
            this.Name = "main_form";
            this.Text = "Часы";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.alarm_groupBox.ResumeLayout(false);
            this.alarm_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_minutes_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm_hours_numericUpDown)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.timer_groupBox.ResumeLayout(false);
            this.timer_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timer_seconds_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer_minutes_numericUpDown)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.Label clock_label;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Button alarm_okButton;
        private System.Windows.Forms.GroupBox alarm_groupBox;
        private System.Windows.Forms.CheckBox alarm_checkbox;
        private System.Windows.Forms.TextBox alarm_textbox;
        private System.Windows.Forms.Label alarm_minutes_label;
        private System.Windows.Forms.Label alarm_hour_label;
        private System.Windows.Forms.NumericUpDown alarm_minutes_numericUpDown;
        private System.Windows.Forms.NumericUpDown alarm_hours_numericUpDown;
        private System.Windows.Forms.Label alarm_clock_label;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Button timer_startButton;
        private System.Windows.Forms.GroupBox timer_groupBox;
        private System.Windows.Forms.NumericUpDown timer_seconds_numericUpDown;
        private System.Windows.Forms.Label timer_minutes_label;
        private System.Windows.Forms.Label timer_seconds_label;
        private System.Windows.Forms.NumericUpDown timer_minutes_numericUpDown;
        private System.Windows.Forms.Timer timerTimer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timerSec;
        private System.Windows.Forms.Button sec_resetButton;
        private System.Windows.Forms.Button sec_startButton;
        private System.Windows.Forms.Label sec_label;
        private System.Windows.Forms.Button sec_addButton;
        private System.Windows.Forms.ListBox sec_listBox;
        private System.Windows.Forms.Label alarm_message_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sec_listLabel;
        private System.Windows.Forms.Button timer_restartButton;
        private System.Windows.Forms.Button alarm_toneDirButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

