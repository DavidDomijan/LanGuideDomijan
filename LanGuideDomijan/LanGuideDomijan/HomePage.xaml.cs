using LanGuideDomijan.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LanGuideDomijan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void usersButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new UsersPage();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void resultsButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new ResultsPage();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void languagesButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new Languages();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void signoutButton_Clicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}