using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Appointment.Globals.Enums;
using Appointment.SDK.Entities;
using Configuration.Entities;

namespace Customer.Entities;

public class Appointment : BaseEntity<int>
{
    [Required]
    public DateTime AssignmentDate {get; set;}

    [Required]
    public EnumAppointmentState State {get; set;} = EnumAppointmentState.Scheduled;

    [Required]
    [ForeignKey("Customer")]
    public int RowidCustomer {get; set;}
    public Customer? Customer { get; set; }

    [Required]
    [ForeignKey("Employee")]
    public int RowidEmployee {get; set;}
    public Employee? Employee { get; set; }

    [Required]
    [ForeignKey("Service")]
    public int RowidService {get; set;}
    public Service? Service { get; set; }
}