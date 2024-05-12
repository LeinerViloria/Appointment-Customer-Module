
using Appointment.SDK.Backend.Database;
using Microsoft.EntityFrameworkCore;

namespace Customer.Module.Backend.Database;

public class CustomerContext(DbContextOptions options) : StoreContext(options)
{
    public DbSet<Entities.Customer> Customers { get; set; }
    public DbSet<Entities.Appointment> Appointments { get; set; }
    public DbSet<Entities.AppointmentDetail> AppointmentsDetails { get; set;}
}