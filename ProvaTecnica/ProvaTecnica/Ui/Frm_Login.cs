using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProvaTecnica.Code.BLL;
using ProvaTecnica.Code.DTO;

namespace ProvaTecnica.Ui
{
    public partial class Frm_Login : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();

        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                Form1 form1 = new Form1();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique seu email e senha.","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
