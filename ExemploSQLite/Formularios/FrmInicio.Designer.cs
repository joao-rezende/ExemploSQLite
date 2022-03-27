namespace ExemploSQLite
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbAcesso = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLedLogado = new System.Windows.Forms.PictureBox();
            this.listUsuarios = new System.Windows.Forms.ListView();
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nivel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLedLogado)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel.Controls.Add(this.lbNomeUsuario);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.lbAcesso);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.pbLedLogado);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 521);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 40);
            this.panel.TabIndex = 0;
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Location = new System.Drawing.Point(150, 13);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(10, 13);
            this.lbNomeUsuario.TabIndex = 4;
            this.lbNomeUsuario.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário:";
            // 
            // lbAcesso
            // 
            this.lbAcesso.AutoSize = true;
            this.lbAcesso.Location = new System.Drawing.Point(83, 13);
            this.lbAcesso.Name = "lbAcesso";
            this.lbAcesso.Size = new System.Drawing.Size(13, 13);
            this.lbAcesso.TabIndex = 2;
            this.lbAcesso.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso:";
            // 
            // pbLedLogado
            // 
            this.pbLedLogado.Image = global::ExemploSQLite.Properties.Resources.ledVermelho;
            this.pbLedLogado.Location = new System.Drawing.Point(5, 5);
            this.pbLedLogado.Name = "pbLedLogado";
            this.pbLedLogado.Size = new System.Drawing.Size(30, 30);
            this.pbLedLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLedLogado.TabIndex = 0;
            this.pbLedLogado.TabStop = false;
            // 
            // listUsuarios
            // 
            this.listUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nome,
            this.username,
            this.status,
            this.nivel});
            this.listUsuarios.HideSelection = false;
            this.listUsuarios.Location = new System.Drawing.Point(13, 37);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(759, 468);
            this.listUsuarios.TabIndex = 1;
            this.listUsuarios.UseCompatibleStateImageBehavior = false;
            this.listUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // nome
            // 
            this.nome.Text = "Nome";
            this.nome.Width = 258;
            // 
            // username
            // 
            this.username.Text = "Username";
            this.username.Width = 282;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 101;
            // 
            // nivel
            // 
            this.nivel.Text = "Nível";
            this.nivel.Width = 113;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 2;
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logonToolStripMenuItem1,
            this.logoffToolStripMenuItem1});
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem1.Text = "Login";
            // 
            // logonToolStripMenuItem1
            // 
            this.logonToolStripMenuItem1.Name = "logonToolStripMenuItem1";
            this.logonToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.logonToolStripMenuItem1.Text = "Logon";
            this.logonToolStripMenuItem1.Click += new System.EventHandler(this.logonToolStripMenuItem_Click);
            // 
            // logoffToolStripMenuItem1
            // 
            this.logoffToolStripMenuItem1.Name = "logoffToolStripMenuItem1";
            this.logoffToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.logoffToolStripMenuItem1.Text = "Logoff";
            this.logoffToolStripMenuItem1.Click += new System.EventHandler(this.logoffToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // logonToolStripMenuItem
            // 
            this.logonToolStripMenuItem.Name = "logonToolStripMenuItem";
            this.logonToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // logoffToolStripMenuItem
            // 
            this.logoffToolStripMenuItem.Name = "logoffToolStripMenuItem";
            this.logoffToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // FrmInicio
            // 
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.listUsuarios);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplo SQLite";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLedLogado)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox pbLedLogado;
        public System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbAcesso;
        private System.Windows.Forms.ListView listUsuarios;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader username;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.ColumnHeader nivel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logonToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoffToolStripMenuItem1;
    }
}

