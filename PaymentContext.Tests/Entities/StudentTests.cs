using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities;
[TestClass]
public class StudentTests
{
    [TestMethod]
    public void TestMethod1()
    {
        var student = new Student("Alisson", "Silva", "41182779808", "alissoneear@gmail.com");
        var subscription = new Subscription();
        student.AddSubscription(subscription);
    }
}
