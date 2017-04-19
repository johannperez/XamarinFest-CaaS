using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using XamarinFest_1.Model;

namespace XamarinFest_1.Controllers
{
    public class GiftsController : ApiController
    {
        public async Task<System.Web.Http.Results.JsonResult<List<string>>> Get()
        {
            using (var db = new Context())
            {
                return Json<List<string>>(
                    db.Orders.ToList()
                    .OrderBy(o => Guid.NewGuid())
                    .Take(4)
                    .Select(o => $"{o.Name} {o.LastName}")
                .ToList());
            }
        }
    }
}