using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands;
[TestClass]
public class CreateBoletoSubscriptionCommandTests
{
    //Red, Green, Refactor
    [TestMethod]
    public void ShouldReturnErrorWhenNameIsInvalid()
    {
        var command = new CreateBoletoSubscriptionCommand();
        command.FirstName = "";

        command.Validate();
        Assert.AreEqual(false, command.IsValid);
    }
}
