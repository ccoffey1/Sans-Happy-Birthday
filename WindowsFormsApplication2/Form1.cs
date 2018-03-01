using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WindowsFormsApplication2
{
    /**
    * Garbage code made in a day for a friend for this birthday. 
    * Has some weird memory issues so please log out and back in after use.
    **/
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            //Sans talking thread
            Thread sansTalkingThread = new Thread(SansDialogue);
            sansTalkingThread.Start();
        }

        void SansDialogue()
        {
            SoundPlayer sansTalks = new SoundPlayer(Properties.Resources.sans_talk);
            sansTalks.Play();
            SansSays("hey kid,\nhow are ya?", 40, false, 1000, "normal");
            SansSays("listen i know\nyou might be\nbusy right\nnow...", 40, false, 1200, "normal");
            SansSays("...summer\nvacation and\nall that...", 40, false, 1000, "smirk");
            SansSays("but i got a...", 40, false, 1000, "normal");
            SansSays("bone to\npick with you.", 40, true, 1000, "wink");
            SansSays("that would be\nfunnier if you\nwere a\nskeleton.", 40, true, 1000, "wink");
            SansSays("anyway sorry\ni'm late but...\n", 40, false, 1200, "normal");
            SansSays("i hope you had\na good day.", 40, false, 1000, "smirk");
            SansSays("well...", 40, false, 1000, "smirk");
            SansSays("since it's your\nbirthday and \nwhat not.", 40, true, 2000, "smirk");
            SansSays("oh here, i got\nyou a hat, too.", 40, false, 1200, "normal");

            engieSurpriseBox.Width = 100;
            engieSurpriseBox.Height = 146;
            engieSurpriseBox.Location = new Point(546, 399);
            engieSurpriseBox.Image = Properties.Resources.engiehappy;

            SansSays("there we go.", 40, true, 1000, "smirk");
            Thread.Sleep(3000);
            engieSurpriseBox.Visible = false;
            sansBox.Visible = false;
            GUI.Image = Properties.Resources.idk;
            Thread.Sleep(500);
            Thread shakeThread = new Thread(ShakeWindow);
            shakeThread.Start();
            Thread.Sleep(3500);
            sansTalks.Stop();
            Application.Exit();
            Environment.Exit(0);
        }

        void ShakeWindow()
        {
            Random random = new Random();
            while (true)
            {
                Thread.Sleep(10);
                int x = random.Next(1000);
                int y = random.Next(1000);
                Location = new Point(x, y);
            }
        }

       


            chatBubbleImage.Visible = true;
            sansDialogueText.Visible = true;

            string result = "";
            for (int i=0; i<s.Length; ++i)
            {
                result = result + ' ' + s.ElementAt(i);
                sansDialogueText.Text = result;
                Thread.Sleep(speed);
            }
            if(lastMessage)
            {
                Thread.Sleep(endDelay);
                chatBubbleImage.Visible = false;
                sansDialogueText.Visible = false;
            }
            Thread.Sleep(endDelay);
        }

    }
}
