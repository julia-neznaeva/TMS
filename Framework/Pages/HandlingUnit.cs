using AutotestApp.Common;
using AutotestsApp.Gui.Elements;
using AutotetsApp.Gui.Framework.Elements;
using OpenQA.Selenium;
using System;

namespace AutotetsApp.Gui.Framework.Pages
{
    public class HandlingUnit: BaseElement
    {
        private Dropdown _type => new Dropdown(By.XPath("//handling-unit//p-dropdown"), "Type", Driver);
        private NumericStepper _count => new NumericStepper(By.XPath("//handling-unit//div[contains(@class, 'count-item')]"), "Count", Driver);
        private TextBox _dimensionsL => new TextBox(By.XPath("//handling-unit//input[@placeholder= 'L']"), "L", Driver);
        private Span _dimensionsLValidator => new Span(By.XPath("//hand//handling-unit//input[@placeholder= 'L']/following-sibling::span[@class = 'error long']"), "L", Driver);
        private TextBox _dimensionsW => new TextBox(By.XPath("//handling-unit//input[@placeholder= 'W']"), "W", Driver);

        private TextBox _dimensionsH=> new TextBox(By.XPath("//handling-unit//input[@placeholder= 'H']"), "H", Driver);


     












































-/