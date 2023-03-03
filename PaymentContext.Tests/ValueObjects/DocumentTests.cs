using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects;
[TestClass]
public class DocumentTests
{
    //Metodologia -> Red, Green, Refactor
    [TestMethod]
    public void ShouldReturnErrorWhenCNPJIsInvalid()
    {
        var doc = new Document("123", Domain.Enums.EDocumentType.CNPJ);
        Assert.IsTrue(!doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnSuccessWhenCNPJIsValid()
    {
        var doc = new Document("34110468000150", Domain.Enums.EDocumentType.CNPJ);
        Assert.IsTrue(doc.IsValid);
    }

    [TestMethod]
    public void ShouldReturnErrorWhenCPFIsInvalid()
    {
        var doc = new Document("340", Domain.Enums.EDocumentType.CPF);
        Assert.IsTrue(!doc.IsValid);
    }

    [TestMethod]
    [DataTestMethod]
    [DataRow("45478912304")]
    [DataRow("45452112304")]
    [DataRow("45478944404")]
    [DataRow("45478978904")]
    [DataRow("41178912304")]
    [DataRow("41182779808")]
    public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
    {
        var doc = new Document(cpf, Domain.Enums.EDocumentType.CPF);
        Assert.IsTrue(doc.IsValid);
    }
}
