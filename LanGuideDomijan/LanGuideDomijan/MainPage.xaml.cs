using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LanGuideDomijan.Helpers;
using LanGuideDomijan;

namespace LanGuideDomijan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void loginButton_Clicked(object sender, EventArgs e)
        {
            bool isEmailEmpty = string.IsNullOrEmpty(emailE.Text);
            bool isPasswordEmpty = string.IsNullOrEmpty(passwordE.Text);

            if (!isEmailEmpty && !isPasswordEmpty)
            {
                bool result = await Auth.LoginUser(emailE.Text, passwordE.Text);
                if (result)
                    App.Current.MainPage = new HomePage();
            }
        }
    }
}
