﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseVlans
{
    public partial class Form1 : Form
    {
        private IGeneratorListVlans generatorListVlans;
        public Form1(GeneratorListVlans generatorListVlans)
        {
            this.generatorListVlans = generatorListVlans;
            InitializeComponent();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            txtBoxResult.Clear();
            tabControl1.SelectedIndex = tabControl1.TabPages.Count - 1;
            txtBoxResult.Text = this.generatorListVlans.GetText(txtBoxSource1.Text,txtBoxSource2.Text);
        }

        private void btnPageToLeft_Click(object sender, EventArgs e)
        {
            int indexLastPage = tabControl1.TabPages.Count-1;
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex == 0) ?
                indexLastPage  : (tabControl1.SelectedIndex - 1);

        }

        private void btnPageToRight_Click(object sender, EventArgs e)
        {
            int indexLastPage = tabControl1.TabPages.Count - 1;
            tabControl1.SelectedIndex = (tabControl1.SelectedIndex == indexLastPage) ?
                0 : (tabControl1.SelectedIndex + 1);
        }
    }
}
