using System.ComponentModel.DataAnnotations;

namespace EmployeeDirectory.Models
{
    public class Employee
    {
        // Id
        public int Id { get; set; }

        // Name
        [Required(ErrorMessage = "Employee name is required")]
        [StringLength(100)]
        [Display(Name = "Employee Name")]
        public string Name { get; set; } = string.Empty;

        // Department
        [StringLength(100)]
        public string? Department { get; set; }

        // Salary
        [Required]
        public decimal Salary { get; set; }
    }
}
