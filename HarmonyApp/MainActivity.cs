using Android.App;
using Android.Widget;
using Android.OS;

namespace HarmonyApp
{
    [Activity(Label = "Harmony App", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            
            SetContentView(Resource.Layout.Main);
        }
    }
}

