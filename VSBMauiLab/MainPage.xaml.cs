namespace VSBMauiLab;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        // count++;

        // if (count == 1)
        // 	CounterBtn.Text = $"Clicked {count} time";
        // else
        // 	CounterBtn.Text = $"Clicked {count} times";

        // SemanticScreenReader.Announce(CounterBtn.Text);

        StartSensoryBrandingAnimation();

    }

    private static void StartSensoryBrandingAnimation()
    {
#if ANDROID
        var visaSensoryBranding = new Platforms.Android.VisaSensoryBranding();
        Task.Delay(100).ContinueWith(t => visaSensoryBranding.Animate());
#endif
    }

    //private static void StartSensoryBrandingAnimation()
    //{
    //	var visaSensoryBranding = DependencyService.Get<IVisaSensoryBranding>();
    //	Task.Delay(200).ContinueWith(t => visaSensoryBranding.Animate());
    //}
}


