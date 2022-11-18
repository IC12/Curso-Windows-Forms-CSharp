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

        public Frm_PrincipalMenu_UC()
        {
            InitializeComponent();

            novoToolStripMenuItem.Enabled = false;
            fecharAbaToolStripMenuItem.Enabled = false;
            abrirImagemToolStripMenuItem.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
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
                Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.SelectedTab);
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
                    Tbc_Aplicacoes.TabPages.Remove(Tbc_Aplicacoes.TabPages[i]);
                }

                novoToolStripMenuItem.Enabled = false;
                fecharAbaToolStripMenuItem.Enabled = false;
                abrirImagemToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = false;
                conectarToolStripMenuItem.Enabled = true;
            }
        }
    }
}
