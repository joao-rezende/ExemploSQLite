using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExemploSQLite.Classes;

namespace ExemploSQLite.Formularios
{
    public partial class FrmLogin : Form
    {
        FrmInicio frmInicio;
        DataTable dt = new DataTable();

        public FrmLogin(FrmInicio form)
        {
            InitializeComponent();
            frmInicio = form;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            String username = tbUsername.Text;
            String senha = tbSenha.Text;

            if (username == "" || senha == "")
            {
                MessageBox.Show("Usuário e/ou senha inválidos");
                tbUsername.Focus();
                return;
            }

            string sql = "SELECT * FROM usuarios WHERE username = '" + username + "' AND senha = '" + senha + "'";
            dt = BD.consulta(sql);

            if (dt.Rows.Count > 0)
            {
                frmInicio.pbLedLogado.Image = Properties.Resources.ledVerde;
                frmInicio.lbAcesso.Text = dt.Rows[0].Field<Int64>("nivel").ToString();
                frmInicio.lbNomeUsuario.Text = dt.Rows[0].Field<string>("nome");
                Globais.nivel = int.Parse(dt.Rows[0].Field<Int64>("nivel").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
