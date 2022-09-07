namespace TestDateFormat;
using NUnit.Framework;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FormatoCorrecto()
    {
        string nuevafecha = DateFormatter.ChangeFormat("10/11/1997");
        Assert.AreEqual(nuevafecha, "1997-11-10");
    }

    [Test]
    public void FormatoIncorrecto()
    {
        string nuevafecha = DateFormatter.ChangeFormat("10,11,19");
        Assert.AreNotEqual(nuevafecha, "1997-11-10");
    }

    [Test]
    public void FechaBlanco()
    {
        string nuevafecha = DateFormatter.ChangeFormat("");
        Assert.IsEmpty(nuevafecha);
    }
}