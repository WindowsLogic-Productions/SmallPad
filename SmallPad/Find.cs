using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Main rtb;
            if (MCCheckBox.Checked == true)
            {
                rtb.rtbPad.Find(txtSearchText.Text, 0, RichTextBoxFinds.MatchCase);
                rtb.rtbPad.Select();
            }
            else
            {
                rtb.rtbPad.Find(txtSearchText.Text, 0, RichTextBoxFinds.None);
                rtb.rtbPad.Select();
            }

        }
    }
}
