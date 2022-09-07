using TestDateFormat;
namespace Library.Tests;
//fecha en formato correcto
//una  fecha que no tenga el formato correcto
//una fecha   en blanco
public class DateFormatterTests
{
    

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FormatoCorrecto()
    {
        string expected = "1997-11-10";
        string prueba = "10/11/1997";
        string actual= DateFormatter.ChangeFormat(prueba);
        Assert.AreEqual(expected,actual);
    }

    [Test]
    public void FormatoIncorrecto()
    {
        string prueba = "10/11/1997";
        string actual= DateFormatter.ChangeFormat(prueba);
        Assert.AreNotEqual(prueba,actual);
    }
    [Test]
    public void Fechaenblanco()
    {
        const string prueba = "10/11/1997";
        string expected = DateFormatter.ChangeFormat(prueba);
        Assert.IsNotNull(expected);
    }
    
}