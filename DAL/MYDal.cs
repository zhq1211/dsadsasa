using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Options;
using Model;
using System.Linq;
namespace DAL
{
    public class MYDal
    {
        public IOptions<ConnectionStrings> _conn;
        IDbConnection dbconn;
        public MYDal(IOptions<ConnectionStrings> conn)
        {
            _conn = conn;
            dbconn = new SqlConnection(_conn.Value.Conn);
        }

        public List<Studnet> GetStudent()
        {
            string sql = "select * from Student";
            return dbconn.Query<Studnet>(sql).ToList();
        }

        public int Remove(int id)
        {
            string sql = $"delete from Student where StudentId={id}";
            int row = dbconn.Execute(sql);
            return row;
        }

        public int AddStudent(Studnet model)
        {
            int row = dbconn.Execute("insert into Student values(@StudentName,@StudentSex,@StudentAge,@BId)", model);
            return row;
        }

        public List<BanJi> GetBanJi()
        {
            string sql = "select * from BanJi";
            return dbconn.Query<BanJi>(sql).ToList();
        }
    }
}
