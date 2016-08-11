using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DeakinInformation
{
    [Activity(Label = "Information", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Button button_deakin_buildings = FindViewById<Button>(Resource.Id.DeakinBuildingsButton);
            Button button_deakin_security = FindViewById<Button>(Resource.Id.DeakinSecurityButton);
            Button button_phone_numbers = FindViewById<Button>(Resource.Id.PhoneNumbersButton);

            button_deakin_security.Click += delegate { StartActivity(typeof(DeakinBuildings)); };
            button_deakin_buildings.Click += delegate { StartActivity(typeof(DeakinSecurity)); };
            button_phone_numbers.Click += delegate { StartActivity(typeof(PhoneNumbers)); };
            
        }
    }
}

