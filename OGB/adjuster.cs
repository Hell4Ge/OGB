using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGB
{
    public partial class adjuster : UserControl
    {
        public int BID;
        public adjuster()
        {
            InitializeComponent();
        }

        private void BTN_Plus_Click(object sender, EventArgs e)
        {
            String v = TB_Value.Text;
            int val = int.Parse(v);
            val++;
            TB_Value.Text = val.ToString();
        }

        private void BTN_Down_Click(object sender, EventArgs e)
        {
            String v = TB_Value.Text;
            int val = int.Parse(v);
            val--;
            TB_Value.Text = val.ToString();
        }
    }
}
