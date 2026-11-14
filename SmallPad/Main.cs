using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using VPKSoft.WinFormsRtfPrint;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        void PrintTextDoc()
        {
            if (rtbPad.Text == "")
            {
                MessageBox.Show("You cannot print a blank document.");
            }
            else
            {
                rtbPad.PrintWithDialog();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var n = new Main();
            n.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new OpenFileDialog();
            StreamReader sr;
            o.Filter = "Text Document (*.txt)|*.txt";
            o.CheckFileExists = true;
            o.Title = "Open...";
            o.ShowDialog();
            try
            {
                o.OpenFile();
                sr = System.IO.File.OpenText(o.FileName);
                rtbPad.Text = sr.ReadToEnd();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem when trying to open a text document: " + ex.ToString());
            }
            
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sas = new SaveFileDialog();
            StreamWriter sw;
            sas.Filter = "Text Document (*.txt)|*.txt";
            sas.CheckPathExists = true;
            sas.Title = "Save as...";
            sas.ShowDialog();
            try
            {
                sw = File.AppendText(sas.FileName);
                sw.Write(rtbPad.Text);
                sw.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintTextDoc();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
