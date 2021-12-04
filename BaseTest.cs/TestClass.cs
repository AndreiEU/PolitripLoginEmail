using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenSolutions.BaseClass
{
    public class BaseTest
    {
        public IWebDriver driver;

        [OneTimeSetUp]
      public void Open()
        {
            driver = new ChromeDriver(); 
            driver.Url = "https://politrip.com/account/sign-up";
        }

        [OneTimeTearDown]
        public void Close()
        {
            driver.Quit();
        }
    }
}


///////////



using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HeavenSolutions.BaseClass;


namespace HeavenSolutions
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test]
        public void TestMethod1()
        {
            
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            emailTextField.SendKeys("Selenium C#");
          
        }

        [Test]
        public void TestMethod2()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            emailTextField.SendKeys("Selenium C#");

        }

        [Test]
        public void TestMethod3()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id = 'email']"));
            emailTextField.SendKeys("Selenium C#");

        }
    }
}
