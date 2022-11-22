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

            Cmb_Estado.Items.Add("Acre (AC)");
            Cmb_Estado.Items.Add("Alagoas (AL)");
            Cmb_Estado.Items.Add("Amapá (AP)");
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
    }
}
