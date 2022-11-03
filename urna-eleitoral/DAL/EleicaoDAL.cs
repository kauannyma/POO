using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
  public class EleicaoDAL
    {
        public void Inserir(Eleicao _eleicao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = @"INSERT INTO Eleicao (Ano,Turno)
                               Values (@Ano, @Turno)";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
            cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
        public void Excluir(Eleicao _eleicao)
        {

        }
        public void Alterar(Eleicao _eleicao)
        {

        }
        public List<Eleicao> Buscar(int _ano, int _turno)
        {
            return new List<Eleicao>();

        }

    }
}
   
