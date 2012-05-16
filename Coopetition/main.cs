﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coopetition
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void btnStartRun_Click(object sender, EventArgs e)
        {
            Environment.outputLog = outputLog;
           // new Environment().Run();
        }

        private void btnStrategy_Click(object sender, EventArgs e)
        {
            Environment.outputLog = outputLog;
            switch (cboStrategies.SelectedItem.ToString())
            {
                case "Just Competitive":
                    new Environment().Run(Constants.Strategy.Competition);
                    break;
                case "Just Cooperative":
                    new Environment().Run(Constants.Strategy.Cooperation);
                    break;
                case "Coopetitive":
                    new Environment().Run(Constants.Strategy.Coopetition);
                    break;
            }
        }

    }
}
