using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EleicaoBLL
    {
        public void Inserir(Eleicao _eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Inserir(_eleicao);
        }
        public void Excluir(Eleicao _eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Excluir(_eleicao);
        }
        public void Alterar(Eleicao _eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Alterar(_eleicao);
        }

        public List<Eleicao> Buscar(int _ano, int _turno)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.Buscar(_ano, _turno);
        }
    }
}
