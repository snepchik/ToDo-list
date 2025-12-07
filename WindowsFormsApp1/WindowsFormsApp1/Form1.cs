using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        SoundPlayer player = new SoundPlayer();
        String textReminder = "Пррривет!";
        SpeechSynthesizer synth = new SpeechSynthesizer();
        String directoryToMusic = @"D:\visual studio\projects\WindowsFormsApp1\WindowsFormsApp1\Heal.wav";
        String path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\LOGTEST";
        String filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\LOGTEST" + @"\log.txt";
        int countTextBoxes = 0;
        public Form1()
        {

            InitializeComponent();
            
            List.ControlAdded += List_ControllAdded;
            List.ControlRemoved += List_ControlRemoved;
        }




        private void List_ControlRemoved(object sender, ControlEventArgs e)
        {

        }

        private void List_ControllAdded(object sender, ControlEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLog();
            Console.WriteLine(countTextBoxes);
      
           
            btnStop.BackColor = Color.White;
            lableStatus.Text = "Остановлен";
            
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;


        }
        delegate void UpdateLable(Label lbl, string value);
        void UpdateDataLable(Label lbl, string value)
        {
            lbl.Text = value;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;

            
                if (currentTime.Hour == userTime.Hour && currentTime.Minute == userTime.Minute && currentTime.Second == userTime.Second)
                {
                    timer.Stop();
                    Console.WriteLine(directoryToMusic);
                    try
                    {

                        UpdateLable upd = UpdateDataLable;
                        if (lableStatus.InvokeRequired)
                        {
                            Invoke(upd, lableStatus, "Остановлен");
                        }
                        player.SoundLocation = directoryToMusic;

                        synth.SetOutputToDefaultAudioDevice();

                        synth.Speak(textReminder);
                        player.Play();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибочка загрузки аудио=)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
            lableStatus.Text = "Заведён...";
            btnStart.BackColor = Color.White;
            btnStop.BackColor = Color.Salmon;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lableStatus.Text = "Остановлен";
            player.Stop();
            if (synth.State == SynthesizerState.Speaking)
            {
                synth.Pause();
            }
            btnStart.BackColor = Color.LimeGreen;
            btnStop.BackColor = Color.White;
        }

        private void reminder_Enter(object sender, EventArgs e)
        {
            textReminder = this.reminder.Text;

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveLog();
            synth.Dispose();
        }



        private void DirectoryToMusic1_TextChanged(object sender, EventArgs e)
        {
            directoryToMusic = DirectoryToMusic1.Text;
        }
         Control.ControlCollection d;
        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            
            if (List.Controls.Count < 10)
            {
                countTextBoxes++;

                // создаём панель-обёртку для строки
                var row = new Panel()
                {
                    Width = 265,
                    Height = 40,
                    BackColor = Color.Transparent
                };

                // текстбокс
                var tb = new TextBox()
                {
                    Location = new Point(0, 5),
                    Width = 250,
                    Height = 30,
                    Multiline = true,
                    BorderStyle = BorderStyle.None,
                    BackColor = SystemColors.InactiveCaption
                };

                // кнопка справа
                var btnDelete = new Button()
                {
                    Location = new Point(255, 5),
                    Width = 15,
                    Height = 25,
                    Text = "D"
                };
                btnDelete.Click += (s, ev) =>
                {
                    List.Controls.Remove(row);
                    row.Dispose();
                    countTextBoxes--;
                };
                row.Controls.Add(tb);
                row.Controls.Add(btnDelete);

                // добавляем панель в FlowLayoutPanel
                List.Controls.Add(row);
            }
           

            

        }
        private void btnClear_Click(object sender, EventArgs e)
        {


        }

        private void ScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
        }
        DateTime currentTimeClear = DateTime.Now;
        private void btnClear_MouseDown(object sender, MouseEventArgs e)
        {
            currentTimeClear = DateTime.Now;


        }

        private void btnClear_MouseUp(object sender, MouseEventArgs e)
        {
            DateTime currentTime2 = DateTime.Now;
            int delta = currentTime2.Second - currentTimeClear.Second;
            if (delta > 1)
            {
                List.Controls.Clear();
            }
            countTextBoxes = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private void SaveLog()
        {
            
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                using (File.Create(filepath)) ;
            }
            else
            {
                if (!File.Exists(filepath))
                {
                    using (File.Create(filepath)) ;

                }
            }
            TextBox a = new TextBox();
           //Сохранение колва текст боксиков
            string logdata = countTextBoxes.ToString() + "\n";
           //Сохаранение текст бокксиков
            foreach (Control panel in List.Controls)
            {/*
                logdata = logdata + panel. + "\n";
                
            */
                foreach (Control c in panel.Controls)
                {
                    if (c.GetType() == a.GetType())
                    {
                        logdata = logdata + c.Text + "\n";
                    }
                }
                }
            logdata = logdata + DirectoryToMusic1.Text + "\n";
            File.WriteAllText(filepath, logdata);
        }
        private void LoadLog()
        {
            if (File.Exists(filepath))
            {
                string[] lines = File.ReadAllLines(filepath);
                int textBoxes = 0; 
                if(!int.TryParse(lines[0],out textBoxes))
                {
                    Console.WriteLine("Ошибка парсирования кол-ва текст боксов");
                }
                else
                {
                    countTextBoxes = textBoxes;
                }
                   for (int i = 1; i <= textBoxes; i++)
                   {

                      if (lines[i] != string.Empty)
                        {
                        var row = new Panel()
                        {
                            Width = 265,
                            Height = 40,
                            BackColor = Color.Transparent
                        };

                        // текстбокс
                        var tb = new TextBox()
                        {
                          
                                BackColor = SystemColors.InactiveCaption,
                                Height = 35,
                                Width = 250,
                                MaxLength = 85,
                                BorderStyle = BorderStyle.None,
                                Multiline = true,
                                Text = lines[i],
                            
                        };

                        // кнопка справа
                        var btnDelete = new Button()
                        {
                            Location = new Point(255, 5),
                            Width = 15,
                            Height = 25,
                            Text = "D"
                        };
                        btnDelete.Click += (s, ev) =>
                        {
                            List.Controls.Remove(row);
                            row.Dispose(); 
                            countTextBoxes--;
                        };
                        row.Controls.Add(tb);
                        row.Controls.Add(btnDelete);
                        List.Controls.Add(row);
                      }
                    else
                    {
                        countTextBoxes--;
                    }
                        
                   }
                if (lines[textBoxes+1] != string.Empty)
                {
                    DirectoryToMusic1.Text = lines[textBoxes + 1];
                    directoryToMusic = lines[textBoxes + 1];
                }
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void List_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
