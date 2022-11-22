using CursoWinFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCurso
{
    public partial class Frm_PrincipalMenu_UC : Form
    {
        int controlHelloWorld = 0;
        int controlDemonstracaoKey = 0;
        int controlMascara = 0;
        int ControlValidaCPF = 0;
        int ControlValidaCPF2 = 0;
        int ControlValidaSenha = 0;
        int ControlArqImg = 0;
        int ControlCadastroClientes = 0;

        public Frm_PrincipalMenu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            fecharAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            cadastrosToolStripMenuItem.Enabled = false;
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlDemonstracaoKey += 1;

            Frm_DemonstracaoKey_UC U = new Frm_DemonstracaoKey_UC();
            U.Dock = DockStyle.Fill;
            TabPage TP = new TabPage();
            TP.Name = "Demonstração Key " + controlDemonstracaoKey;
            TP.Text = "Demonstração Key " + controlDemonstracaoKey;
            TP.ImageIndex = 0;
            TP.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TP);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlHelloWorld += 1;

            Frm_HelloWorld_UC U = new Frm_HelloWorld_UC();
            U.Dock = DockStyle.Fill;
            TabPage TP = new TabPage();
            TP.Name = "Hello World " + controlHelloWorld;
            TP.Text = "Hello World " + controlHelloWorld;
            TP.ImageIndex = 1;
            TP.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TP);
        }

        private void mascaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlMascara += 1;

            Frm_Mascara_UC U = new Frm_Mascara_UC();
            U.Dock = DockStyle.Fill;
            TabPage TP = new TabPage();
            TP.Name = "Máscara " + controlMascara;
            TP.Text = "Máscara " + controlMascara;
            TP.ImageIndex = 2;
            TP.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TP);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlValidaCPF += 1;

            Frm_ValidaCPF_UC U = new Frm_ValidaCPF_UC();
            U.Dock = DockStyle.Fill;
            TabPage TP = new TabPage();
            TP.Name = "Valida CPF " + ControlValidaCPF;
            TP.Text = "Valida CPF " + ControlValidaCPF;
            TP.ImageIndex = 3;
            TP.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TP);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlValidaCPF2 += 1;

            Frm_ValidaCPF2_UC U = new Frm_ValidaCPF2_UC();
            U.Dock = DockStyle.Fill;
            TabPage TP = new TabPage();
            TP.Name = "Valida CPF2 " + ControlValidaCPF2;
            TP.Text = "Valida CPF2 " + ControlValidaCPF2;
            TP.ImageIndex = 4;
            TP.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TP);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlValidaSenha += 1;

            Frm_ValidaSenha_UC U = new Frm_ValidaSenha_UC();
            U.Dock = DockStyle.Fill;
            TabPage TP = new TabPage();
            TP.Name = "Valida Senha " + ControlValidaSenha;
            TP.Text = "Valida Senha " + ControlValidaSenha;
            TP.ImageIndex = 5;
            TP.Controls.Add(U);
            Tbc_Aplicacoes.TabPages.Add(TP);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fecharAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new OpenFileDialog();
            Db.InitialDirectory = "C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\WinFormsCurso\\Imagens";
            Db.Filter = "PNG|*.PNG";
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArqImg = Db.FileName;

                ControlArqImg += 1;

                Frm_ArqImg_UC U = new Frm_ArqImg_UC(nomeArqImg);
                U.Dock = DockStyle.Fill;
                TabPage TP = new TabPage();
                TP.Name = "Arquivo Imagem " + ControlArqImg;
                TP.Text = "Arquivo Imagem " + ControlArqImg;
                TP.ImageIndex = 6;
                TP.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TP);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login F = new Frm_Login();
            F.ShowDialog();

            if (F.DialogResult == DialogResult.OK)
            {
                string senha = F.senha;
                string login = F.login;

                if (Cls_Uteis.validaSenhaLogin(senha) == true)
                {
                    novoToolStripMenuItem.Enabled = true;
                    fecharAbaToolStripMenuItem.Enabled = true;
                    abrirImagemToolStripMenuItem.Enabled = true;
                    desconectarToolStripMenuItem.Enabled = true;
                    conectarToolStripMenuItem.Enabled = false;
                    cadastrosToolStripMenuItem.Enabled = true;

                    MessageBox.Show("Bem Vindo " + login + "!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Senha inválida! ", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Questao Db = new Frm_Questao("icons8_query_801", "Você deseja se desconectar?");
            Db.ShowDialog();

            if (Db.DialogResult == DialogResult.Yes)
            {
                //Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
                //Componentes do WF que são collections, para eliminar itens usando for, sempre de trás para frente
                for (int i = Tbc_Aplicacoes.TabPages.Count - 1; i >= 0; i+=-1)
                {
                    ApagaAba(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                fecharAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
                cadastrosToolStripMenuItem.Enabled = false;
            }
        }

        private void Tbc_Aplicacoes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();

                var vToolTip01 = DesenhaItemMenu("Apagar a Aba", "DeleteTab");
                var vToolTip02 = DesenhaItemMenu("Apagar Todas a Esquerda", "DeleteLeft");
                var vToolTip03 = DesenhaItemMenu("Apagar Todas a Direita", "DeleteRight");
                var vToolTip04 = DesenhaItemMenu("Apagar Todas Menos Esta", "DeleteAll");

                ContextMenu.Items.Add(vToolTip01);
                ContextMenu.Items.Add(vToolTip02);
                ContextMenu.Items.Add(vToolTip03);
                ContextMenu.Items.Add(vToolTip04);

                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip01.Click += new EventHandler(VToolTip01_Click);
                vToolTip02.Click += new EventHandler(VToolTip02_Click);
                vToolTip03.Click += new EventHandler(VToolTip03_Click);
                vToolTip04.Click += new EventHandler(VToolTip04_Click);
            }
        }

        ToolStripMenuItem DesenhaItemMenu(string text, string nomeImg)
        {
            var vToolTip = new ToolStripMenuItem();
            vToolTip.Text = text;

            Image MyImage = (Image)Properties.Resources.ResourceManager.GetObject(nomeImg);
            vToolTip.Image = MyImage;

            return vToolTip;
        }

        private void VToolTip01_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaAba(Tbc_Aplicacoes.SelectedTab);
            }
        }

        private void VToolTip02_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        private void VToolTip03_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        private void VToolTip04_Click(object sender, EventArgs e)
        {
            if (!(Tbc_Aplicacoes.SelectedTab == null))
            {
                ApagaEsquerda(Tbc_Aplicacoes.SelectedIndex);
                ApagaDireita(Tbc_Aplicacoes.SelectedIndex);
            }
        }

        void ApagaEsquerda(int ItemSelecionado)
        {
            for (int i = ItemSelecionado - 1; i >= 0; i += -1)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        void ApagaDireita(int ItemSelecionado)
        {
            for (int i = Tbc_Aplicacoes.TabCount - 1; i > ItemSelecionado; i += -1)
            {
                ApagaAba(Tbc_Aplicacoes.TabPages[i]);
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ControlCadastroClientes == 0)
            {
                ControlCadastroClientes += 1;

                Frm_CadastroCliente_UC U = new Frm_CadastroCliente_UC();
                U.Dock = DockStyle.Fill;
                TabPage TP = new TabPage();
                TP.Name = "Cadastro de Clientes ";
                TP.Text = "Cadastro de Clientes ";
                TP.ImageIndex = 7;
                TP.Controls.Add(U);
                Tbc_Aplicacoes.TabPages.Add(TP);
            }
            else
            {
                MessageBox.Show("Cadastro de Clientes já está aberto!", "Banco ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void ApagaAba(TabPage TB)
        {
            if (TB.Name == "Cadastro de Clientes")
            {
                ControlCadastroClientes = 0;
            }

            Tbc_Aplicacoes.TabPages.Remove(TB);
        }
    }
}
