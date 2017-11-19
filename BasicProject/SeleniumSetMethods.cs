using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace BasicProject
{
    public static class SeleniumSetMethods
    {
        //Extended method for entering text in the control
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);
            //if(elementtype == PropertyType.Id)
            //    PropertiesCollection.driver.FindElement(By.Id(element)).SendKeys(value);
            //if (elementtype == PropertyType.Name)
            //    PropertiesCollection.driver.FindElement(By.Name(element)).SendKeys(value);
        }

        //Click into a button, Checkbox, option etc
        public static void Clicks(this IWebElement element)
        {
            element.Click();
            //if (elementtype == PropertyType.Id)
            //    PropertiesCollection.driver.FindElement(By.Id(element)).Click();
            //if (elementtype == PropertyType.Name)
            //    PropertiesCollection.driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(this IWebElement element, string value)
        {
            new SelectElement(element).SelectByText(value);
            //if (elementtype == PropertyType.Id)
            //    new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))).SelectByText(value);
            //if (elementtype == PropertyType.Name)
            //    new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element))).SelectByText(value); 
        }
    }
}
