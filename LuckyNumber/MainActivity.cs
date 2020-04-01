using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace LuckyNumber
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, Icon = "@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        Button rollButton;
        TextView numberTextView;
        SeekBar rangeBar;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            SupportActionBar.Title = "My lucky number";
            rollButton = FindViewById<Button>(Resource.Id.rollButton);
            numberTextView = FindViewById<TextView>(Resource.Id.numberTextView);
            rangeBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            rollButton.Click += RollButton_Click;
            
        }

        private void RollButton_Click(object sender, System.EventArgs e)
        {
            Random random = new Random();
            int result = random.Next(rangeBar.Progress) + 1;
            numberTextView.Text = result.ToString();
        }
    }
}