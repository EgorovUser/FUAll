﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUAll
{
    public partial class _Statistic : Form
    {
        public _Parent m_parent;
        public _Statistic(_Parent main)
        {
            InitializeComponent();
            m_parent = main;
            this.ControlBox = false;
        }

        private void _Statistic_Load(object sender, EventArgs e)
        {

        }
    }
}
