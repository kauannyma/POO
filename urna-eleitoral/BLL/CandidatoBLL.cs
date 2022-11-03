using DAL;
using Models;

namespace BLL
{
    public class CandidatoBLL
    {
        public void Inserir(Candidato _candidato)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Inserir(_candidato);
        }

        public void Excluir(Candidato _candidato)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Excluir(_candidato);
        }

        public void Alterar(Candidato _candidato)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Alterar(_candidato);
        }

        public List<Candidato> Buscar(int _numero)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            return candidatoDAL.Buscar(_numero);
        }

    }
}