using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appRH.Models
{
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }
        [ForeignKey("Id")]
        public int EmployeeId { get; set; }  

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }  

        [Required]
        [StringLength(50)]
        public string ContractType { get; set; } 

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }

        // Navigation Property
        public Employee Employee { get; set; }
    }
}
