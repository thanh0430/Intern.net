using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intern.net
{
    string sqlConnection = "Data Source=localhost ;Initial Catalog=PhoneStore;User ID=sa;Password=04032002";
    DbConnection connection = new SqlConnection(sqlConnection);

    connection.Open();
          using (DbCommand command = connection.CreateCommand())
          {
              // Câu truy vấn SQL
              command.CommandText = "select * from sanPhams";
              var reader = command.ExecuteReader();
    // Đọc kết quả truy vấn
    Console.WriteLine("\r\nCÁC SẢN PHẨM:");
                Console.WriteLine($"{"SanphamID ",10} {"TenSanPham "}");
                while (reader.Read()) 
                {
                    Console.WriteLine($"{reader["TenSanpham"],10}");
                }
            }

            connection.Close();
}
