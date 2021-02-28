using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;
using System.IO.Ports;
using Morserino_32;
using System.IO;
using System.Threading;

namespace AIML_Chat_Bot_using_M32
{
    public partial class Start : Form
    {
        private static SerialPort comPort = new SerialPort();
        private Ports port = new Ports();
        private List<string> avable_Ports = new List<string>();
        private bool stopProcess = false;
        private Morserino m32 = new Morserino();
        private List<string> text_Words = new List<string>();
        string cw_Text = "";
        private string s, sa = "";
        private int totalPhrases = 0, correctPhrases = 0, wrongPhrases = 0;
        private delegate void UpdateStatusDelegate();
        private UpdateStatusDelegate updateStatusDelegate = null;
        private Thread workerThread = null;
        private string call;
        private MorseGen.MorseGenerator M_Gen = new MorseGen.MorseGenerator();
        public Start()
        {
            InitializeComponent();

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try { 
                if(comPort.IsOpen)
                port.Close(); } catch { }
            Application.Exit();

        }

        private void btnSvar_Click(object sender, EventArgs e)
        {
            Bot_Answer();
        }

        private void Bot_Answer()
        {
            Bot AI = new Bot();
            AI.loadSettings();
            AI.loadAIMLFromFiles();
            AI.isAcceptingUserInput = false;
            call = txtCall.Text;
            User myuser = new User(call, AI);
            AI.isAcceptingUserInput = true;
            Request r = new Request(txtChat.Text, myuser, AI);
            Result res = AI.Chat(r);
            M_Gen.PlayMorse(res.Output, Convert.ToInt32(comboWPM.Text));
            txtBot.Text = "M32: " + res.Output;
            txtChat.Text = txtChat.Text.Replace("<kn>", "");
            txtFinish.Text = "M32: " + res.Output + "\r\n" + call + ": " + txtChat.Text + "\r\n" + txtFinish.Text;

        }


        private void txtChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckPorts_Click(object sender, System.EventArgs e)
        {


            avable_Ports.Clear();
            avable_Ports = port.PortControl();

            comboPort.Items.Clear();
            for (int a = 0; a < avable_Ports.Count; a++)
            {
                comboPort.Items.Add(avable_Ports[a]);
            }
            btnConnect.Visible = true;
            btnDisConnect.Visible = false;
        }

        private void btnConnect_Click(object sender, System.EventArgs e)
        {



            try
            {
                Connect_to_ComPort(comboPort.Text);
                this.updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);
                this.workerThread = new Thread(new ThreadStart(this.Morserino_Receive));
                btnCheck.Visible = false;
                btnConnect.Visible = false;
                btnDisConnect.Visible = true;
                workerThread.Start();
                labelText.Visible = true;

            }
            catch { }
        }
        private void Connect_to_ComPort(string comboPort)
        {

            comPort = port.Connect(comboPort);


        }


        private void btnDisConntect_Click(object sender, EventArgs e)
        {
            try
            {
                port.Close();
                btnDisConnect.Visible = false;
                btnConnect.Visible = false;
                btnCheck.Visible = true;
            }
            catch { }
        }
        private void PortControl()
        {
            avable_Ports = port.PortControl();
            Fill_ComPort();
        }

        private void txtCall_TextChanged(object sender, EventArgs e)
        {
            call = txtCall.Text;
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            { txtChat.Visible = false; }
            else { txtChat.Visible = true; }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            { txtBot.Visible = false; }
            else { txtBot.Visible = true; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            { txtFinish.Visible = false; }
            else { txtFinish.Visible = true; }
        }

        private void Fill_ComPort()
        {

            comboPort.Items.Clear();
            for (int a = 0; a < avable_Ports.Count; a++)
            {
                comboPort.Items.Add(avable_Ports[a]);
            }
            btnConnect.Visible = true;
        }






        private void Morserino_Receive()
        {

            string w = "";
            s = "";

            while (true)
            {

                try
                {
                    w = m32.Read_Word_from_M32(comPort);
                    w.TrimStart();

                    cw_Text = "";
                    if (w == "*")
                    {
                        try
                        {
                            if (text_Words[text_Words.Count - 1].Trim() != "")
                            {

                                text_Words.RemoveAt(text_Words.Count - 1);
                            }
                            else
                            {
                                text_Words.RemoveAt(text_Words.Count - 1);
                                text_Words.RemoveAt(text_Words.Count - 1);

                            }


                        }
                        catch { }
                    }


                    else
                    {
                        if (w.TrimStart() != "")
                        {
                            text_Words.Add(w.TrimStart());
                        }
                    }
                }

                catch { }
                if (w.Contains("<kn>"))
                {

                    try
                    {

                        string s = "";

                        for (int a = 0; a < text_Words.Count; a++)
                        {
                            s += text_Words[a];

                        }

                        s = s.TrimStart();
                        s = s.ToLower().Trim();
                        cw_Text = s;
                        text_Words.Clear();

                        text_Words.Add(sa);
                        totalPhrases++;
                        s = "";
                        w = "";


                    }
                    catch
                    {
                        string v = "";
                    }

                }





                if (!this.stopProcess)
                {


                    // Show progress
                    this.Invoke(this.updateStatusDelegate);

                }




            }

        }
        private void UpdateStatus()
        {

            string t = "";
            for (int i = 0; i < text_Words.Count; i++)
            {
                t += text_Words[i];
                txtChat.Text = t;
            }
            string C = cw_Text;
            if (C.Contains("<kn>"))
            {
                txtChat.Text = C.Replace("<kn>", "");
                Bot_Answer();
            }
            else
            {
                txtChat.Text = t.TrimStart();
            }




        }
    }
}
