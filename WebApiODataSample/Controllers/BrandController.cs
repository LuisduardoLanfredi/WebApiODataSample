﻿using System.Linq;
using System.Web.Http;
using System.Web.OData;
using WebApiODataSample.Database;

namespace WebApiODataSample.Controllers
{
    [EnableQuery]
    public class BrandController : ODataController
    {
        public IHttpActionResult Get()
        {
            return Ok(DataSource.Instance.Brands);
        }
    }
}