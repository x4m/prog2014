using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace clock     {
    public partial class main_form : Form       {
        private SoundPlayer alarm_sound; // переменная типа SoundPlayer
        private SoundPlayer timer_sound;
        private DateTime alarm; // время сигнала будильника
        private DateTime t1; // время запуска таймера
        private DateTime t2; // время срабатывания таймера
        private DateTime sec = new DateTime(0, 0);
        private int i = 1;
        
        public main_form()      {
            InitializeComponent();

            alarm_sound = new SoundPlayer(); // создание экземпляра класса SoundPlayer
            alarm_sound.Stream = Properties.Resources.ring; // подключение звукового файла из ресурсов
            timer_sound = new SoundPlayer();
            timer_sound.Stream = Properties.Resources.ring;

            //***********************БУДИЛЬНИК ***********************
            // параметры компонентов numericUpDown для будильника
            alarm_hours_numericUpDown.Maximum = 23;
            alarm_hours_numericUpDown.Minimum = 0;
            alarm_minutes_numericUpDown.Maximum = 59;
            alarm_minutes_numericUpDown.Minimum = 0;

            alarm_hours_numericUpDown.Value = DateTime.Now.Hour;
            alarm_minutes_numericUpDown.Value = DateTime.Now.Minute;

            // отключение иконки в системном трее при запуске приложения
            notifyIcon1.Visible = false;
            
            // инициализация таймеров
            timerAlarm.Interval = 1000;
            timerAlarm.Enabled = true;
            timerSec.Interval = 1000;
            
            // вывод времени и даты на часы
            clock_label.Text = DateTime.Now.ToLongTimeString();
            date_label.Text = DateTime.Now.ToShortDateString();
            //вывод времени на вкладку будильника
            alarm_clock_label.Text = DateTime.Now.ToLongTimeString();


            // *********************** ТАЙМЕР ***********************
            // настройка компонентов numericUpDown
            timer_minutes_numericUpDown.Maximum = 59;
            timer_minutes_numericUpDown.Minimum = 0;
            // чтобы при появлении окна
            // курсор не мигал в поле редактирования
            timer_minutes_numericUpDown.TabStop = false;
            timer_seconds_numericUpDown.Maximum = 59;
            timer_seconds_numericUpDown.Minimum = 0;
            timer_seconds_numericUpDown.TabStop = false;
            // кнопка Пуск/Стоп не доступна
            timer_startButton.Enabled = false;
           
        }


        // *********************** БУДИЛЬНИК ***********************
        // кнопка сворачивания будильника в системный трей
        private void alarm_okButton_Click(object sender, EventArgs e)       {
            this.Hide();
            notifyIcon1.Visible = true;
        }
 
        // кнопка выбора мелодии будильника
        private void alarm_toneDirButton_Click(object sender, EventArgs e)      {
            openFileDialog.Filter = "Waveform Audio File|*.wav";
            if (openFileDialog.ShowDialog() == DialogResult.OK)     {
                alarm_sound.SoundLocation = openFileDialog.FileName;
            }
        }

        // разворачивание из системного трея по двойному щелчку Л.К.М.
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)      {
            this.Show();
        }

        // включение будильника 
        private void alarm_checkbox_CheckedChanged(object sender, EventArgs e)      {
            if (alarm_checkbox.Checked)     {
                alarm_hours_numericUpDown.Enabled = false;
                alarm_minutes_numericUpDown.Enabled = false;

                // установить время сигнала
                alarm = new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    DateTime.Now.Day,
                    Convert.ToInt16(alarm_hours_numericUpDown.Value),
                    Convert.ToInt16(alarm_minutes_numericUpDown.Value),
                    0, 0);

                // если установленное время будильника меньше
                // текущего, нужно увеличить дату срабатывания
                // на единицу (+1 день)
                if (DateTime.Compare(DateTime.Now, alarm) > 0)
                    alarm = alarm.AddDays(1);

                notifyIcon1.Text = alarm.ToShortTimeString() + "\n" + alarm_textbox.Text;

                alarm_okButton.Enabled = true;
            }
            else        {
                alarm_hours_numericUpDown.Enabled = true;
                alarm_minutes_numericUpDown.Enabled = true;
                notifyIcon1.Text = "Будильник не установлен";
                alarm_okButton.Enabled = false;
            }
        }

        // *********************** ТАЙМЕР ***********************
        // обрабатывает событие ValueChanged от компонентов
        // timer_minutes_numericUpDown и timer_seconds_numericUpDown
        private void timer_minutes_numericUpDown_ValueChanged(object sender, EventArgs e)       {
            if ((timer_minutes_numericUpDown.Value == 0) &&
                       (timer_seconds_numericUpDown.Value == 0))
                timer_startButton.Enabled = false;
            else
                timer_startButton.Enabled = true;
        }
        private void timer_seconds_numericUpDown_ValueChanged(object sender, EventArgs e)       {
            if ((timer_minutes_numericUpDown.Value == 0) &&
                       (timer_seconds_numericUpDown.Value == 0))
                timer_startButton.Enabled = false;
            else
                timer_startButton.Enabled = true;
        }
        
        // щелчок на кнопке Пуск/Стоп
        private void timer_startButton_Click(object sender, EventArgs e)    {
            if (!timerTimer.Enabled)    {
                // таймер не работает
                // t1 - текущее время
                // t2 = t1 + интервал
                t1 = new DateTime(DateTime.Now.Year,
                      DateTime.Now.Month, DateTime.Now.Day);
                t2 = t1.AddMinutes((double)timer_minutes_numericUpDown.Value);
                t2 = t2.AddSeconds((double)timer_seconds_numericUpDown.Value);

                timer_groupBox.Enabled = false;
                timer_startButton.Text = "Стоп";

                if (t2.Minute < 9)
                    timer_label.Text = "0" + t2.Minute.ToString() + ":";
                else
                    timer_label.Text = t2.Minute.ToString() + ":";

                if (t2.Second < 9)
                    timer_label.Text += "0" + t2.Second.ToString();
                else
                    timer_label.Text += t2.Second.ToString();

                // сигнал от таймера поступает каждую секунду
                timerTimer.Interval = 1000;
                // пуск таймера
                timerTimer.Enabled = true;
                timer_groupBox.Enabled = false;
                timer_groupBox.Visible = false;
            }
            else    {
                // таймер работает, останавливаем
                timerTimer.Enabled = false;
                timer_startButton.Text = "Пуск";
                timer_groupBox.Enabled = true;
                timer_groupBox.Visible = false;
                timer_minutes_numericUpDown.Value = t2.Minute;
                timer_seconds_numericUpDown.Value = t2.Second;
            }
        }
        private void timer_restartButton_Click(object sender, EventArgs e)      {
            if (!timerTimer.Enabled)        {
                timer_startButton.Text = "Пуск";
                timer_groupBox.Enabled = true;
                timer_groupBox.Visible = true;
                timer_minutes_numericUpDown.Value = 0;
                timer_seconds_numericUpDown.Value = 0;
                timer_label.Text = "00:00";
            }
        }


        // *********************** СЕКУНДОМЕР ***********************
        private void sec_startButton_Click(object sender, EventArgs e)      {

            if (timerSec.Enabled)   {
                timerSec.Enabled = false;
                sec_startButton.Text = "Старт";
                sec_resetButton.Enabled = true;
            }
                
            else    {
                timerSec.Enabled = true;
                sec_startButton.Text = "Стоп";
                sec_resetButton.Enabled = false;
            }
        }
        private void sec_resetButton_Click(object sender, EventArgs e)      {
            sec = new DateTime(0, 0);
            sec_label.Text = "00:00";
            sec_listBox.Items.Clear();
            i = 1;
        }
        private void sec_addButton_Click(object sender, EventArgs e)        {
            if (timerSec.Enabled)       {
                sec_listBox.Items.Add(i + ". " + sec.ToString("mm:ss"));
                i++;
            }
        }


        // *********************** ТАЙМЕРЫ (элементы timer) ***********************
        // timer для функций "Часы" и "Будильник"
        private void timer1_Tick(object sender, EventArgs e)        {
            clock_label.Text = DateTime.Now.ToLongTimeString();
            alarm_clock_label.Text = DateTime.Now.ToLongTimeString();

            // будильник установлен

            if (alarm_checkbox.Checked)     {
                // время срабатывания будильника
                if (DateTime.Compare(DateTime.Now, alarm) > 0)      {
                    alarm_checkbox.Checked = false;
                    alarm_sound.Play();  // проигрывание звука
                    alarm_pop_up popUp = new alarm_pop_up();
                    //получаем доступ к компонентам формы popUp
                    popUp.alarm_popUp_label1.Text = DateTime.Now.ToShortTimeString();
                    popUp.alarm_popUp_textbox.Text = this.alarm_textbox.Text;
                    popUp.ShowDialog();
                    this.Show();
                }
            }
        }

        // timer для функции "Таймер"
        private void timer2_Tick(object sender, EventArgs e)        {
            t2 = t2.AddSeconds(-1);
            if (t2.Minute < 9)
                timer_label.Text = "0" + t2.Minute.ToString() + ":";
            else
                timer_label.Text = t2.Minute.ToString() + ":";
            if (t2.Second < 9)
                timer_label.Text += "0" + t2.Second.ToString();
            else
                timer_label.Text += t2.Second.ToString();
            if (Equals(t1, t2))     {
                timerTimer.Enabled = false;
                timer_sound.Play();
                MessageBox.Show(
                    "Заданный интервал времени истек", "Таймер",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                timer_startButton.Text = "Пуск";
                timer_groupBox.Enabled = true;
                timer_groupBox.Visible = true;
                timer_minutes_numericUpDown.Value = 0;
                timer_seconds_numericUpDown.Value = 0;
            }
        }

        // timer для функции "Секундомер"
        private void timerSec_Tick(object sender, EventArgs e)      {
            sec = sec.AddSeconds(1);
            sec_label.Text = sec.ToString("mm:ss");
        }
    }
}