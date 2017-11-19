using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProject
{
    class Program
    {
        

        static void Main(string[] args)
        {
           
        }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            //Navigate to page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html?Username=&Password=&Login=Login");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Login to application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login("rz", "automation");

            pageEA.FillUserForm("Rz", "Renzo", "Castaneda");

            //pageEA.txtInitial.SendKeys("executeautomation");
            //pageEA.btnSave.Click();
            //EAPageObject page = new EAPageObject();    

            ////Title
            //SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);

            ////Initial
            //SeleniumSetMethods.EnterText("Initial", "executeautomation", PropertyType.Id);

            //Console.WriteLine("The value from my Title is: " + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));
            //Console.WriteLine("The value from my Initial is: " + SeleniumGetMethods.GetText("Initial", PropertyType.Name)); 

            ////Click
            //SeleniumSetMethods.Click("Save", PropertyType.Name);   


        }        

        [TearDown]
        public void CleanUp()
        {
            //Close browser  
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed de browser");
        }
    }
}
