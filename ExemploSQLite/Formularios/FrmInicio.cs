using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExemploSQLite.Formularios;
using ExemploSQLite.Classes;

namespace ExemploSQLite
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            FrmLogin frmLogin = new FrmLogin(this);
            frmLogin.ShowDialog();

            Iniciar_Tabela();
        }

        private void Iniciar_Tabela()
        {
            DataTable dt = BD.ObterTodosUsuarios();
            foreach (DataRow Row in dt.Rows)
            {
                string[] usuario = new string[] {
                    Row.Field<string>("nome"),
                    Row.Field<string>("username"),
                    Row.Field<string>("status"),
                    Row.Field<Int64>("nivel").ToString()
                };
                listUsuarios.Items.Add(new ListViewItem(usuario));
            }
        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin(this);
            frmLogin.ShowDialog();
        }

        private void logoffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbLedLogado.Image = Properties.Resources.ledVermelho;
            lbAcesso.Text = "0";
            lbNomeUsuario.Text = "-";
            Globais.nivel = 0;
            Globais.logado = false;
        }
    }
}
