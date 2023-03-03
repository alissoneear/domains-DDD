using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;
using System.Xml.Linq;

namespace PaymentContext.Domain.ValueObjects;
public class Name : ValueObject
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;

        AddNotifications(new Contract<Notification>().Requires()
            .IsGreaterOrEqualsThan(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
            .IsGreaterOrEqualsThan(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
            .IsLowerOrEqualsThan(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres"));
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
}