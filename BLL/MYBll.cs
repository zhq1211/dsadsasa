using System;
using Model;
using DAL;
using Microsoft.Extensions.Options;
using System.Collections.Generic;

namespace BLL
{
    public class MYBll
    {
        //public IOptions<ConnectionStrings> _conn;
        MYDal dal;
        public MYBll(IOptions<ConnectionStrings> conn)
        {
           
            dal = new MYDal(conn);
        }

        public List<Studnet> GetStudent()
        {
            return dal.GetStudent();
        }
        public int Remove(int id)
        {
            return dal.Remove(id);
        }

        public int AddStudent(Studnet model)
        {
            return dal.AddStudent(model);
        }
        public List<BanJi> GetBanJi()
        {
            return dal.GetBanJi();
        }
    }
}
