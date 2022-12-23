using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using CursoWinFormsBiblioteca.DataBases;
using System.Data;

namespace CursoWinFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do Cliente é obrigatório!")]
            [RegularExpression("([0-9])+", ErrorMessage = "Código do Cliente aceita somente valores numéricos.")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do Cliente deve ter 6 dígitos.")]
            public string Id { get; set; }

            [Required(ErrorMessage = "Nome do Cliente é obrigatório!")]
            [StringLength(50, ErrorMessage = "Nome do Cliente deve ter no máximo 50 caracteres.")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Nome da Mãe é obrigatório!")]
            [StringLength(50, ErrorMessage = "Nome da Mãe deve ter no máximo 50 caracteres.")]
            public string NomeMae { get; set; }

            [StringLength(50, ErrorMessage = "Nome do Pai deve ter no máximo 50 caracteres.")]
            public string NomePai { get; set; }

            public int NaoTemPai { get; set; }

            [Required(ErrorMessage = "CPF do Cliente é obrigatório!")]
            public string Cpf { get; set; }

            [Required(ErrorMessage = "Gênero do Cliente é obrigatório!")]
            public int Genero { get; set; }

            [Required(ErrorMessage = "CEP do Cliente é obrigatório!")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 dígitos.")]
            public string Cep { get; set; }

            [Required(ErrorMessage = "Logradouro é obrigatório!")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres.")]
            public string Logradouro { get; set; }

            [Required(ErrorMessage = "Complemento é obrigatório!")]
            [StringLength(50, ErrorMessage = "Complemento deve ter no máximo 50 caracteres.")]
            public string Complemento { get; set; }

            [Required(ErrorMessage = "Bairro é obrigatório!")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres.")]
            public string Bairro { get; set; }

            [Required(ErrorMessage = "Estado é obrigatório!")]
            [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres.")]
            public string Estado { get; set; }

            [Required(ErrorMessage = "Cidade é obrigatório!")]
            [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres.")]
            public string Cidade { get; set; }

            [Required(ErrorMessage = "Telefone é obrigatório!")]
            public string Telefone { get; set; }

            public string Profissao { get; set; }

            [Required(ErrorMessage = "Renda Familiar é obrigatória!")]
            public string RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                //Captura todos os erros possíveis
                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if (this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais.");
                }
                if (this.NaoTemPai == 0)
                {
                    if (this.NomePai == "")
                    {
                        throw new Exception("Nome do Pai não pode estar vazio quando a propriedade Pai Desconhecido não estiver marcada.");
                    }
                }
                bool validaCPF = Cls_Uteis.Valida(this.Cpf);
                if (validaCPF == false)
                {
                    throw new Exception("CPF inválido!");
                }
            }

            #region "CRUD do Fichario

            public void IncluirFichario(string Conexao)
            {
                string clienteJson = Cliente.SerializedClass(this);
                Fichario F = new Fichario(Conexao);
                if (F.status)
                {
                    F.Incluir(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public Unit BuscarFichario(string id, string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    string clienteJson = F.Buscar(id);
                    return Cliente.DesSerializedClass(clienteJson);
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public void AlterarFichario(string conexao)
            {
                string clienteJson = Cliente.SerializedClass(this);
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    F.Alterar(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public void ExcluirFichario(string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    F.Excluir(this.Id);
                    if (!(F.status))
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public List<string> ListaFichario(string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    List<string> todosJson = F.BuscarTodos();
                    return todosJson;
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            #endregion

            #region "CRUD do FicharioDB Local DB

            public void IncluirFicharioDB(string Conexao)
            {
                string clienteJson = Cliente.SerializedClass(this);
                FicharioDB F = new FicharioDB(Conexao);
                if (F.status)
                {
                    F.Incluir(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public Unit BuscarFicharioDB(string id, string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    string clienteJson = F.Buscar(id);
                    return Cliente.DesSerializedClass(clienteJson);
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public void AlterarFicharioDB(string conexao)
            {
                string clienteJson = Cliente.SerializedClass(this);
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    F.Alterar(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public void ExcluirFicharioDB(string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    F.Excluir(this.Id);
                    if (!(F.status))
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public List<List<string>> BuscarFicharioTodosDB(string conexao)
            {
                FicharioDB F = new FicharioDB(conexao);
                if (F.status)
                {
                    List<string> List = new List<string>();
                    List = F.BuscarTodos();
                    if (F.status)
                    {
                        List<List<string>> ListaBusca = new List<List<string>>();
                        for (int i = 0; i <= List.Count - 1; i++)
                        {
                            Cliente.Unit C = Cliente.DesSerializedClass(List[i]);
                            ListaBusca.Add(new List<string> { C.Id, C.Nome });
                        }
                        return ListaBusca;
                    }
                    else
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            #endregion

            #region "CRUD do FicharioDB SQLServer

            public void IncluirFicharioSQL(string Conexao)
            {
                string clienteJson = Cliente.SerializedClass(this);
                FicharioSQLServer F = new FicharioSQLServer(Conexao);
                if (F.status)
                {
                    F.Incluir(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public Unit BuscarFicharioSQL(string id, string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    string clienteJson = F.Buscar(id);
                    return Cliente.DesSerializedClass(clienteJson);
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public void AlterarFicharioSQL(string conexao)
            {
                string clienteJson = Cliente.SerializedClass(this);
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    F.Alterar(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public void ExcluirFicharioSQL(string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    F.Excluir(this.Id);
                    if (!(F.status))
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            public List<List<string>> BuscarFicharioTodosSQL(string conexao)
            {
                FicharioSQLServer F = new FicharioSQLServer(conexao);
                if (F.status)
                {
                    List<string> List = new List<string>();
                    List = F.BuscarTodos();
                    if (F.status)
                    {
                        List<List<string>> ListaBusca = new List<List<string>>();
                        for (int i = 0; i <= List.Count - 1; i++)
                        {
                            Cliente.Unit C = Cliente.DesSerializedClass(List[i]);
                            ListaBusca.Add(new List<string> { C.Id, C.Nome });
                        }
                        return ListaBusca;
                    }
                    else
                    {
                        throw new Exception(F.msg);
                    }
                }
                else
                {
                    throw new Exception(F.msg);
                }
            }

            #endregion

            #region "CRUD do FicharioDB SQLServer Relacional"

            #region "Funções auxiliares"

            public string ToInsert()
            {
                string sql;
                sql = @"INSERT INTO TB_Cliente
                        (Id
                        ,Nome
                        ,NomeMae
                        ,NomePai
                        ,NaoTemPai
                        ,Cpf
                        ,Genero
                        ,Cep
                        ,Logradouro
                        ,Complemento
                        ,Bairro
                        ,Estado
                        ,Cidade
                        ,Telefone
                        ,Profissao
                        ,RendaFamiliar) 
                        VALUES ";

                sql += "('" + this.Id + "', '" + this.Nome + "', '" + this.NomeMae + "', '" + this.NomePai + "', " + Convert.ToString(this.NaoTemPai) +
                    ", '" + this.Cpf + "', " + Convert.ToString(this.Genero) + ", '" + this.Cep + "', '" + this.Logradouro + "', '" + this.Complemento +
                    "', '" + this.Bairro + "', '" +this.Estado + "', '" + this.Cidade + "', '" + this.Telefone + "', '" + this.Profissao + 
                    "', " + Convert.ToString(this.RendaFamiliar) + ");";

                return sql;
            }

            public string ToUpdate(string Id)
            {
                string sql;
                sql = @"UPDATE TB_Cliente 
                        SET ";
                sql += "Id = '" + this.Id + "'";
                sql += ", Nome = '" + this.Nome + "'";
                sql += ", NomeMae = '" + this.NomeMae + "'";
                sql += ", NomePai = '" + this.NomePai + "'";
                sql += ", NaoTemPai = " + Convert.ToString(this.NaoTemPai) + "";
                sql += ", Cpf = '" + this.Cpf + "'";
                sql += ", Genero = " + Convert.ToString(this.Genero) + "";
                sql += ", Cep = '" + this.Cep + "'";
                sql += ", Logradouro = '" + this.Logradouro + "'";
                sql += ", Complemento = '" + this.Complemento + "'";
                sql += ", Bairro = '" + this.Bairro + "'";
                sql += ", Estado = '" + this.Estado + "'";
                sql += ", Cidade = '" + this.Cidade + "'";
                sql += ", Telefone = '" + this.Telefone + "'";
                sql += ", Profissao = '" + this.Profissao + "'";
                sql += ", RendaFamiliar = " + Convert.ToString(this.RendaFamiliar) + "";
                sql += " WHERE Id= '" + Id + "';";

                return sql;
            }

            public Unit DataRowToUnit(DataRow dr)
            {
                Unit u = new Unit();
                u.Id = dr["Id"].ToString();
                u.Nome = dr["Nome"].ToString();
                u.NomeMae = dr["NomeMae"].ToString();
                u.NomePai = dr["NomePai"].ToString();
                u.NaoTemPai = Convert.ToInt32(dr["NaoTemPai"]);
                u.Cpf = dr["Cpf"].ToString();
                u.Genero = Convert.ToInt32(dr["Genero"]);
                u.Cep = dr["Cep"].ToString();
                u.Logradouro = dr["Logradouro"].ToString();
                u.Complemento = dr["Complemento"].ToString();
                u.Bairro = dr["Bairro"].ToString();
                u.Estado = dr["Estado"].ToString();
                u.Cidade = dr["Cidade"].ToString();
                u.Telefone = dr["Telefone"].ToString();
                u.Profissao = dr["Profissao"].ToString();
                u.RendaFamiliar = dr["RendaFamiliar"].ToString();

                return u;
            }

            #endregion

            public void IncluirFicharioSQLRel()
            {
                try
                {
                    string sql;
                    sql = this.ToInsert();
                    var db = new SQLServerClass();
                    db.SQLCommand(sql);
                    db.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Inclusão não permitida. Identificador: " + this.Id + " " + ex.Message);
                }
            }

            public Unit BuscarFicharioSQLRel(string id)
            {
                try
                {
                    string sql = "SELECT * FROM [TB_Cliente] WHERE Id = '" + id + "'";
                    var db = new SQLServerClass();
                    var dt = db.SQLQuery(sql);
                    if (dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Identificador não existente: " + id);
                    }
                    else
                    {
                        Unit u = this.DataRowToUnit(dt.Rows[0]);
                        return u;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao buscar o conteúdo do identificador. " + ex.Message);
                }
            }

            public void AlterarFicharioSQLRel()
            {
                try
                {
                    string sql = "SELECT * FROM [TB_Cliente] WHERE Id = '" + this.Id + "'";
                    var db = new SQLServerClass();
                    var dt = db.SQLQuery(sql);
                    if (dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Identificador não existente: " + this.Id);
                    }
                    else
                    {
                        sql = this.ToUpdate(this.Id);
                        db.SQLCommand(sql);
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao alterar o conteúdo do identificador. " + ex.Message);
                }
            }

            public void ExcluirFicharioSQLRel()
            {
                try
                {
                    string sql = "SELECT * FROM [TB_Cliente] WHERE Id = '" + this.Id + "'";
                    var db = new SQLServerClass();
                    var dt = db.SQLQuery(sql);
                    if (dt.Rows.Count == 0)
                    {
                        db.Close();
                        throw new Exception("Identificador não existente: " + this.Id);
                    }
                    else
                    {
                        sql = "DELETE FROM TB_Cliente WHERE Id = '" + this.Id + "'";
                        db.SQLCommand(sql);
                        db.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao excluir o conteúdo do identificador. " + ex.Message);
                }
            }

            public List<List<string>> BuscarFicharioTodosSQLRel()
            {
                List<List<string>> ListaBusca = new List<List<string>>();
                try
                {
                    var sql = "SELECT * FROM TB_Cliente";
                    var db = new SQLServerClass();
                    var dt = db.SQLQuery(sql);
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        ListaBusca.Add(new List<string> { dt.Rows[i]["Id"].ToString(), dt.Rows[i]["Nome"].ToString() });
                    }
                    return ListaBusca;
                }
                catch (Exception ex)
                {
                    throw new Exception("Conexão com a base ocasionou um erro: " + ex.Message);
                }
            }

            #endregion
        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }

        public static Unit DesSerializedClass(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerializedClass(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
