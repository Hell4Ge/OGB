using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OGB
{
    public partial class LoginDialog : Form
    {
        public String server { get; set; }
        public String username { get; set; }
        public String password { get; set; }

        public LoginDialog()
        {
            InitializeComponent();
        }

        private void BTN_Send_Click(object sender, EventArgs e)
        {
            this.server = TB_Server.Text;
            this.username = TB_Username.Text;
            this.password = TB_Password.Text;
            this.Close();
        }
    }
}
