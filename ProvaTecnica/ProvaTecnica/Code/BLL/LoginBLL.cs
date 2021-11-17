using ProvaTecnica.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaTecnica.Code.BLL
{
    class LoginBLL
    {
        Conexao conectar = new Conexao();
        string tabela = "tbl_login";

        public bool RealizarLogin(LoginDTO login)
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conectar.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
