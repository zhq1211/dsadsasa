using Microsoft.AspNetCore.Mvc;
using Model;
using BLL;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
namespace WebApplication1_DapperLXZHQ.Controllers
{
    public class MyController : Controller
    {
        public IOptions<ConnectionStrings> _conn;
        MYBll bll;
        public MyController(IOptions<ConnectionStrings> conn)
        {
            _conn = conn;
            bll = new MYBll(conn);
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public int Add(Studnet obj)
        {
            return bll.AddStudent(obj);
        }
        public string Index1()
        {
            var list = bll.GetStudent();

            return JsonConvert.SerializeObject(list);
        }
        public int Remove(int id)
        {
            int row = bll.Remove(id);
            return row;
        }

        public int AddStudent(Studnet model)
        {
            int row = bll.AddStudent(model);
            return row;
        }

        public string GetBanJi()
        {
            var list = bll.GetBanJi();
            return JsonConvert.SerializeObject(list);
        }
    }
}
