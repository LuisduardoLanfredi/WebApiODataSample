using Microsoft.OData.Edm;
using System.Web.Http;
using System.Web.Http.Filters;
using System.Web.OData.Batch;
using System.Web.OData.Builder;
using System.Web.OData.Extensions;
using WebApiODataSample.Models;

namespace WebApiODataSample
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.MapODataServiceRoute("odata", null, GetEdmModel(), new DefaultODataBatchHandler(GlobalConfiguration.DefaultServer));
            config
                .Count()
                .Filter()
                .OrderBy()
                .Expand()
                .Select();

            config.AddODataQueryFilter();
        }

        private static IEdmModel GetEdmModel()
        {
            ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
            
            builder.Namespace = "WebApiODataSample";
            builder.ContainerName = "DefaultContainer";

            var brand = builder.EntitySet<Brand>("Brand");
            var car = builder.EntitySet<Car>("Car");

            return builder.GetEdmModel();
        }
    }
}
