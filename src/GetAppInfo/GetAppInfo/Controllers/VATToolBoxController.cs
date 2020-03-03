using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Models;
using Newtonsoft.Json;
using ServiceReference1;

namespace MyFirstDotNetCoreApp.Controllers
{

    [Route("VATToolBox")]
    // ReSharper disable once InconsistentNaming
    public class VATToolBoxController : Controller
    {
        private readonly AppSettings _appSettings;

        public VATToolBoxController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        [HttpGet]
        [Route("DisplayEnvironment")]
        public AppSettings DisplayEnvironment()
        {
            //            var rateVersion = new RateVersion { Version = 2.02, VersionDate = new DateTime(2013, 01, 12).ToString("yyyyMMdd"), Status = "OK" };
            var appSettings = new AppSettings {Environment = _appSettings.Environment};
            // uncomment to shut this endpoint down
            //                var rateVersion = new RateVersion { Version = 2.06, VersionDate = new DateTime(2013, 01, 16).ToString("yyyyMMdd"), Status = "UPGRADE_NOW" };
            return appSettings;
        }

    }
}
