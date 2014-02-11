using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using UWA.AndroidClient.Adapters;
using UWA.Core.BL.Interfaces;
using UWA.Core.BL;
using Android.App;

namespace UWA.AndroidClient
{
    [Activity(Label = "Maps")]
    public class PlaceCategoriesActivity : ListActivity
    {      
        private ListView _categoryList = null;
        private CategoryListAdapter _categoryListAdapter;
        private IList<IPlaceCategory> _categories;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //SetContentView(Resource.Layout.PlaceCategories);

            //_categoryList = FindViewById<ListView>(Resource.Id.CategoryList);

            _categories = new List<IPlaceCategory> {new PlaceCategory {Id = 1, Name = "Classrooms"}};
            PopulateCategories();

        }

        void PopulateCategories()
        {
            _categoryListAdapter = new CategoryListAdapter(this, _categories);
            //_categoryList.Adapter = _categoryListAdapter;
            ListAdapter = _categoryListAdapter;
        }
    }
}