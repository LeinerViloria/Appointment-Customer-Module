using Appointment.SDK.Backend.Database;
using Appointment.SDK.Backend.Validations;
using Entities = Customer.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace Appointment.Customer.Controllers;

public class CustomerValidator : BaseControllerValidator<Entities.Customer>
{
    private readonly IServiceProvider ServiceProvider;
    public CustomerValidator(IServiceProvider serviceProvider)
    {
        ServiceProvider = serviceProvider;

        RuleFor(x => x)
            .Must(ExistsCustomer)
            .WithMessage("El cliente ya existe")
            .WithName("Id");
    }

    private bool ExistsCustomer(Entities.Customer Item)
    {
        dynamic factory = ServiceProvider.GetService(typeof(IDbContextFactory<StoreContext>))!;
        using (StoreContext Context = factory.CreateDbContext())
        {
            return !Context.Set<Entities.Customer>()
                .AsNoTracking()
                .Any(x => (x.Id == Item.Id || x.Email == Item.Email) && x.Rowid != Item.Rowid);
        }
    }
}