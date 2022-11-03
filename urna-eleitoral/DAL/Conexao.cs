using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class Conexao
    {
        public static string StringDeConexao
        {
            get
            {
                return @"user ID=SA;Initial Catalog=Urna; Data Source=.\SQLEXPRESS2019; Password=Senailab02";
            }
        }
    }
}