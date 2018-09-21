using AutotestsApp.Gui.Elements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Text.RegularExpressions;
using System.Globalization;

namespace AutotetsApp.Gui.Framework.Elements
{
    public class DataPicker : BaseElement
    {
        private Button _prev => new Button(By.XPath("//button[@class='prev'"), "Previous month", Driver);
        private Button _next => new Button(By.XPath("//button[@class='next'"), "Previous month", Driver);
        private Span _currentMonthAndYear => new Span(By.XPath("//div[@class='datepicker-component']//p"), "Year and Month label", Driver);


        public DataPicker(By locator, string name, IWebDriver driver) : base(locator, name, driver)
        {
        }

        public DataPicker Open()
        {
            GetElement().Click();
            return this;
        }

        public Int32 GetCurentMonth()
        {
            String str = _currentMonthAndYear.GetText();
            String month =Regex.Match(str, @"[A-Za-z]+").Value;
           return DateTime.ParseExact(month, "MMMM", new CultureInfo("en-US"))
                     .Month;

        }

        public Int32 GetCurentYear()
        {
            Int32 result;
            String str = _currentMonthAndYear.GetText();
            Int32.TryParse(Regex.Match(str, @"\d+").Value, out result);
            return result;
        }

        public DataPicker FindYear(Int32 year)
        {
            while (GetCurentYear() != year)
            {
                if (GetCurentYear() > year)
                    GoToPreviousMonth();
                else
                    GoToNextMonth();
            }
            return this;
        }

        public DataPicker FindMonth(Int32 month)
        {
            while (GetCurentYear() != month)
            {
                if (GetCurentYear() > month)
                    GoToPreviousMonth();
                else
                    GoToNextMonth();
            }
            return this;
        }

        public DataPicker FindDate(DateTime date)
        {
            FindYear(date.Year).
                FindMonth(date.Month);
            return this;
        }

        //public bool IsEnabled(DateTime date)
        //{
        //    //ul[@class = 'days']//li[not((contains(@class, 'disabled')  or contains(@class, 'weekday')))]
        //    return GetElement().GetAttribute()
        //}

        public DataPicker GoToPreviousMonth()
        {
            _prev.Click();
            return this;
        }

        public DataPicker GoToNextMonth()
        {
            _next.Click();
            return this;
        }

        public void SetDate(DateTime date)
        {
            FindDate(date).
                ClickOnDate(date);
        }

        private DataPicker ClickOnDate(DateTime date)
        {
            Driver.FindElement(By.XPath($"//div[@class='datepicker-component']//li[contains(text(), '{date.Day}')]"));
            return this;
        }







    }
}
