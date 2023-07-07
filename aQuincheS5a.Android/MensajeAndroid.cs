﻿using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using aQuincheS5a.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(MensajeAndroid))]
namespace aQuincheS5a.Droid
{
    public class MensajeAndroid: Mensaje
    {
        public void longAlert(string mensaje)
        {

        Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();
        }

        public void shorAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();
        }

       
    }
}