﻿namespace TabbedPageTestApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new MyTabbedPage();
    }
}
