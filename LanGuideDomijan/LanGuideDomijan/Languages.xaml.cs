using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LanGuideDomijan.Model;

namespace LanGuideDomijan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Languages : ContentPage
    {
        public Languages()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var language = await Results.GetResults();
            languageListView.ItemsSource = language.GroupBy(x => x.language).Select(x => x.First());
        }

        public async void OpenHomePageButton_Clicked3(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new HomePage();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}