namespace 初级版
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_IP_Input = new System.Windows.Forms.Button();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_stop = new System.Windows.Forms.Button();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_forward = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_camera = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_camera = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_camera_input = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox_voice = new System.Windows.Forms.TextBox();
            this.button_voice_end = new System.Windows.Forms.Button();
            this.button_voice_begin = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.timer_left_right = new System.Windows.Forms.Timer(this.components);
            this.videoSourcePlayer1 = new AForge.Controls.VideoSourcePlayer();
            this.timer_move = new System.Windows.Forms.Timer(this.components);
            this.button_camera_calibration = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(57, 13);
            this.maskedTextBox1.Mask = "000.000.000.000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(184, 35);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(81, 23);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "连接服务器";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(57, 35);
            this.maskedTextBox2.Mask = "9999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(30, 21);
            this.maskedTextBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "IP地址:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "端口:";
            // 
            // button_IP_Input
            // 
            this.button_IP_Input.Location = new System.Drawing.Point(184, 11);
            this.button_IP_Input.Name = "button_IP_Input";
            this.button_IP_Input.Size = new System.Drawing.Size(81, 23);
            this.button_IP_Input.TabIndex = 1;
            this.button_IP_Input.Text = "IP地址输入";
            this.button_IP_Input.UseVisualStyleBackColor = true;
            this.button_IP_Input.Click += new System.EventHandler(this.button_IP_Input_Click);
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(0, 17);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_message.Size = new System.Drawing.Size(150, 51);
            this.textBox_message.TabIndex = 9;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(65, 12);
            this.vScrollBar1.Maximum = 105;
            this.vScrollBar1.Minimum = 1;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(30, 150);
            this.vScrollBar1.TabIndex = 15;
            this.vScrollBar1.Value = 1;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(3, 162);
            this.hScrollBar1.Maximum = 165;
            this.hScrollBar1.Minimum = 15;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(150, 30);
            this.hScrollBar1.TabIndex = 16;
            this.hScrollBar1.Value = 35;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_stop);
            this.groupBox1.Controls.Add(this.button_right);
            this.groupBox1.Controls.Add(this.button_left);
            this.groupBox1.Controls.Add(this.button_back);
            this.groupBox1.Controls.Add(this.button_forward);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 174);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "方向控制";
            // 
            // button_stop
            // 
            this.button_stop.BackgroundImage = global::初级版.Properties.Resources.stop;
            this.button_stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_stop.Location = new System.Drawing.Point(56, 63);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(50, 50);
            this.button_stop.TabIndex = 14;
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // button_right
            // 
            this.button_right.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_right.BackgroundImage")));
            this.button_right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_right.Location = new System.Drawing.Point(106, 63);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(50, 50);
            this.button_right.TabIndex = 13;
            this.button_right.UseVisualStyleBackColor = true;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_left.BackgroundImage")));
            this.button_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_left.Location = new System.Drawing.Point(6, 63);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(50, 50);
            this.button_left.TabIndex = 12;
            this.button_left.UseVisualStyleBackColor = true;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::初级版.Properties.Resources.down;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.Location = new System.Drawing.Point(56, 113);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(50, 50);
            this.button_back.TabIndex = 11;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_forward
            // 
            this.button_forward.BackgroundImage = global::初级版.Properties.Resources.up;
            this.button_forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_forward.Location = new System.Drawing.Point(56, 13);
            this.button_forward.Name = "button_forward";
            this.button_forward.Size = new System.Drawing.Size(50, 50);
            this.button_forward.TabIndex = 10;
            this.button_forward.UseVisualStyleBackColor = true;
            this.button_forward.Click += new System.EventHandler(this.button_forward_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hScrollBar1);
            this.groupBox2.Controls.Add(this.vScrollBar1);
            this.groupBox2.Location = new System.Drawing.Point(612, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(157, 194);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "云台控制";
            // 
            // button_camera
            // 
            this.button_camera.Location = new System.Drawing.Point(8, 30);
            this.button_camera.Name = "button_camera";
            this.button_camera.Size = new System.Drawing.Size(150, 34);
            this.button_camera.TabIndex = 20;
            this.button_camera.Text = "打开摄像头";
            this.button_camera.UseVisualStyleBackColor = true;
            this.button_camera.Click += new System.EventHandler(this.button_camera_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.说明ToolStripMenuItem.Text = "说明";
            // 
            // textBox_camera
            // 
            this.textBox_camera.Location = new System.Drawing.Point(349, 13);
            this.textBox_camera.Name = "textBox_camera";
            this.textBox_camera.Size = new System.Drawing.Size(221, 21);
            this.textBox_camera.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "视频流地址:";
            // 
            // button_camera_input
            // 
            this.button_camera_input.Location = new System.Drawing.Point(497, 35);
            this.button_camera_input.Name = "button_camera_input";
            this.button_camera_input.Size = new System.Drawing.Size(75, 23);
            this.button_camera_input.TabIndex = 24;
            this.button_camera_input.Text = "确定";
            this.button_camera_input.UseVisualStyleBackColor = true;
            this.button_camera_input.Click += new System.EventHandler(this.button_camera_input_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(712, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "作者：lzj";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_message);
            this.groupBox3.Location = new System.Drawing.Point(615, 256);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 71);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据流信息";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox_voice);
            this.groupBox4.Controls.Add(this.button_voice_end);
            this.groupBox4.Controls.Add(this.button_voice_begin);
            this.groupBox4.Location = new System.Drawing.Point(9, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 126);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "语音控制";
            // 
            // textBox_voice
            // 
            this.textBox_voice.Location = new System.Drawing.Point(7, 49);
            this.textBox_voice.Multiline = true;
            this.textBox_voice.Name = "textBox_voice";
            this.textBox_voice.Size = new System.Drawing.Size(165, 75);
            this.textBox_voice.TabIndex = 2;
            this.textBox_voice.TextChanged += new System.EventHandler(this.textBox_voice_TextChanged);
            // 
            // button_voice_end
            // 
            this.button_voice_end.Location = new System.Drawing.Point(97, 21);
            this.button_voice_end.Name = "button_voice_end";
            this.button_voice_end.Size = new System.Drawing.Size(75, 23);
            this.button_voice_end.TabIndex = 1;
            this.button_voice_end.Text = "结束";
            this.button_voice_end.UseVisualStyleBackColor = true;
            this.button_voice_end.Click += new System.EventHandler(this.button_voice_end_Click);
            // 
            // button_voice_begin
            // 
            this.button_voice_begin.Location = new System.Drawing.Point(7, 21);
            this.button_voice_begin.Name = "button_voice_begin";
            this.button_voice_begin.Size = new System.Drawing.Size(75, 23);
            this.button_voice_begin.TabIndex = 0;
            this.button_voice_begin.Text = "开始";
            this.button_voice_begin.UseVisualStyleBackColor = true;
            this.button_voice_begin.Click += new System.EventHandler(this.button_voice_begin_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_IP_Input);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.maskedTextBox1);
            this.groupBox5.Controls.Add(this.button_connect);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.maskedTextBox2);
            this.groupBox5.Controls.Add(this.button_camera_input);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.textBox_camera);
            this.groupBox5.Location = new System.Drawing.Point(196, 330);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(576, 79);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "设置";
            // 
            // timer_left_right
            // 
            this.timer_left_right.Tick += new System.EventHandler(this.timer_left_right_Tick);
            // 
            // videoSourcePlayer1
            // 
            this.videoSourcePlayer1.BackgroundImage = global::初级版.Properties.Resources.ustcblue;
            this.videoSourcePlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.videoSourcePlayer1.Location = new System.Drawing.Point(196, 27);
            this.videoSourcePlayer1.Name = "videoSourcePlayer1";
            this.videoSourcePlayer1.Size = new System.Drawing.Size(400, 300);
            this.videoSourcePlayer1.TabIndex = 19;
            this.videoSourcePlayer1.Text = "videoSourcePlayer1";
            this.videoSourcePlayer1.VideoSource = null;
