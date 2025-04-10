using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appRH.Models
{
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }  // Foreign Key to Employee

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }  // Nullable for indefinite contracts

        [Required]
        [StringLength(50)]
        public string ContractType { get; set; }  // e.g., "Full-Time", "Part-Time", "Freelance"

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        // Navigation Property
        public Employee Employee { get; set; }
    }
}
