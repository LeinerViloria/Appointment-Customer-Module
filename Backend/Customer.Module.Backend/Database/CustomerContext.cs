
using Appointment.SDK.Backend.Database;
using Microsoft.EntityFrameworkCore;

namespace Customer.Module.Backend.Database;

public class CustomerContext(DbContextOptions options) : StoreContext(options)
{
}