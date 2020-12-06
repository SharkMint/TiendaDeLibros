using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Tarea02AppWeb.Pages
{
    public class probarGetModel : PageModel
    {

        public Dictionary<string, string> ParamsQ;
        public void OnGet()
        {
            ParamsQ = new Dictionary<string, string>();
            if (Request.Query.Count > 0)
            {
                /*Enumeracion */
                foreach (string key in Request.Query.Keys)
                    ParamsQ.Add(key, Request.Query[key]);

            }
        }
    }
}
