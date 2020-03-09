using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SampleProjectonCI
{
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver;
        [Test]
        public void TestMethod1()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("q")).SendKeys("est");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [Test]
        public void TestMethod2()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("q")).SendKeys("est");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [Test]
        public void TestMethod3()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("qrs")).SendKeys("est");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [Test]
        public void TestMethod4()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("q")).SendKeys("est");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [Test]
        public void TestMethod5()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("q")).SendKeys("est");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [Test]
        public void TestMethod6()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("q")).SendKeys("est");
            Thread.Sleep(1200);
            driver.FindElement(By.Name("btnK")).Click();
            driver.Close();
        }
        [OneTimeTearDown]
        public void MyTestCleanup()
        {
            driver.Quit();
        }

    }
}