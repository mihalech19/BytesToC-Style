using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BytesArray_Parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox1.Text.Replace(" ", ", 0x");
            richTextBox2.Text = richTextBox2.Text.Insert(0, "{ 0x");
            richTextBox2.Text = richTextBox2.Text.Insert(richTextBox2.TextLength, " }");
        }
    }
}
