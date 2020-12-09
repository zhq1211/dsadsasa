using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Options;
using Model;
namespace DAL
{
 public  class HelPer
    {
        public IOptions<ConnectionStrings> _conn;

        public HelPer(IOptions<ConnectionStrings> conn)
        {
            _conn = conn;
        }
    }
}
