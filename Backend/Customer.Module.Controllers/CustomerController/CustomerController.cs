
using Appointment.SDK.Backend.Controllers;
using Microsoft.AspNetCore.Mvc;
using Entities = Customer.Entities;

namespace Appointment.Customer.Controllers;

[Route("api/[controller]")]
public class CustomerController(IServiceProvider serviceProvider) : StandardController<Entities.Customer>(serviceProvider)
{
}