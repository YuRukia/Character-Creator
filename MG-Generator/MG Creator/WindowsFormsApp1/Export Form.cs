using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MG_Creator
{
    public partial class Export_Form : Form
    {
        List<RichTextBox> characterSheet = new List<RichTextBox>();

        public Export_Form(List<RichTextBox> exportText)
        {
            characterSheet = exportText;
            InitializeComponent();
        }

        private void Export_Form_Load(object sender, EventArgs e)
        {
            exportTextBox.SelectedRtf = characterSheet[0].Rtf;
            exportTextBox.SelectedRtf = characterSheet[1].Rtf;
            exportTextBox.SelectedText = Environment.NewLine;
            exportTextBox.SelectedRtf = characterSheet[2].Rtf;
            exportTextBox.SelectedText = Environment.NewLine;
            exportTextBox.SelectedRtf = characterSheet[3].Rtf;
            exportTextBox.SelectedText = Environment.NewLine;
            exportTextBox.SelectedRtf = characterSheet[4].Rtf;
        }
    }
}
