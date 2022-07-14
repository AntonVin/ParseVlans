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
            List<string> listNumbers = ExtractorNumbersVlans.GetNumbersVlans(txtBoxSource1.Text);
            Dictionary<string,string> dictVlans = ExtractorDictionaryVlans.GetDictionaryVlans(txtBoxSource2.Text);
            List<Vlan> listVlans = GeneratorListVlans.GetList(listNumbers,dictVlans).OrderBy(x => int.Parse(x.Number)).ToList();//в одну строку лучше не писать?
            foreach (Vlan vlan in listVlans)
            {
                string name = (vlan.Name == null) ?
                    "" : (" " + vlan.Name);//запутанно? переделать в  IF ELSE?
                txtBoxResult.Text += vlan.Number + name + Environment.NewLine;
            }
        }
    }
}
