using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging;
//using AForge.Video.FFMPEG;
using SpeechLib;
namespace 初级版
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        string FileName = System.AppDomain.CurrentDomain.BaseDirectory + "Config.ini";
        StringBuilder temp = new StringBuilder(255);


     /*   private bool stopREC = true;
        private bool createNewFile = true;
        private string drawDate = string.Empty;
        private string videoFileFullPath = string.Empty; //视频文件全路径
        private string imageFileFullPath = string.Empty; //图像文件全路径
        private string videoPath = @"E:\video\"; //视频文件路径
        private string imagePath = @"E:\video\images\"; //图像文件路径
        private string videoFileName = string.Empty; //视频文件名
        private string imageFileName = string.Empty; //图像文件名
        private VideoFileWriter videoWriter = null;*/



        IPAddress ip_input;
        int port,stop_count;
        string str_camera;
        private static byte[] result = new byte[1024];
        byte[] sendMessage = new byte[]{0xff,0x00,0x00,0x00,0xff};

        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Form1()
        {
            InitializeComponent();
        }
    
        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Environment.CurrentDirectory + "\\Config.ini"))
            {
                FileStream fs = new FileStream(Environment.CurrentDirectory + "\\Config.ini", FileMode.Create, FileAccess.Write);
                fs.Close();
            }
           // string str_ip;
            GetPrivateProfileString("配置", "ip_address", "", temp, 256, FileName);
           // string str_ip="192.168.191.001";
            string str_ip = temp.ToString();
            GetPrivateProfileString("配置", "ip_port", "", temp, 256, FileName);
            string str_port = temp.ToString();
            GetPrivateProfileString("配置", "camera", "", temp, 256, FileName);
            str_camera=temp.ToString();
            maskedTextBox1.Text = str_ip;
            maskedTextBox2.Text = str_port;
            textBox_camera.Text = str_camera;
            label5.Text = textBox_camera.Text;
            button_IP_Input_Click(button_IP_Input, new EventArgs());//触发按钮点击事件
            button_connect_Click(button_connect, new EventArgs());
            vScrollBar1.Value = 61;
            hScrollBar1.Value = 90;
           // Disable();
            if (videoSourcePlayer1.VideoSource != null)
            {
                videoSourcePlayer1.SignalToStop();
                videoSourcePlayer1.WaitForStop();
            }
        }
         private void Disable()
        {
            button_forward.Enabled = false;
            button_back.Enabled = false;
            button_left.Enabled = false;
            button_right.Enabled = false;
            button_stop.Enabled = false;
            button_voice_begin.Enabled = false;
            button_voice_end.Enabled = false;
            vScrollBar1.Enabled = false;
            hScrollBar1.Enabled = false;
        }
    /*       private void Enable()
         {
             button_forward.Enabled = true;
             button_back.Enabled = true;
             button_left.Enabled = true;
             button_right.Enabled = true;
             button_stop.Enabled = true;
             button_voice_begin.Enabled = true;
             button_voice_end.Enabled = true;
             vScrollBar1.Enabled = true;
             hScrollBar1.Enabled = true;
         }
           */
        private void button_IP_Input_Click(object sender, EventArgs e)
        {
            try
            {
                ip_input = IPAddress.Parse(maskedTextBox1.Text);
                port = Convert.ToInt16(maskedTextBox2.Text);
                label1.Text = ip_input.ToString() + "  " + maskedTextBox2.Text;
                WritePrivateProfileString("配置", "ip_address", maskedTextBox1.Text, FileName);
                WritePrivateProfileString("配置", "ip_port", maskedTextBox2.Text, FileName);
            }
            catch (Exception error)
            {
                MessageBox.Show("<IP地址输入格式错误> " + error.Message);
            }
        }
        private void button_connect_Click(object sender, EventArgs e)
        {
            try
            {
                clientSocket.Connect(new IPEndPoint(ip_input, port)); //配置服务器IP与端口  
                MessageBox.Show("连接服务器成功", "提示");
            }
            catch(Exception ex)
            {
                //MessageBox.Show("连接服务器失败", "提示");
                MessageBox.Show(ex.ToString(), "提示");
            }
        }

        private void button_forward_Click(object sender, EventArgs e)
        {
            try
            {
               // Thread.Sleep(1000);    //等待1秒钟     
                sendMessage[1] = 0x00;
                sendMessage[2] = 0x04;
                sendMessage[3] = 0x00;
                clientSocket.Send(sendMessage);
                textBox_message.AppendText("send:");
                for (int i = 0; i < 5; i++)
                {
                    textBox_message.AppendText(Convert.ToString(sendMessage[i], 16));
                }
                textBox_message.AppendText("\r\n");
            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            try
            {
                // Thread.Sleep(1000);    //等待1秒钟     
                sendMessage[1] = 0x00;
                sendMessage[2] = 0x03;
                sendMessage[3] = 0x00;
                clientSocket.Send(sendMessage);
                textBox_message.AppendText("send:");
                for (int i = 0; i < 5; i++)
                {
                    textBox_message.AppendText(Convert.ToString(sendMessage[i], 16));
                }
                textBox_message.AppendText("\r\n");
            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }

        private void button_left_Click(object sender, EventArgs e)
        {
            try
            {
                sendMessage[1] = 0x00;
                sendMessage[2] = 0x01;
                sendMessage[3] = 0x00;
                clientSocket.Send(sendMessage);
                textBox_message.AppendText("send:");
                for (int i = 0; i < 5; i++)
                {
                    textBox_message.AppendText(Convert.ToString(sendMessage[i], 16));
                }
                textBox_message.AppendText("\r\n");
            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            try
            {  
                sendMessage[1] = 0x00;
                sendMessage[2] = 0x02;
                sendMessage[3] = 0x00;
                clientSocket.Send(sendMessage);
                textBox_message.AppendText("send:");
                for (int i = 0; i < 5; i++)
                {
                    textBox_message.AppendText( Convert.ToString(sendMessage[i], 16));
                }
                textBox_message.AppendText("\r\n");
            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            try
            {
                sendMessage[1] = 0x00;
                sendMessage[2] = 0x00;
                sendMessage[3] = 0x00;
                clientSocket.Send(sendMessage);
                textBox_message.AppendText("send:");
                for (int i = 0; i < 5; i++)
                {
                    textBox_message.AppendText(Convert.ToString(sendMessage[i], 16));
                }
                textBox_message.AppendText("\r\n");
            }
            catch
            {
                
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }
        /// <summary>
        /// 俯仰角范围0x01~0x60
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sendMessage[1] = 0x01;
                sendMessage[2] = 0x01;
                sendMessage[3] = Convert.ToByte(106-vScrollBar1.Value);
                clientSocket.Send(sendMessage);
                textBox_message.AppendText("send:");
                for (int i = 0; i < 5; i++)
                {
                    textBox_message.AppendText(Convert.ToString(sendMessage[i], 16));
                }
                textBox_message.AppendText("\r\n");
            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }
        /// <summary>
        /// 水平方向角范围0x05~0xb0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                sendMessage[1] = 0x01;
                sendMessage[2] = 0x02;
                sendMessage[3] = Convert.ToByte(180-hScrollBar1.Value);
                clientSocket.Send(sendMessage);
                textBox_message.AppendText("send:");
                for (int i = 0; i < 5; i++)
                {
                    textBox_message.AppendText(Convert.ToString(sendMessage[i], 16));
                }
                textBox_message.AppendText("\r\n");
            }
            catch
            {
                clientSocket.Shutdown(SocketShutdown.Both);
                clientSocket.Close();
            }
        }
        private void connectVidio()
        {
            MJPEGStream mjpegSource = new MJPEGStream(str_camera);  //这里是从路由发出的视频流的地址，根据实际情况来写
            OpenVideoSource(mjpegSource);
        }
        private void OpenVideoSource(IVideoSource source)
        {
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer1.VideoSource = source;
            videoSourcePlayer1.Start();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.Stop(); 
        }

        private void button_camera_Click(object sender, EventArgs e)
        {
           // if(b)
            if (button_camera.Text == "打开摄像头")
            {
                button_camera.Text = "关闭摄像头";
                connectVidio();
            }
            else
            {
                button_camera.Text = "打开摄像头";
                videoSourcePlayer1.Stop();
            }
        }

        private void button_camera_input_Click(object sender, EventArgs e)
        {
            str_camera = textBox_camera.Text;
            label5.Text = textBox_camera.Text;
            WritePrivateProfileString("配置", "camera", textBox_camera.Text, FileName);
        }

        #region 语音模块
        private void button_voice_end_Click(object sender, EventArgs e)
        {
            SpRecognition x = new SpRecognition();
            x.CloseRec();
        }
        /// <summary>
        /// 语音识别控制
        /// </summary>
        public class SpRecognition
        {
            private static SpRecognition _Instance = null;
            private SpeechLib.ISpeechRecoGrammar isrg;
            private SpeechLib.SpSharedRecoContextClass ssrContex = null;
            private System.Windows.Forms.Control textBox_voice;
            public SpRecognition()
            {
                ssrContex = new SpSharedRecoContextClass();
                isrg = ssrContex.CreateGrammar(1);
                SpeechLib._ISpeechRecoContextEvents_RecognitionEventHandler recHandle =
                new _ISpeechRecoContextEvents_RecognitionEventHandler(ContexRecognition);
                ssrContex.Recognition += recHandle;
            }
            public void BeginRec(Control tbResult)
            {
                isrg.DictationSetState(SpeechRuleState.SGDSActive);
                textBox_voice = tbResult;
            }
            public static SpRecognition instance()
            {
                if (_Instance == null)
                    _Instance = new SpRecognition();
                return _Instance;
            }
            public void CloseRec()
            {
                isrg.DictationSetState(SpeechRuleState.SGDSInactive);
            }
            private void ContexRecognition(int iIndex, object obj, SpeechLib.SpeechRecognitionType type, SpeechLib.ISpeechRecoResult result)
            {
                textBox_voice.Text = result.PhraseInfo.GetText(0, -1, true);
            }
        }

        private void button_voice_begin_Click(object sender, EventArgs e)
        {
            SpRecognition x = new SpRecognition();
            x.BeginRec(textBox_voice);
        }

        private void textBox_voice_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_voice.Text == "前进") || textBox_voice.Text.Contains("前"))
            {
                button_forward_Click(sender, e);
               // buttonForward_Click(sender, e);
                textBox_voice.Clear();
            }
            else if ((textBox_voice.Text == "后退") || textBox_voice.Text.Contains("后"))
            {
                button_back_Click(sender, e);
              //  buttonBackward_Click(sender, e);
                textBox_voice.Clear();
            }
            else if (textBox_voice.Text.Contains("左") || textBox_voice.Text.Contains("着") || textBox_voice.Text.Contains("钟") || textBox_voice.Text.Contains("座") || textBox_voice.Text.Contains("错") || textBox_voice.Text.Contains("绸") || textBox_voice.Text.Contains("作") || textBox_voice.Text.Contains("足"))
            {
                button_left_Click(sender, e);
               // button_left.PerformClick();
               // timer_turnaround.Enabled = true;
                timer_left_right.Enabled = true;
                textBox_voice.Clear();
            }
            else if (textBox_voice.Text.Contains("右") || textBox_voice.Text.Contains("又") || textBox_voice.Text.Contains("用") || textBox_voice.Text.Contains("勇") || textBox_voice.Text.Contains("泳") || textBox_voice.Text.Contains("永") || textBox_voice.Text.Contains("有"))
            {
                button_right_Click(sender, e);
              //  button_right.PerformClick();
              //  timer_turnaround.Enabled = true;
                timer_left_right.Enabled = true;
                textBox_voice.Clear();
            }
            else if (textBox_voice.Text.Contains("停") || textBox_voice.Text.Contains("关") || textBox_voice.Text.Contains("乖") || textBox_voice.Text.Contains("秦") || textBox_voice.Text.Contains("池") || textBox_voice.Text.Contains("提") || textBox_voice.Text.Contains("交") || textBox_voice.Text.Contains("关") || textBox_voice.Text.Contains("乖") || textBox_voice.Text.Contains("平") || textBox_voice.Text.Contains("时") || textBox_voice.Text.Contains("芹") || textBox_voice.Text.Contains("以") || textBox_voice.Text.Contains("下") || textBox_voice.Text.Contains("的") || textBox_voice.Text.Contains("心") || textBox_voice.Text.Contains("智") || textBox_voice.Text.Contains("品") || textBox_voice.Text.Contains("质") || textBox_voice.Text.Contains("仅") || textBox_voice.Text.Contains("只") || textBox_voice.Text.Contains("及") || textBox_voice.Text.Contains("一") || textBox_voice.Text.Contains("项") || textBox_voice.Text.Contains("s"))
            {
                button_stop_Click(sender, e);
                textBox_voice.Clear();
            }
        }
        #endregion

        private void timer_left_right_Tick(object sender, EventArgs e)
        {
            button_stop_Click(sender, e);
            timer_left_right.Enabled = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                button_forward_Click(sender, e);
                timer_move.Enabled = true;
                stop_count = 0;
            }
            else if(e.KeyCode==Keys.A)
            {
                button_left_Click(sender, e);
                timer_move.Enabled = true;
                stop_count = 0;
            }
            else if(e.KeyCode==Keys.S)
            {
                button_back_Click(sender, e);
                timer_move.Enabled = true;
                stop_count = 0;
            }
            else if (e.KeyCode == Keys.D)
            {
                button_right_Click(sender, e);
                timer_move.Enabled = true;
                stop_count = 0;
            }
            else if (e.KeyCode == Keys.Q)
            {
                if (hScrollBar1.Value > 15)
                {
                    hScrollBar1.Value--;
                }          
            }
            else if (e.KeyCode == Keys.E)
            {
                if (hScrollBar1.Value < 165)
                {
                    hScrollBar1.Value++;
                }     
            }
            else if (e.KeyCode == Keys.Z)
            {
                if (vScrollBar1.Value > 1)
                {
                    vScrollBar1.Value--;
                }               
            }
            else if (e.KeyCode == Keys.C)
            {
                if (vScrollBar1.Value < 105)
                {
                    vScrollBar1.Value++;
                }                
            }
        }

        private void timer_move_Tick(object sender, EventArgs e)
        {
            if (stop_count == 2)
            {
                button_stop_Click(sender, e);
                timer_move.Enabled = false;
            }
            
            stop_count++;
        }

        private void button_camera_calibration_Click(object sender, EventArgs e)
        {
            vScrollBar1.Value = 61;
            hScrollBar1.Value = 90;
        }

     /*   private void button_video_Click(object sender, EventArgs e)
        {
            //开始录像
            if (button_video.Text == "录像")
            {
                stopREC = false;
               // frameRate = Convert.ToInt32(txtFrameRate.Text.Trim());
                button_video.Text = "停止";
            }
            else if (button_video.Text == "录像")
            {
                stopREC = true;
                button_video.Text = "录像";
            }
        }

        private void videoSourcePlayer1_NewFrame(object sender, ref Bitmap image)
        {
            //录像
            Graphics g = Graphics.FromImage(image);
            SolidBrush drawBrush = new SolidBrush(Color.Yellow);

            Font drawFont = new Font("Arial", 6, FontStyle.Bold, GraphicsUnit.Millimeter);
            int xPos = image.Width - (image.Width - 15);
            int yPos = 10;
            //写到屏幕上的时间
            drawDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            g.DrawString(drawDate, drawFont, drawBrush, xPos, yPos);
            if (!Directory.Exists(videoPath))
                Directory.CreateDirectory(videoPath);

            //创建文件路径
            //fileFullPath = path + fileName;

            if (stopREC)
            {
                stopREC = true;
                createNewFile = true;  //这里要设置为true表示要创建新文件
                if (videoWriter != null)
                    videoWriter.Close();
            }
            else
            {
                //开始录像
                if (createNewFile)
                {
                    videoFileName = DateTime.Now.ToString("yyyy.MM.dd HH.mm.ss") + ".avi";
                    videoFileFullPath = videoPath + videoFileName;
                    createNewFile = false;
                    if (videoWriter != null)
                    {
                        videoWriter.Close();
                        //videoWriter.Dispose();
                    }
                    videoWriter = new VideoFileWriter();
                    //这里必须是全路径，否则会默认保存到程序运行根据录下了
                    videoWriter.Open(videoFileFullPath, image.Width, image.Height, 24, VideoCodec.MPEG4);
                    videoWriter.WriteVideoFrame(image);
                }
                else
                {
                    videoWriter.WriteVideoFrame(image);
                }
            }
        }*/

    }
}
