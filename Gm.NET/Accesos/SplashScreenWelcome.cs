using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

using Gm.Core;

namespace Gm.NET.Formularios.Accesos
{
    public partial class SplashScreenWelcome : SplashScreen
    {
        private int con = 0;
        private const int max = 5;
        private char efecto = '.';
        private string etiqueta = "Loading";

        public SplashScreenWelcome()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SplashScreenWelcome_Load(object sender, EventArgs e)
        {
            
            lbmensaje.Text = General.Nombre;

            string texto = lbBienvenido.Text + ";" + lbmensaje.Text;

            //Thread tarea = new Thread(new ParameterizedThreadStart(Hablar));
            //tarea.Start(texto);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (con < max)
            {
                labelControl2.Text += efecto;
                con++;
            }
            else
            {
                labelControl2.Text = etiqueta;
                con = 0;
            }
        }

        private void SplashScreenWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }
        private void Hablar(object texto)
        {
            SpeechSynthesizer voz = new SpeechSynthesizer();
            voz.SetOutputToDefaultAudioDevice();
            voz.Speak(texto.ToString());
        }
    }
}