using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IDataProvider
    {
        DataTable ExecuteQuery(string sql);
        int ExecuteNonQuery(string sql);
    }
}
