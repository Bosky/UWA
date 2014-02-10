using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace UWA.AndroidClient
{
    [Activity(Label = "Maps")]
    public class MapsActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            Log.Info("MAPS", "Start OnCreate");
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Maps);
            // Create your application here
            Log.Info("MAPS", "End OnCreate");
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.MapsMenu, menu);
            return true;
        }
    }
}