﻿namespace MauiAppCalc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
            //MainPage = new MainPage();
        }
    }
}
