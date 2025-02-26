using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBanHang
{
    public interface ISqlDatabase
    {
        SqlConnection GetConnection();
    }
}
