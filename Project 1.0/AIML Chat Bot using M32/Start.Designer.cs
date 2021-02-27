namespace AIML_Chat_Bot_using_M32
{
    partial class Start
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
            this.components = new System.ComponentModel.Container();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.txtBot = new System.Windows.Forms.TextBox();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisConnect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCall = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelText = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboWPM = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChat.Location = new System.Drawing.Point(0, 2);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(324, 106);
            this.txtChat.TabIndex = 1;
            this.txtChat.TextChanged += new System.EventHandler(this.txtChat_TextChanged);
            // 
            // txtBot
            // 
            this.txtBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBot.Location = new System.Drawing.Point(0, 114);
            this.txtBot.Multiline = true;
            this.txtBot.Name = "txtBot";
            this.txtBot.Size = new System.Drawing.Size(324, 106);
            this.txtBot.TabIndex = 2;
            // 
            // txtFinish
            // 
            this.txtFinish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFinish.Location = new System.Drawing.Point(0, 235);
            this.txtFinish.Multiline = true;
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFinish.Size = new System.Drawing.Size(343, 203);
            this.txtFinish.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ComPort M32";
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(372, 34);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(108, 21);
            this.comboPort.TabIndex = 12;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(373, 71);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(107, 23);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheckPorts_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(373, 100);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(107, 23);
            this.btnConnect.TabIndex = 14;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Visible = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisConnect
            // 
            this.btnDisConnect.Location = new System.Drawing.Point(373, 129);
            this.btnDisConnect.Name = "btnDisConnect";
            this.btnDisConnect.Size = new System.Drawing.Size(107, 23);
            this.btnDisConnect.TabIndex = 15;
            this.btnDisConnect.Text = "DisConnect";
            this.btnDisConnect.UseVisualStyleBackColor = true;
            this.btnDisConnect.Visible = false;
            this.btnDisConnect.Click += new System.EventHandler(this.btnDisConntect_Click);
            // 
            // txtCall
            // 
            this.txtCall.Location = new System.Drawing.Point(373, 188);
            this.txtCall.Name = "txtCall";
            this.txtCall.Size = new System.Drawing.Size(103, 20);
            this.txtCall.TabIndex = 16;
            this.txtCall.Text = "OZ1THC";
            this.txtCall.TextChanged += new System.EventHandler(this.txtCall_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "CallSign / Name";
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelText.Location = new System.Drawing.Point(381, 264);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(99, 160);
            this.labelText.TabIndex = 18;
            this.labelText.Text = "You can\r\nstart with\r\nsending \r\ntext at the \r\nM32 now!\r\n<kn> end\r\n(6 .) del word\r\n" +
    "de oz1thc";
            this.labelText.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(330, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Hide";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(330, 115);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Hide";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(330, 215);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(48, 17);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.Text = "Hide";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "WPM";
            // 
            // comboWPM
            // 
            this.comboWPM.FormattingEnabled = true;
            this.comboWPM.Items.AddRange(new object[] {
            "10",
            "12",
            "15",
            "18",
            "20",
            "22",
            "25",
            "28",
            "30",
            "32",
            "35",
            "38",
            "40"});
            this.comboWPM.Location = new System.Drawing.Point(412, 234);
            this.comboWPM.Name = "comboWPM";
            this.comboWPM.Size = new System.Drawing.Size(63, 21);
            this.comboWPM.TabIndex = 23;
            this.comboWPM.Text = "12";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.comboWPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCall);
            this.Controls.Add(this.btnDisConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.comboPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinish);
            this.Controls.Add(this.txtBot);
            this.Controls.Add(this.txtChat);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AI Chat Bot using M32";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.TextBox txtBot;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisConnect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtCall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboWPM;
    }
}

