using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Quản_lý_linh_kiện_máy_tính
{
    class KetNoi
    {
        SqlConnection connection = new SqlConnection("server=THANGIKCU;database=QuanLyLinhKien;uid=sa;pwd=123456a@");

        public int dangnhap(string sql)
        {
            connection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table.Rows.Count;
        }
    }
}
