using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoadMoreBug
{
    public partial class App : Application
    {
        public App()
        {
            // 18.3
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzQ1OTU0QDMxMzgyZTMzMmUzMGxTbjViOERhdFRldU4rMkVYT1RxOE5KV3BQLzFNSW5iWkt2OVQ4Yko5VWM9");

            // 18.2
            //Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzE4NTkxQDMxMzgyZTMyMmUzMGYwSUF4UVorUENpOHcyUEQyUTZnK3g2Q0MwMHFZM3A2WFFvRm1jRmljTFE9");


            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
