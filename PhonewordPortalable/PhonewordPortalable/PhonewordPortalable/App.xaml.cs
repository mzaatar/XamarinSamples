﻿using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PhonewordPortalable
{
    public partial class App : Application
    {
        public static Dictionary<string,string> PhoneNumbers { get; set; }

        public App()
        {
            InitializeComponent();
            
            PhoneNumbers = new Dictionary<string, string>();
            MainPage = new NavigationPage(new MainPage());
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