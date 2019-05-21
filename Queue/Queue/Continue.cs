using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace Queue
{
    public partial class Continue : Form
    {
        public static bool go;
        public static bool mute;
        public Continue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Go to next in queue
            go = true;
            Hide();
        }

        private void Continue_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.Volume = 100;  
            synthesizer.Rate = -2;     // -10...10

            if (!mute)
            {
                synthesizer.SpeakAsync("Print job has finished");
               // Console.Beep(500, 1000);
            }
        }
    }
}
