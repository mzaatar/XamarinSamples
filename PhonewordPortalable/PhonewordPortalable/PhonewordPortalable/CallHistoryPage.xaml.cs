using System;
using Xamarin.Forms;

namespace PhonewordPortalable
{
    public partial class CallHistoryPage : ContentPage
    {
        public CallHistoryPage()
        {
            InitializeComponent();
        }

        async void OnClear(object sender, EventArgs e)
        {
            if (App.PhoneNumbersModel.Count > 0)
            {
                if (await DisplayAlert(
                         "Clear history",
                         "Delete all call history?",
                         "Yes",
                         "No"))
                {
                    App.PhoneNumbersModel.Clear();
                    //await Navigation.PopAsync();
                }
            }
            else
                await DisplayAlert("Empty list", "There is nothing to delete", "Ok");
        }
    }
}
