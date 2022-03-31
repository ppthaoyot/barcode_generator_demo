using GenQRBarCode.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using static GenQRBarCode.Models.StandardBOT;

namespace GenQRBarCode.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var std = new List<StandardBOTDetail> {
                new StandardBOTDetail { TaxIDNo="0000000000000",Suffix="00",ReferenceNo1="000000000000000",ReferenceNo2="0000000000",Amount="1" },
            };

            var lst = new List<string>();
            foreach (var item in std)
            {
                var data = StandardBOT.GenerateBarCodeReturnBase64(item.TaxIDNo, item.Suffix, item.ReferenceNo1, item.ReferenceNo2, item.Amount);
                lst.Add(data);
            }

            ViewBag.Value = lst;

            return View();
        }
    }
}