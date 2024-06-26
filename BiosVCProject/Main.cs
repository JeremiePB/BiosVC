/*
 * Author: J�r�mie Porlier-B, contact = jeremiepb@gmail.com
 * Date: 2024-01-12
 * Info: Outil cr�� afin d'assister au contr�le des versions de BIOS pour OutilUpdate
 */

/*
 * Note: C'est litt�ralement le premier programme que j'�cris � la main sur VS;
 * alors je m'excuse profond�ment pour toute erreur d'optimisation et les frustrations caus�es par celles-ci,
 * et j'esp�re que le prochain programmeur saura peut-�tre mieux faire que moi 8)
 */
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace BiosVCProject
{
    public partial class Main : Form
    {
        #region Variables
        public string BiosFilePath = "C:\\Users\\ATQ-J�r�mie\\Desktop\\OPEQBACKUP\\BiosVersionControl\\BiosVC\\BiosNew"; //location du fichier 'BiosNew'
        public string ManifestPath = "C:\\Users\\ATQ-J�r�mie\\Desktop\\OPEQBACKUP\\BiosVersionControl\\BiosVC\\BiosNew\\BiosVC_Manifest.csv"; //location du fichier manifest
        public string[,] BiosArray;
        public Thread MainThread;
        public string[] TextBox;
        #endregion
        //INITIALISATION
        #region Init
        public Main() 
        {
            InitializeComponent();
            ManifestPath = "C:/Users/ATQ-J�r�mie/Desktop/OPEQBACKUP/BiosVersionControl/BiosVC/BiosNewBiosVC_Manifest.csv";
            MainThread = Thread.CurrentThread;
            ReadManifest();
#if DEBUG
            debugOutput.Visible = true;
            debugOutput.AppendText("DebugWindow Enabled");
#endif
            this.Activate();
        }
#endregion
        //LOGIQUE
        #region Logic
        private void ReadManifest() {
            if (File.Exists(ManifestPath)) //EXCEPTION: UNAUTHORIZEDACCESSEXCEPTION (fixme)
            {
                try
                {
                    FileStream f = File.Create(BiosFilePath);
                    f.Close();
                    StreamWriter WriteFile = new StreamWriter(BiosFilePath, true);
                    WriteFile.WriteLine("Undefined;Undefined;Undefined;Undefined");
                    WriteFile.Close();
                }
                catch (Exception e)
                {
                    debugOutput.AppendText($"{e.Message}");
                }
            }
            try
            {
                using (StreamReader read = new StreamReader(BiosFilePath))
                {
                    while (true)
                    {
                        debugOutput.AppendText("#Reading...");
                        if (read.EndOfStream) break;
                        string line = read.ReadLine();
                        if (string.IsNullOrEmpty(line)) continue;
                            //Lecture de la liste des BIOS et conversion en Table
                            string[] words = line.Split(";");
                            if (words.Length < 1) continue;
                            for (int i = 0; i <= 3; i++)
                            {
                                if (string.IsNullOrWhiteSpace(words[i]))
                                {
                                    words[i] = "Undefined";
                                }
                                else continue;
                            } // Fin d'�criture d'une ligne
                            debugOutput.AppendText("test test test test");
                    } // Fin du Loop de lecture du fichier
                }
            }
            catch(Exception e)
            {
#if DEBUG
                Console.WriteLine(e);
#endif
            }
        }
        #endregion
        //�V�NEMENTS
        #region Events

        #endregion


    }
}
