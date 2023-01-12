using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


[TestClass]
public class UITests
{
    private IWebDriver driver;

    [TestInitialize]
    public void SetUp()
    {
        driver = new ChromeDriver();
    }

    [TestMethod]
    public void TestAddition()
    {
        //Arrange
        driver.Navigate().GoToUrl("file:///X:/Parte%202/Index.html");
        IWebElement num1 = driver.FindElement(By.Id("num1"));
        IWebElement num2 = driver.FindElement(By.Id("num2"));
        IWebElement addButton = driver.FindElement(By.Id("add-button"));
        IWebElement result = driver.FindElement(By.Id("result"));
        num1.SendKeys("2");
        num2.SendKeys("3");
        //Act
        addButton.Click();
        //Assert
        Assert.AreEqual("5", result.Text);
        
    }

    [TestCleanup]
    public void TearDown()
    {
        driver.Quit();
    }
}