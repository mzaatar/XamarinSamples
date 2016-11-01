using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PhonewordPortalable
{
    public partial class App : Application
    {
        public static GeneralInfo GeneralInfo;
        public static PhoneNumbersViewModel PhoneNumbersModel;
        public static ObservableCollection<Phone> PhoneNumbers;
        public App()
        {
            InitializeComponent();

            GeneralInfo = new GeneralInfo()
            {
                Developer = "Mohamed Zaatar"
            };
            PhoneNumbersModel = new PhoneNumbersViewModel();
            PhoneNumbers = PhoneNumbersModel.PhoneNumbers;
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
