﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Worker workerObject = new Worker();

        private void button1_Click(object sender, EventArgs e)
        {
            workerObject.Start();
        }

        private void button2_Click(object sender, EventArgs e) => workerObject.RequestStop();
    }
}
