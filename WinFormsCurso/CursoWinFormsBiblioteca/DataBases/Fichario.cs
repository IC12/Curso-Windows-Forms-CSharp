using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWinFormsBiblioteca.DataBases
{
    public class Fichario
    {
        public string diretorio;
        public string msg;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!(Directory.Exists(Diretorio)))
                {
                    Directory.CreateDirectory(Diretorio);
                }
                diretorio = Diretorio;
                msg = "Conexão com o Fichário criada com sucesso.";
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Conexão com o Fichário com erro: " + ex.Message;
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;

            try
            {
                if (File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    msg = "Inclusão não permitida pois o identificador já existe: " + Id;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    msg = "Inclusão efetuada com sucesso. Identificador: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Conexão com o Fichário com erro: " + ex.Message;
            }
        }

        public void Alterar(string Id, string jsonUnit)
        {
            status = true;

            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    msg = "Alteração não permitida pois o identificador não existe: " + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");

                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    status = true;
                    msg = "Alteração efetuada com sucesso. Identificador: " + Id;
                }
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
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    msg = "Identificador não existente: " + Id;
                }
                else
                {
                    string conteudo = File.ReadAllText(diretorio + "\\" + Id + ".json");
                    status = true;
                    msg = "Busca efetuada com sucesso. Identificador: " + Id;
                    return conteudo;
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
                var Arquivos = Directory.GetFiles(diretorio, "*.json");
                for (int i = 0; i <= Arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(Arquivos[i]);
                    List.Add(conteudo);
                }
                return List;
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Erro ao buscar o identificador: " + ex.Message;
            }
            return List;
        }

        public void Excluir(string Id)
        {
            status = true;
            try
            {
                if (!(File.Exists(diretorio + "\\" + Id + ".json")))
                {
                    status = false;
                    msg = "Identificador não existente: " + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    status = true;
                    msg = "Exclusão efetuada com sucesso. Identificador: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                msg = "Erro ao buscar o identificador: " + ex.Message;
            }
        }
    }
}
