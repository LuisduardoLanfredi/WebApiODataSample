using System.Linq;
using System.Web.Http;
using System.Web.OData;
using System.Web.OData.Query;
using WebApiODataSample.Database;

namespace WebApiODataSample.Controllers
{
    [EnableQuery]
    public class CarSecureController : ODataController
    {
        [EnableQuery(MaxTop = 5)]
        public IHttpActionResult Get()
        {
            return Ok(DataSource.Instance.Cars);
        }
    }
}
