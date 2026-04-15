using Ucu.Poo.TestDateFormat;

namespace Library.Tests;

public class DateFormatterTests
{
    private DateFormatter df;
    [SetUp]
    public void Setup()
    {
        df = new DateFormatter();
    }

    [Test]
    public void ChangeFormat_ValidInputDate_ReturnConvertedDate()
    {
        string dateTest = "12/05/2004";
        Assert.That(df.ChangeFormat(dateTest), Is.EqualTo("2004-05-12"));
    }

    [Test]
    public void ChangeFormat_InvalidInputDate_ReturnsEmpty()
    {
        string dateTest = "9082/3";
        Assert.IsEmpty(df.ChangeFormat(dateTest));
    }

    [Test]
    public void ChangeFormat_EmptyInput_ReturnsEmpty()
    {
        string dateTest = "";
        Assert.IsEmpty(df.ChangeFormat(dateTest));
    }
}