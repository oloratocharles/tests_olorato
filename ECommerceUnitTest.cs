  using NUnit.Framework;

//get selenium dependencies
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace OLORATO_CUCUMBER_TESTS
{
    [TextFixture]
    public class Tests
    {
        //opening
        [OneTimeSetUp]
        public void SetupBrowser()
        {
            driver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            
        }

         public void Goto(string url)
        {
            webDriver.Url = url;
        }

        //Login Functionality Test
        public void VerifyLogin()
        {
            m_driver = new driver();
            m_driver.Url = "http://automationpractice.com";
            m_driver.Manage().Window.Maximize();

             
			//locate text boxes --email nd password for login				
            IWebElement emailTextBox = m_driver.FindElement(By.Id("email"));
            IWebElement passwrdTestBox = m_driver.FindElement(By.Id("psswrd"));
            IWebElement signUpBtn = m_driver.FindElement(By.Id("SubmitLogin"));

            emailTextBox.SendKeys("oloratocharles1@gmail.com");
            passwrdTestBox.SendKeys("123456");
            signUpBtn.Click();

             
        }

        [Test]
        public void Test1(){
            Assert.Pass();
        }
        
    }
    class NUnit_test_search()
    {
        Tests brow = new Tests();
        String urlForTests = "http://automationpractice.com";
        IWebDriver driver;
        
 
        [SetUp]
        public void getBrowserToStart()
        {
            brow.Init_Browser();
        }

        //Search Functionality Test
        [Test]
        public void TestSearchForItems()
        {
            brow.Goto(urlForTests);
            System.Threading.Thread.Sleep(4000);
 
            driver = brow.getDriver;
 
            //url
            //driver.url ="http://automationpractice.com/";
            
            IWebElement searchfield = driver.FindElement(By.XPath("//*[Id@'search_query_top']");
            //IWebElement validations = driver.FindElement(By.Id("validations"));

            searchfield.SendKeys("dress");
            //search_query_top.SendKeys("\t");

            //submit
            searchfield.submit();

            
            //pause
            System.Threading.Thread.Sleep(2000);
            Assert.Pass();

        
        
        }
       
        //Check product description
        [Test]
        public void CheckProductDescription()
        {
            driver.FindElement(By.PartialLinkText("Brush")).Click();
            var description = driver.FindElement(By.Id("product_reference")).Text;
            Assert.AreEqual("Printed Dress", description);
            }
 
        [TearDown]
        public void close_Browser()
        {
            //brow.Close();
        }
    }
    }
}