using BLL;
using Models;
using System.Linq.Expressions;

namespace urnaeleitoral
{ 
   internal class Program
    {
       static void Main(string[] args)
       {
         Eleitor eleitor = new Eleitor("felisberto", "123456789");

          EleitorBLL eleitorBLL = new EleitorBLL();
          eleitorBLL.Inserir(eleitor);

          Eleicao eleicao = new Eleicao(2022, 1);
          EleicaoBLL eleicaoBLL = new EleicaoBLL();
           eleicaoBLL.Inserir(eleicao);
       }
   }
}
    





