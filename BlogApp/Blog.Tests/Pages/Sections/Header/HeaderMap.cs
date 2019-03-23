namespace Blog.Tests.Pages.Sections.Header
{
    using OpenQA.Selenium;

    public partial class Header
    {
        public IWebElement SoftuniblogLink => Wait.Until(d => { return d.FindElement(By.ClassName("navbar-brand")); });
        public IWebElement RegisterLink => Wait.Until(d => { return d.FindElement(By.Id("registerLink")); });
        public IWebElement LoginLink => Wait.Until(d => { return d.FindElement(By.Id("loginLink")); });
    }
}
