using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Speech
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        PromptBuilder promptBuilder = new PromptBuilder();
        SpeechRecognitionEngine speechRecognition = new SpeechRecognitionEngine();

        //Add words
        string[] speechString = new string[] { "" };


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void TextToSpeech(string text)
        {
            promptBuilder.ClearContent();
            promptBuilder.AppendText(text);
            synthesizer.Speak(promptBuilder);
        }

        public void SpeechToText(string text)
        {
            Choices speechList = new Choices();
            speechList.Add(speechString);
            Grammar grammar = new Grammar(new GrammarBuilder(speechList));

            try
            {
                speechRecognition.RequestRecognizerUpdate();
                speechRecognition.LoadGrammar(grammar);
                speechRecognition.SpeechRecognized += speechRecognition_SpeechRecognized;
                speechRecognition.SetInputToDefaultAudioDevice();
                speechRecognition.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {

            }


        }

        public void speechRecognition_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case ("hello"):
                    break;

                default:
                    break;
            }
        }

        public void StopListening()
        {
            speechRecognition.RecognizeAsyncStop();
        }
       


    }
}
