namespace Blog.Tests
{
    using Blog.Tests.HelperFiles;
    using Blog.Tests.Models;
    using Blog.Tests.Pages.HomePage;
    using Blog.Tests.Pages.LogInPage;
    using Blog.Tests.Pages.RegisterPage;
    using Newtonsoft.Json;
    using NUnit.Framework;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Support.UI;
    using System;
    using System.IO;
    using System.Reflection;
    using System.Threading;

    [TestFixture]
    public class Tests
    {
        private ChromeDriver driver;
        private WebDriverWait wait;
        private HomePage HomePage;
        private RegisterPage RegisterPage;
        private LogInPage LogInPage;


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            HomePage = new HomePage(driver);
            RegisterPage = new RegisterPage(driver);
            LogInPage = new LogInPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void SampleLogInTest()
        {
            //Read user from json file and convert to user object
            var validRegisteredUser = FileReader.GetFileContent("ValidRegisteredUser.json", "Jsons");
            var ValidRegisteredUser = JsonConvert.DeserializeObject<RegistrationUser>(validRegisteredUser);

            //Set up LogIn page and fill the form with the user's data
            LogInPage.Navigate();
            LogInPage.FillLogInForm(ValidRegisteredUser);
            Thread.Sleep(2000);

            //Write Asserts...
        }
    }
}
