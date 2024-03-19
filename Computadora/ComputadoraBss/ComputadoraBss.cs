using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputadoraBss;
using System.Data.SqlClient;
using ComputadoraDal;

namespace ComputadoraBss
{
    public class ComputadoraBss
    {
        ComputadoraBss Dal = new ComputadoraBss();
        public DataTable ListarComputadoraBss()
        {
            return Dal.ListarComputadoraBss();
        }
    }
}
