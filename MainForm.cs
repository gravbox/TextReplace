using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReplace
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdGo_Click(object sender, EventArgs e)
        {
            var replacements = txtReplacements.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            var template = txtTemplate.Text;

            var sb = new StringBuilder();
            foreach(var s in replacements)
            {
                var text = string.Format(template, s);
                text = text.Replace("%1%", s);
                sb.AppendLine(text);
            }
            txtOutput.Text = sb.ToString();

        }

        private void cmdCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtOutput.Text))
                Clipboard.SetText(txtOutput.Text);
        }
    }
}
