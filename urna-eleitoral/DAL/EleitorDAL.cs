using Models;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EleitorDAL
    {
        public void Inserir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Eleitor (Titulo, Nome)
                               Values (@Titulo, @Nome)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
            cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        
        }
        public void Excluir(Eleitor _eleitor)
        {

        }
        public void Alterar(Eleitor _eleitor)
        {

        }
        public List<Eleitor> Buscar(string _titulo)
        {
            return new List<Eleitor>();

        }

    }
}