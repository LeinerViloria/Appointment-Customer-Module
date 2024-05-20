
using Appointment.SDK.Backend.Controllers;
using Appointment.SDK.Backend.Validations;
using Entities = Customer.Entities;

namespace Appointment.Customer.Controllers;

public class AppointmentDetailController(IServiceProvider serviceProvider) : StandardController<Entities.AppointmentDetail, BaseControllerValidator<Entities.AppointmentDetail>>(serviceProvider)
{
}