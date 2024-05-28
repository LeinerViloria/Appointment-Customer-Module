
using Appointment.SDK.Backend.Controllers;
using Entities = Customer.Entities;

namespace Appointment.Customer.Controllers;

public class CustomerController(IServiceProvider serviceProvider) : StandardController<Entities.Customer, CustomerValidator>(serviceProvider)
{
}