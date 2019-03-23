using OpenQA.Selenium;

namespace Blog.Tests.Pages.HomePage
{
    public partial class HomePage
    {
        public IWebElement HelloWorldBlog => Wait.Until(d => {return d.FindElement(By.XPath("//*[@class='row']/div[1]//h2/a")); });
        public IWebElement ProBlog => Wait.Until(d => { return d.FindElement(By.XPath("//*[@class='row']/div[2]//h2/a")); });
        public IWebElement BlogUpdate => Wait.Until(d => { return d.FindElement(By.XPath("//*[@class='row']/div[3]//h2/a")); });
    }
}
