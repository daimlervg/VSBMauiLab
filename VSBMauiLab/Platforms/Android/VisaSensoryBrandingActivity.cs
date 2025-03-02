using Android.App;
using Android.Content.PM;
using Android.OS;
using Com.Visa;
using AndroidZ = Android.Graphics;


namespace VSBMauiLab.Platforms.Android
{
    [Activity(NoHistory = true, Label = "Visa")]
    public class VisaSensoryBrandingActivity : Activity
    {
        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Platform.Init(this, savedInstanceState);

            SetContentView(Resource.Layout.SensoryBrandingLayout);

            var mSensoryBrandingView = FindViewById<SensoryBrandingView>(Resource.Id.vsbView);
            mSensoryBrandingView.SoundEffectsEnabled = true;
            mSensoryBrandingView.HapticFeedbackEnabled = true;
            mSensoryBrandingView.LanguageCode = "en";
            mSensoryBrandingView.CheckmarkText = CheckmarkTextOption.Success;
            mSensoryBrandingView.BackdropColor = AndroidZ.Color.ParseColor("#FF0000");
            mSensoryBrandingView.SoundEnabled = true;
            mSensoryBrandingView.Animate();

            Task.Delay(10000).ContinueWith(t => Finish());
        }
    }
}