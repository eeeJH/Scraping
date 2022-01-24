using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// Selenium
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Chromium;
using OpenQA.Selenium.Support.UI;

namespace ScrapingWpf
{
    public partial class MainWindow : Window
    {

        private static IWebDriver driver;

        public MainWindow()
        {
            InitializeComponent();

            ChromiumNetworkConditions conditions = new ChromiumNetworkConditions();

            driver = new ChromeDriver();
            
            //driver.Navigate().GoToUrl("https://www.reverbnation.com/");
            driver.Navigate().GoToUrl("https://velog.io/");

            /*
            var discoverButton = driver.FindElement(By.Id("menu-item-discover"));
            discoverButton.Click();
            */
            var collections = FindElements(By.ClassName("description-wrapper"));

            foreach (var collection in collections)
            {
                Console.WriteLine(collection.Text);
            }
        }

        static IReadOnlyCollection<IWebElement> FindElements(By by)
        {
            Stopwatch w = Stopwatch.StartNew();

            while (w.ElapsedMilliseconds < 10 * 1000)
            {

                var elements = driver.FindElements(by);

                if (elements.Count > 0) { return elements; }

                Thread.Sleep(10);
            }

            //return null;
            return new ReadOnlyCollection<IWebElement>(new List<IWebElement>());
        }

    }
}
