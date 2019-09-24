using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escaper
{
    public partial class Escaper : Form
    {
        public Escaper()
        {
            InitializeComponent();
        }

        private EscapeConverter converter = new EscapeConverter();

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            OutputTextBox.Text = converter.FromString(InputTextBox.Text)
                                          .ToEscapedString();
        }

        private void ArrowLabel_Click(object sender, EventArgs e)
        {
            InputTextBox_TextChanged(sender, e);
        }
    }
}
