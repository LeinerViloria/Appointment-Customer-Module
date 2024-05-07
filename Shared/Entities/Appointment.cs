using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Appointment.SDK.Entities;
using Configuration.Entities;

namespace Customer.Entities;

public class Appointment : BaseEntity<int>
{
    [Required]
    public DateTime AssignmentDate {get; set;}

    [Required]
    public bool Attended {get; set;}

    [Required]
    [ForeignKey("Customer")]
    public int RowidCustomer {get; set;}
    public Customer? Customer { get; set; }

    [Required]
    [ForeignKey("Employee")]
    public int RowidEmployee {get; set;}
    public Employee? Employee { get; set; }
}