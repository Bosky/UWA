using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Widget;
using UWA.Core.BL.Interfaces;


namespace UWA.AndroidClient.Adapters
{
    public class CategoryListAdapter : BaseAdapter<IPlaceCategory>
    {
        private Activity _context = null;
        private IList<IPlaceCategory> _categories = new List<IPlaceCategory>();

        public CategoryListAdapter(Activity context, IList<IPlaceCategory> categories)
            : base()
        {
            this._context = context;
            this._categories = categories;
        }

        public override IPlaceCategory this[int position]
        {
            get { return _categories[position];  }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count
        {
            get { return _categories.Count(); }
        }

        public override Android.Views.View GetView(int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
        {
            var view = convertView
                                    ?? _context.LayoutInflater.Inflate(Resource.Layout.Category, null);
            var category = _categories[position];

            view.FindViewById<TextView>(Resource.Id.CategoryLabel).Text = category.Name ;
            return view;
        }
    }
}
