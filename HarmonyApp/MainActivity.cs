﻿using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Graphics;
using Android.Content;
using Android.Util;

namespace HarmonyApp
{
    [Activity(Label = "Harmony App", MainLauncher = true,Theme = "@style/Theme.Custom")]
    public class MainActivity : Activity
    {
        private Button btnLaunchResonate;
        public Typeface ParagraphFont;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Log.Info("HarmonyApp", "Loading Main View");
            SetContentView(Resource.Layout.Main);
            Log.Info("HarmonyApp", "Initializing controls");
            InitializeControls();
        }

        private void InitializeControls()
        {
            
            btnLaunchResonate = FindViewById<Button>(Resource.Id.buttonLaunchResonate);
            btnLaunchResonate.Click += BtnLaunchResonate_Click;
            //ParagraphFont = Typeface.CreateFromAsset(Assets, "fonts/paragraph.ttf");//missing the file currently
        }

        private void BtnLaunchResonate_Click(object sender, EventArgs e)
        {
            StartResonate();
        }

        public void StartResonate()
        {
            Intent startResonate = new Intent(this, typeof(ResonateActivity));
            StartActivity(startResonate);
            Log.Info("HarmonyApp", "Beginning Resonate Activity");
            //potentially launch Resonate service here
        }
    }
}

