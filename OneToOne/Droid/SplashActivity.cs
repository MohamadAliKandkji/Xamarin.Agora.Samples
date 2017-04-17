﻿using Android.App;
using Android.Content;
using Android.Support.V7.App;

namespace DT.Samples.Agora.OneToOne.Droid
{
	[Activity(Theme = "@style/DT.Theme.Splash", MainLauncher = true, NoHistory = true)]
	public class SplashActivity : AppCompatActivity
	{
		protected override void OnResume()
		{
			base.OnResume();
			StartActivity(new Intent(Application.Context, typeof(JoinActivity)));
		}

		public override void OnBackPressed() { }
	}
}
