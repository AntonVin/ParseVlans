using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            txtBoxResult.Clear();
            var extractorNumbersVlans = new ExtractorNumbersVlans(txtBoxSource1.Text);
            var extractorDictionary = new ExtractorDictionaryVlans(txtBoxSource2.Text);
            var generatorListVlans = new GeneratorListVlans(extractorNumbersVlans, extractorDictionary);
            List<Vlan> listVlans = generatorListVlans.ListVlans;//.OrderBy(x => int.Parse(x.Number)).ToList();
            foreach (Vlan vlan in listVlans)
            {
                string name = vlan.Name == null ? "" : (" " + vlan.Name);
                txtBoxResult.Text += vlan.Number + name + Environment.NewLine;
            }
        }
    }
}
