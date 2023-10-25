﻿using AndresTutorial.Pages;

namespace AndresTutorial;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new Login();
		//MainPage = new NavigationPage(new MainPage());
        Current.UserAppTheme = AppTheme.Light;

    }	
}
