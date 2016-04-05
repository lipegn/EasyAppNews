using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections;

namespace AndroidAppNews
{
    [Activity(Label = "AndroidAppNews", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);


            TableRow lst = FindViewById<TableRow>(Resource.Id.tableRow1);
            TableRow.LayoutParams layoutParams = new TableRow.LayoutParams(TableRow.LayoutParams.WrapContent, TableRow.LayoutParams.WrapContent);
            lst.LayoutParameters = layoutParams;
            
            //ImageView view = FindViewById<ImageView>(Resource.Id.imageView1);
            var lista = Exec.GetBlocos();

            //view.SetImageBitmap(Exec.GetImageBitmapFromUrl("http://s2.glbimg.com/cU0RjFCFZgZkALNL-50TmFDF2EU=/360x171/top/http://s2.glbimg.com/Mb9v4NUokoAgBWZ7OMyhs3BocAc=/26x85:570x343/544x258/s.glbimg.com/jo/g1/f/original/2015/08/24/cadu_1.jpg"));

            foreach (var item in lista)
            {
                ImageView img = new ImageView(this);
                img.SetImageBitmap(Exec.GetImageBitmapFromUrl("http://s2.glbimg.com/cU0RjFCFZgZkALNL-50TmFDF2EU=/360x171/top/http://s2.glbimg.com/Mb9v4NUokoAgBWZ7OMyhs3BocAc=/26x85:570x343/544x258/s.glbimg.com/jo/g1/f/original/2015/08/24/cadu_1.jpg"));
                //img.set
                //img.Height = 90;
                img.SetScaleType(Android.Widget.ImageView.ScaleType.FitCenter);
                img.ScrollTo(0, 0);
                lst.AddView(img);                
            }
        }
    }
}

