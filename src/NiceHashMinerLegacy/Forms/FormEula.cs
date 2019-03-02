﻿using NiceHashMiner.Configs;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NiceHashMiner.Forms
{
    public partial class FormEula : Form
    {
        public bool AcceptedToS { get; private set; } = false;
        public FormEula()
        {
            InitializeComponent();
            CenterToScreen();
            Icon = Properties.Resources.logo;
            InitializeTosComponent();
        }

        private void InitializeTosComponent()
        {
            richTextBoxToS.Rtf = Properties.Resources.Eula;
            richTextBoxToS.ReadOnly = true;
            richTextBoxToS.DetectUrls = true;
            richTextBoxToS.HideSelection = true;
            richTextBoxToS.LinkClicked += (s, e) => Process.Start(e.LinkText);
        }

        private void buttonAcceptToS_Click(object sender, EventArgs e)
        {
            AcceptedToS = true;
            ConfigManager.GeneralConfig.agreedWithTOS = Globals.CurrentTosVer;
            ConfigManager.GeneralConfigFileCommit();
            Close();
        }
    }
}
