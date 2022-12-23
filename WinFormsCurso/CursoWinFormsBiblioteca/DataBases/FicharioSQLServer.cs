using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWinFormsBiblioteca.DataBases
{
    public class FicharioSQLServer
    {
        public string msg;
        public bool status;
        public string tabela;
        public SQLServerClass db;

        public FicharioSQLServer(string Tabela)
        {
            status = true;
            try
            {
                db = new SQLServerClass();
                tabela = Tabela;
                msg = "Conexão com a Tabela criada com sucesso.";
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Conexão com a Tabela deu erro: " + ex.Message;
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                //INSERT INTO CLIENTE (ID, JSON) VALUES ('000000','{.....}')

                var SQL = "INSERT INTO " + tabela + " (Id, JSON) VALUES ('" + Id + "', '" + jsonUnit + "')";
                db.SQLCommand(SQL);
                status = true;
                msg = "Inclusão efetuada com sucesso. Identificador: " + Id;
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Conexão com o Fichário com erro: " + ex.Message;
            }
        }

        public string Buscar(string Id)
        {
            status = true;
            try
            {
                //SELECT ID, JSON FROM CLIENTE WHERE ID = '000000'

                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE Id = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows[0]["JSON"].ToString();
                    status = true;
                    msg = "Busca efetuada com sucesso. Identificador: " + Id;
                    return conteudo;
                }
                else
                {
                    status = false;
                    msg = "Identificador não existe: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Erro ao buscar o identificador: " + ex.Message;
            }
            return "";
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                //SELECT ID, JSON FROM CLIENTE

                var SQL = "SELECT Id, JSON FROM " + tabela;
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows[i]["JSON"].ToString();
                        List.Add(conteudo);
                    }
                    return List;
                }
                else
                {
                    status = false;
                    msg = "Não existem clientes na base de dados.";
                }
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Erro ao buscar os identificadores dos clientes: " + ex.Message;
            }
            return List;
        }

        public void Excluir(string Id)
        {
            status = true;
            try
            {
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE Id = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    //DELETE FROM CLIENTE WHERE ID = '000000'

                    SQL = "DELETE FROM " + tabela + " WHERE Id = '" + Id + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    msg = "Exclusão efetuada com sucesso. Identificador: " + Id;
                }
                else
                {
                    status = false;
                    msg = "Identificador não existe: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Erro ao buscar o identificador: " + ex.Message;
            }
        }

        public void Alterar(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                var SQL = "SELECT Id, JSON FROM " + tabela + " WHERE Id = '" + Id + "'";
                var dt = db.SQLQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    //UPDATE CLIENTE SET JSON = '{...}' WHERE ID = '000000'

                    SQL = "UPDATE " + tabela + " SET JSON = '" + jsonUnit + "' WHERE Id = '" + Id + "'";
                    db.SQLCommand(SQL);
                    status = true;
                    msg = "Alteração efetuada com sucesso. Identificador: " + Id;
                }
                else
                {
                    status = false;
                    msg = "Alteração não permitida pois o identificador não existe: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Conexão com o Fichário com erro: " + ex.Message;
            }
        }
    }
}
