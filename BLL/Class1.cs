using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class Class1
    {
        public static bool isLoing(string name,string pwd)
        {
            string strSQL = "select * from users where id='" + name + "' and pwd='" + pwd + "';";
            DataTable dt = new DataTable();
            dt = ConnHelper.getDT(strSQL);
            if (dt.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
