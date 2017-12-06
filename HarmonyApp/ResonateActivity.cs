using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Graphics;
using Android.Content;
using Android.Util;

namespace HarmonyApp
{
    [Activity(Label ="Resonate")]
    public class ResonateActivity : Activity
    {


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Resonate);
        }
    }
}