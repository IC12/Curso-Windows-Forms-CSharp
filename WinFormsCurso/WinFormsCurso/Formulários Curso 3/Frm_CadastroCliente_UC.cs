using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWinFormsBiblioteca;
using CursoWinFormsBiblioteca.Classes;
using Microsoft.VisualBasic;

namespace WinFormsCurso
{
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();
            Grp_Codigo.Text = "Código";
            Grp_DadosPessoais.Text = "Dados Pessoais";
            Grp_Endereco.Text = "Endereço";
            Grp_Outros.Text = "Outros";
            Lbl_Bairro.Text = "Bairro";
            Lbl_CEP.Text = "CEP";
            Lbl_Complemento.Text = "Complemento";
            Lbl_CPF.Text = "CPF";
            Lbl_Estado.Text = "Estado";
            Lbl_Logradouro.Text = "Logradouro";
            Lbl_NomeCliente.Text = "Nome";
            Lbl_NomeMae.Text = "Nome da Mãe";
            Lbl_NomePai.Text = "Nome do Pai";
            Lbl_Profissao.Text = "Profissão";
            Lbl_RendaFamiliar.Text = "Renda Familiar";
            Lbl_Telefone.Text = "Telefone";
            Lbl_Cidade.Text = "Cidade";
            Chk_TemPai.Text = "Pai desconhecido";
            Rdb_Masculino.Text = "Masculino";
            Rdb_Feminino.Text = "Feminino";
            Rdb_Indefinido.Text = "Indefinido";

            Cmb_Estado.Items.Clear();

            Cmb_Estado.Items.Add("Acre(AC)");
            Cmb_Estado.Items.Add("Alagoas(AL)");
            Cmb_Estado.Items.Add("Amapá(AP)");
            Cmb_Estado.Items.Add("Amazonas(AM)");
            Cmb_Estado.Items.Add("Bahia(BA)");
            Cmb_Estado.Items.Add("Ceará(CE)");
            Cmb_Estado.Items.Add("Distrito Federal(DF)");
            Cmb_Estado.Items.Add("Espírito Santo(ES)");
            Cmb_Estado.Items.Add("Goiás(GO)");
            Cmb_Estado.Items.Add("Maranhão(MA)");
            Cmb_Estado.Items.Add("Mato Grosso(MT)");
            Cmb_Estado.Items.Add("Mato Grosso do Sul(MS)");
            Cmb_Estado.Items.Add("Minas Gerais(MG)");
            Cmb_Estado.Items.Add("Pará(PA)");
            Cmb_Estado.Items.Add("Paraíba(PB)");
            Cmb_Estado.Items.Add("Paraná(PR)");
            Cmb_Estado.Items.Add("Pernambuco(PE)");
            Cmb_Estado.Items.Add("Piauí(PI)");
            Cmb_Estado.Items.Add("Rio de Janeiro(RJ)");
            Cmb_Estado.Items.Add("Rio Grande do Norte(RN)");
            Cmb_Estado.Items.Add("Rio Grande do Sul(RS)");
            Cmb_Estado.Items.Add("Rondônia(RO)");
            Cmb_Estado.Items.Add("Roraima(RR)");
            Cmb_Estado.Items.Add("Santa Catarina(SC)");
            Cmb_Estado.Items.Add("São Paulo(SP)");
            Cmb_Estado.Items.Add("Sergipe(SE)");
            Cmb_Estado.Items.Add("Tocantins(TO)");

            Tls_Principal.Items[0].ToolTipText = "Incluir na base de dados um novo cliente";
            Tls_Principal.Items[1].ToolTipText = "Capturar um cliente já cadastrado";
            Tls_Principal.Items[2].ToolTipText = "Atualize o cliente já existente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpa dados da tela de entrada de dados";
        }

        private void Chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (Chk_TemPai.Checked)
            {
                Txt_NomePai.Enabled = false;
            }
            else
            {
                Txt_NomePai.Enabled = true;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.ValidaClasse();
                C.ValidaComplemento();
                MessageBox.Show("Classe foi inicializada sem erros", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão ABRIR");
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão SALVAR");
        }

        private void ApagaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão APAGAR");
        }

        private void LimparToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão LIMPAR");
        }

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();
            C.Id = Txt_Codigo.Text;
            C.Nome = Txt_NomeCliente.Text;
            C.NomeMae = Txt_NomeMae.Text;
            C.NomePai = Txt_NomePai.Text;
            if (Chk_TemPai.Checked)
            {
                C.NaoTemPai = true;
            }
            else
            {
                C.NaoTemPai = false;
            }
            if (Rdb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            if (Rdb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            if (Rdb_Indefinido.Checked)
            {
                C.Genero = 2;
            }
            C.Cpf = Mask_CPF.Text;

            C.Cep = Mask_CEP.Text;
            C.Cep = Regex.Replace(C.Cep, "-", "");
            C.Cep = Regex.Replace(C.Cep, @"\s", "");

            C.Logradouro = Txt_Logradouro.Text;
            C.Complemento = Txt_Complemento.Text;
            C.Cidade = Txt_Cidade.Text;
            C.Bairro = Txt_Bairro.Text;
            if (Cmb_Estado.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = Cmb_Estado.Items[Cmb_Estado.SelectedIndex].ToString();
            }

            C.Telefone = Mask_Telefone.Text;
            C.Telefone = Regex.Replace(C.Telefone, @"[^\d]", "");

            C.Profissao = Txt_Profissao.Text;

            Mask_RendaFamiliar.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            C.RendaFamiliar = Mask_RendaFamiliar.Text;
            
            return C;
        }

        private void Mask_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = Mask_CEP.Text;
            vCep = Regex.Replace(vCep, "-", "");
            vCep = Regex.Replace(vCep, @"\s", "");

            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = Cls_Uteis.GeraJSONCEP(vCep);

                        Cep.Unit CEP = new Cep.Unit();
                        CEP = Cep.DesSerializedClass(vJson);

                        Txt_Logradouro.Text = CEP.logradouro;
                        Txt_Bairro.Text = CEP.bairro;
                        Txt_Cidade.Text = CEP.localidade;

                        Cmb_Estado.SelectedIndex = -1;
                        for (int i = 0; i <= Cmb_Estado.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(Cmb_Estado.Items[i].ToString(), "(" + CEP.uf + ")");
                            if (vPos > 0)
                            {
                                Cmb_Estado.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }
    }
}
