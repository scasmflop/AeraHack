using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using HackApp.Contracts;
using Newtonsoft.Json;

namespace HackApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private const string baseUri = "https://aerahackproxy.azurewebsites.net/AeraHack2/api/";
        public ActionResult Index()
        {

            claims
            using (HttpClient httpClient = new HttpClient())
            {
                var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Ik1uQ19WWmNBVGZNNXBPWWlKSE1iYTlnb0VLWSIsImtpZCI6Ik1uQ19WWmNBVGZNNXBPWWlKSE1iYTlnb0VLWSJ9.eyJhdWQiOiJodHRwczovL3NjYXNtZmxvcGhvdG1haWwub25taWNyb3NvZnQuY29tL0FlcmFIYWNrMiIsImlzcyI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0LzQ1ZGZlNWRlLWFmY2UtNDMwNy1iMmMwLTVkMmQ2YTczMThjYy8iLCJpYXQiOjE0NjQzMDI5NjQsIm5iZiI6MTQ2NDMwMjk2NCwiZXhwIjoxNDY0MzA2ODY0LCJhcHBpZCI6IjAzZTdiMjc5LTQxNjAtNDA4ZS1hZGI0LWQyNjcyNjgzNTUyZCIsImFwcGlkYWNyIjoiMSIsImlkcCI6Imh0dHBzOi8vc3RzLndpbmRvd3MubmV0LzQ1ZGZlNWRlLWFmY2UtNDMwNy1iMmMwLTVkMmQ2YTczMThjYy8iLCJvaWQiOiJiM2MyMWVmNy1hMmM1LTQ1MzgtYjEwMC1hZmU4NzMyNGRhNTUiLCJzdWIiOiJiM2MyMWVmNy1hMmM1LTQ1MzgtYjEwMC1hZmU4NzMyNGRhNTUiLCJ0aWQiOiI0NWRmZTVkZS1hZmNlLTQzMDctYjJjMC01ZDJkNmE3MzE4Y2MiLCJ2ZXIiOiIxLjAifQ.LcYMyRrVrSEgm33o4fWwcdaye8eAY4AFq-ZCcOv42xBNKddQ7CAkp2WHabUhyJBP9JTN2kTBS7-BxSIMmn51xgcIEs9Mm_8RFe1ZT8E74BRhKb8gjqVC_XyM_SzS9PLGbzC_YmxoGzcTx1ReVSNxc9ETju-PBQNt4xMElcl5XwpDzIG52hpsZ1jlyqie2myCrrJJ2VkAvhHg6w1igcrO6miNNhINPzriSuo3tI7gdqVLfjDqA-KjPFCluMDxQlfLND7t6L4f1GknMwYVqLrUi_1Bvtg2iy4DwznpdkDpE1RPti1MdyWJk_aKrT69hphu13HRaoCx_WbQePb7Uygjfg";
                httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                
                var uri = string.Format("{0}hackwells",baseUri);
                var result = httpClient.GetStringAsync(uri).Result;
                ViewBag.WellList = JsonConvert.DeserializeObject<List<Completion>>(result);
                uri = string.Format("{0}values", baseUri);
                ViewBag.UserInfo = JsonConvert.DeserializeObject<string[]>(httpClient.GetStringAsync(uri).Result);

            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}