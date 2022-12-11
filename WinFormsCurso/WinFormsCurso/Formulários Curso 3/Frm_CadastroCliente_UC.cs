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
using CursoWinFormsBiblioteca.DataBases;
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
            Tls_Principal.Items[1].ToolTipText = "Buscar um cliente já cadastrado";
            Tls_Principal.Items[2].ToolTipText = "Atualize o cliente já existente";
            Tls_Principal.Items[3].ToolTipText = "Apaga o cliente selecionado";
            Tls_Principal.Items[4].ToolTipText = "Limpa dados da tela de entrada de dados";

            Btn_Busca.Text = "Buscar";
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            Txt_Codigo.Text = "";
            Txt_Bairro.Text = "";
            Mask_CEP.Text = "";
            Txt_Complemento.Text = "";
            Mask_CPF.Text = "";
            Cmb_Estado.SelectedIndex = -1;
            Txt_Logradouro.Text = "";
            Txt_NomeCliente.Text = "";
            Txt_NomeMae.Text = "";
            Txt_NomePai.Text = "";
            Txt_Profissao.Text = "";
            Mask_RendaFamiliar.Text = "";
            Mask_Telefone.Text = "";
            Txt_Cidade.Text = "";
            Chk_TemPai.Checked = false;
            Rdb_Masculino.Checked = true;
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
                C.IncluirFichario("C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                MessageBox.Show("Identificador incluído com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //string clienteJson = Cliente.SerializedClass(C);

                //Fichario F = new Fichario("C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                //if (F.status)
                //{
                //    F.Incluir(C.Id, clienteJson);
                //    if (F.status)
                //    {
                //        MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    else
                //    {
                //        MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
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
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFichario(Txt_Codigo.Text, "C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }

                    //Fichario F = new Fichario("C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                    //if (F.status)
                    //{
                    //    string clienteJson = F.Buscar(Txt_Codigo.Text);
                    //    Cliente.Unit C = new Cliente.Unit();
                    //    C = Cliente.DesSerializedClass(clienteJson);
                    //    EscreveFormulario(C);
                    //}
                    //else
                    //{
                    //    MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = LeituraFormulario();
                    C.ValidaClasse();
                    C.ValidaComplemento();
                    C.AlterarFichario("C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                    MessageBox.Show("Identificador alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //string clienteJson = Cliente.SerializedClass(C);

                    //Fichario F = new Fichario("C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                    //if (F.status)
                    //{
                    //    F.Alterar(C.Id, clienteJson);
                    //    if (F.status)
                    //    {
                    //        MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
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
        }

        private void ApagaToolStripButton_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text == "")
            {
                MessageBox.Show("Código do Cliente vazio.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFichario(Txt_Codigo.Text, "C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                        Frm_Questao Db = new Frm_Questao("icons8_query_801", "Você quer excluir esse cliente?");
                        Db.ShowDialog();
                        if (Db.DialogResult == DialogResult.Yes)
                        {
                            C.ExcluirFichario("C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                            MessageBox.Show("Identificador excluído com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //Fichario F = new Fichario("C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                //if (F.status)
                //{
                //    string clienteJson = F.Buscar(Txt_Codigo.Text);
                //    Cliente.Unit C = new Cliente.Unit();
                //    C = Cliente.DesSerializedClass(clienteJson);
                //    EscreveFormulario(C);

                //    Frm_Questao Db = new Frm_Questao("icons8_query_801", "Você quer excluir esse cliente?");
                //    Db.ShowDialog();
                //    if (Db.DialogResult == DialogResult.Yes)
                //    {
                //        F.Excluir(Txt_Codigo.Text);
                //        if (F.status)
                //        {
                //            MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            LimparFormulario();
                //        }
                //        else
                //        {
                //            MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void LimparToolStripButton_Click(object sender, EventArgs e)
        {
            LimparFormulario();
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

        void EscreveFormulario(Cliente.Unit C)
        {
            Txt_Codigo.Text = C.Id;
            Txt_NomeCliente.Text = C.Nome;
            Txt_NomeMae.Text = C.NomeMae;

            if (C.NaoTemPai == true)
            {
                Chk_TemPai.Checked = true;
                Txt_NomePai.Text = "";
            }
            else
            {
                Chk_TemPai.Checked = false;
                Txt_NomePai.Text = C.NomePai;
            }

            if (C.Genero == 0)
            {
                Rdb_Masculino.Checked = true;
            }
            if (C.Genero == 1)
            {
                Rdb_Feminino.Checked = true;
            }
            if (C.Genero == 2)
            {
                Rdb_Indefinido.Checked = true;
            }

            Mask_CPF.Text = C.Cpf;

            Mask_CEP.Text = C.Cep;
            C.Cep = Regex.Replace(C.Cep, "-", "");
            C.Cep = Regex.Replace(C.Cep, @"\s", "");

            Txt_Logradouro.Text = C.Logradouro;
            Txt_Complemento.Text = C.Complemento;
            Txt_Cidade.Text = C.Cidade;
            Txt_Bairro.Text = C.Bairro;

            Mask_Telefone.Text = C.Telefone;
            C.Telefone = Regex.Replace(C.Telefone, @"[^\d]", "");

            Txt_Profissao.Text = C.Profissao;

            if (C.Estado == "")
            {
                Cmb_Estado.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i <= Cmb_Estado.Items.Count -1; i++)
                {
                    if (C.Estado == Cmb_Estado.Items[i].ToString())
                    {
                        Cmb_Estado.SelectedIndex = i;
                    }
                }
            }

            Mask_RendaFamiliar.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            Mask_RendaFamiliar.Text = C.RendaFamiliar;
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

        private void Btn_Busca_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente.Unit C = new Cliente.Unit();
                List<string> List = new List<string>();
                List = C.ListaFichario("C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                if (List == null || List.Count == 0)
                {
                    MessageBox.Show("Base de dados vazia. Não existe nenhum identificador cadastrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    List<List<string>> ListaBusca = new List<List<string>>();
                    for (int i = 0; i <= List.Count - 1; i++)
                    {
                        C = Cliente.DesSerializedClass(List[i]);
                        ListaBusca.Add(new List<string> { C.Id, C.Nome });
                    }

                    Frm_Busca FB = new Frm_Busca(ListaBusca);
                    FB.ShowDialog();
                    if (FB.DialogResult == DialogResult.OK)
                    {
                        var idSelect = FB.idSelect;
                        C = C.BuscarFichario(idSelect, "C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
                        if (C == null)
                        {
                            MessageBox.Show("Identificador não encontrado.", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            EscreveFormulario(C);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Fichario F = new Fichario("C:\\Users\\Iara Camargos\\Documents\\Curso WindowsForms\\WinFormsCurso\\Fichario");
            //if (F.status)
            //{
            //    List<string> List = new List<string>();
            //    List = F.BuscarTodos();
            //    if (F.status)
            //    {
            //        List<List<string>> ListaBusca = new List<List<string>>();
            //        for (int i = 0; i <= List.Count - 1; i++)
            //        {
            //            Cliente.Unit C = Cliente.DesSerializedClass(List[i]);
            //            ListaBusca.Add(new List<string> { C.Id, C.Nome });
            //        }
            //        Frm_Busca FB = new Frm_Busca(ListaBusca);
            //        FB.ShowDialog();
            //        if (FB.DialogResult == DialogResult.OK)
            //        {
            //            var idSelect = FB.idSelect;
            //            string clienteJson = F.Buscar(idSelect);
            //            Cliente.Unit C = new Cliente.Unit();
            //            C = Cliente.DesSerializedClass(clienteJson);
            //            EscreveFormulario(C);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(F.msg, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
