using System.ComponentModel.DataAnnotations;
namespace Demo_Webapii.Models
{
    public class EmployeeClass
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }  // ?(questionmark after string) for nullable(to accept null values)  
        public string? Designation { get; set; }
        public float Salary { get; set; }


    }
}
