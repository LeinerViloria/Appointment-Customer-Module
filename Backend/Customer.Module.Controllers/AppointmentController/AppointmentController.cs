
using Appointment.SDK.Backend.Controllers;
using Appointment.SDK.Backend.Validations;
using Entities = Customer.Entities;

namespace Appointment.Customer.Controllers;

public class AppointmentController(IServiceProvider serviceProvider) : StandardController<Entities.Appointment, BaseControllerValidator<Entities.Appointment>>(serviceProvider)
{
}