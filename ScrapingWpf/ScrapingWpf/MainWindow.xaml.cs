using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using OpenQA.Selenium.Support.UI;

namespace ScrapingWpf
{
    public partial class MainWindow : Window
    {

        private static IWebDriver driver;

        public MainWindow()
        {
            InitializeComponent();

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.reverbnation.com/");

            var discoverButton = driver.FindElement(By.Id("menu-item-discover"));
            discoverButton.Click();

            var collections = driver.FindElements(By.ClassName("card__contents"));

            foreach (var collection in collections)
            {
                Console.WriteLine(collection.Text);
            }
        }

        public void Scraping() { }



    }
}
