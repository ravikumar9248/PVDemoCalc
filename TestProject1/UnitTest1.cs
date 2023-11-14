using ClassLibrary1;

namespace TestProject1
{
  public class Tests
  {
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Addition()
    {
      Class1 c = new Class1();
      var result = c.Addition(2, 3);
      Assert.AreEqual(5, result);
    }

    [Test]
    public void Test_Substraction()
    {
      Class1 c = new Class1();
      var result = c.Substraction(3, 1);
      Assert.AreEqual(2, result);
    }
  }
}