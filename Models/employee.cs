using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_second.Models
{
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public string jobtitle { get; set; }
        public  string? address { get; set; }
        [ForeignKey(nameof(department))]
        public int deptid { get; set; }
        public department department { get; set; }
    }
}
