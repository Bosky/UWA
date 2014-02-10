using System;
using System.Net.Mime;
using UWA.Core;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace UWA.AndroidClient
{
    [Activity(Label = "UWA.AndroidClient", MainLauncher = true, Icon = "@drawable/icon")]
    public class HomeActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            Class1 textService = new Class1();

            var textView = FindViewById<TextView>(Resource.Id.HelloText);
            textView.Text = textService.GetGreeting();

            // Get our button from the layout resource,
            // and attach an event to it
            var button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += MapsClicked;
        }

        private void MapsClicked(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(MapsActivity));
            StartActivity(intent);
        }
    }
}

