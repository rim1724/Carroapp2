using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Game_Caro
{
    public partial class InputIP : Form
    {
        public string IPAddress { get; private set; }
        public InputIP()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
            btnOK.Click += BtnOK_Click;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtIPAddress.Text))
            {
                IPAddress = txtIPAddress.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập địa chỉ IP hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
