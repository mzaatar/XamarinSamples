﻿using System.Reflection;
using Xamarin.Forms;

namespace Greetings
{
    public class App : Application
    {
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
            MainPage = new EmpiricalFontSizePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
