using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiODataSample.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufactureYear { get; set; }
        public Brand Brand { get; set; }
    }
}