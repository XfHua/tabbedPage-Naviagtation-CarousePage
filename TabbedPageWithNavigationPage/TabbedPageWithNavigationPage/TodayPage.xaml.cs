﻿using Xamarin.Forms;

namespace TabbedPageWithNavigationPage
{
	public partial class TodayPage : ContentPage
    {
		public TodayPage ()
		{
			InitializeComponent ();

        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }


    }
}