//            this.videoSourcePlayer1.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer1_NewFrame);
            // 
            // timer_move
            // 
            this.timer_move.Interval = 50;
            this.timer_move.Tick += new System.EventHandler(this.timer_move_Tick);
            // 
            // button_camera_calibration
            // 
            this.button_camera_calibration.Location = new System.Drawing.Point(618, 224);
            this.button_camera_calibration.Name = "button_camera_calibration";
            this.button_camera_calibration.Size = new System.Drawing.Size(148, 26);
            this.button_camera_calibration.TabIndex = 10;
            this.button_camera_calibration.Text = "云台归位";
            this.button_camera_calibration.UseVisualStyleBackColor = true;
            this.button_camera_calibration.Click += new System.EventHandler(this.button_camera_calibration_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_camera);
            this.groupBox6.Location = new System.Drawing.Point(12, 204);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(164, 89);
            this.groupBox6.TabIndex = 32;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "摄像头";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.button_camera_calibration);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.videoSourcePlayer1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "智能小车控制";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_IP_Input;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_forward;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer1;
        private System.Windows.Forms.Button button_camera;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_camera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_camera_input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textBox_voice;
        private System.Windows.Forms.Button button_voice_end;
        private System.Windows.Forms.Button button_voice_begin;
        private System.Windows.Forms.Timer timer_left_right;
        private System.Windows.Forms.Timer timer_move;
        private System.Windows.Forms.Button button_camera_calibration;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

