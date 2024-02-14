using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginScreenAss
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_Clicked(object sender, EventArgs e)
		{
			string un = username.Text;
			string pw = password.Text;

			if (un == "admin" && pw == "admin")
			{
				DisplayAlert("Login Success", "You have successfully logged in.", "OK");
			}
			else
			{
				DisplayAlert("Login Failed", "Invalid username or password. Please try again.", "OK");
			}

		}
    }
}
