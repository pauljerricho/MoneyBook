using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyBook
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "admin" && tbPw.Text == "1234")
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("암호가 일치하지 않습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbPw.Focus();
                tbPw.SelectAll();
            }
            
        }

        private void fLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 입력값 체크
                if (tbName.Text != "") tbPw.Focus();               
            }
        }

        private void tbPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // 입력값 체크
                if (this.tbPw.Text != "") btOK.Focus();
            }
        }
    }
}
