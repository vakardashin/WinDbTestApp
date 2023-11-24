using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDbTestApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMySql_Click(object sender, EventArgs e)
        {
            string s = MySqlDbHelper.DoDbTest();
            MessageBox.Show(s);
        }
    }
}
