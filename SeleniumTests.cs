using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumWebdriverTask2
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver { get; set; }
        private WebDriverWait wait;
        public static TestContext TestContext { get; set; }

        public static string ApplicationUrl => TestContext.Parameters.Get("ApplicationUrl").ToString();

        [SetUp]
        public void Setup()
        {
            // Initialize Chrome driver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // Set implicit wait for elements

            // Initialize explicit wait
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [TestCase("BLOCKCHAIN")]
        [TestCase("Cloud")]
        [TestCase("Automation")]
        public void ValidateGlobalSearchWorks(string searchKeyword)
        {
            // Navigate to the website
            driver.Navigate().GoToUrl(ApplicationUrl);

            // Find the "Accept All" cookies button using ID locator and click on it
            IWebElement acceptButton = wait.Until<IWebElement>((d) => d.FindElement(By.Id("onetrust-accept-btn-handler")));
            acceptButton.Click();

            // Find the magnifier icon using XPath and click on it
            var searchIcon = driver.FindElement(By.XPath("//button[contains(@class,'header-search__button')]"));
            searchIcon.Click();

            // Find the search input field by name attribute and enter the keyword
            var searchInput = driver.FindElement(By.Name("q"));
            searchInput.Clear();
            searchInput.SendKeys(searchKeyword);

            // Click the "Find" button (using XPath)
            IWebElement findButton = driver.FindElement(By.XPath("//span[@class='bth-text-layer' and normalize-space(text())='Find']"));
            findButton.Click();

            // Wait for the results to load using explicit wait
            wait.Until(d => d.FindElement(By.CssSelector(".search-results__item")));

            // Validate that all search result titles contain the search keyword
            var resultLinks = driver.FindElements(By.CssSelector(".search-results__item"));
            Assert.That(resultLinks.All(link => link.Text.Contains(searchKeyword, StringComparison.OrdinalIgnoreCase)),
                $"Not all results contain the keyword: {searchKeyword}");
        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}