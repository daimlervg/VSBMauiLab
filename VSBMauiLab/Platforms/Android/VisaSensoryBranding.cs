using Android.Content;
using Application = Android.App.Application;

namespace VSBMauiLab.Platforms.Android
{
	public class VisaSensoryBranding : IVisaSensoryBranding
	{
		public async Task Animate()
		{
			var intent = new Intent(Application.Context, typeof(VisaSensoryBrandingActivity));
			intent.SetFlags(ActivityFlags.NewTask);
			Application.Context.StartActivity(intent);
			await Task.CompletedTask;
		}
	}
}

