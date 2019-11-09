using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication5
{
    public partial class InstagramCookie : UserControl
    {
        string fileName = MailForm.FILE_NAME;
        public InstagramCookie()
        {
            InitializeComponent();
        }

        private void InstagramCookie_Load(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {

            }
        }
    }
}
