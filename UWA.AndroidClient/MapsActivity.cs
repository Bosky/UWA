using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.GoogleMaps;
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
    public class MapsActivity : MapActivity
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

            Log.Info("HA", "Menu items built.");

            return base.OnCreateOptionsMenu(menu);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.action_search)
            {
                string toast = string.Format("Searching.. searching... not.");
                Toast.MakeText(this, toast, ToastLength.Long).Show();
            }

            if (item.ItemId == Resource.Id.action_places)
            {
                var intent = new Intent(this, typeof(PlaceCategoriesActivity));
                StartActivity(intent);
            }

            return base.OnOptionsItemSelected(item);
        }

        protected override bool IsRouteDisplayed
        {
            get { return false; }
        }
    }
}