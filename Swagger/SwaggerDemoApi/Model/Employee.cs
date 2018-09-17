using System.ComponentModel.DataAnnotations;

namespace SwaggerDemoApi.Model
{
    public class Employee
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        public bool IsPermanent { get; set; }
    }
}