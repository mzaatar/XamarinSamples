using Xamarin.Forms;

namespace Greetings
{
    public class App : Application
    {
        //public string DisplayLabelText { set; get; }
        //const string displayLabelText = "displayLabelText";
        public App()
        {
            //MainPage = new GreetingsPage();
            //MainPage = new ReflectedColorsPage();
            //MainPage = new FramedTextPage();
            //MainPage = new SizedBoxViewPage();
            // MainPage = new ColorBlocksPage();

            //MainPage = new BlackCatPage();
            //MainPage = new WhatSizePage();
            //MainPage = new MetricalBoxViewPage();
            //MainPage = new FontSizesPage();
            //MainPage = new FitToSizeClockPage();
            //MainPage = new EmpiricalFontSizePage();

            //MainPage = new Chapter6.ButtonLoggerPage();
            //MainPage = new Chapter6.TwoButtonsPage();
            //MainPage = new Chapter6.ButtonLambdasPage();


            //if (Properties.ContainsKey(displayLabelText))
            //{
            //    DisplayLabelText = (string)Properties[displayLabelText];
            //}
            //MainPage = new Chapter6.SimplestKeypadPage();

            MainPage = new Chapter8.MonkeyTapPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            //Properties[displayLabelText] = DisplayLabelText;
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
