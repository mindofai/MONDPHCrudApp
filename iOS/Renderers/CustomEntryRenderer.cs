using System;
using System.ComponentModel;
using MONDPHCrudApp;
using MONDPHCrudApp.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace MONDPHCrudApp.iOS.Renderers
{


    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer()
        {
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            Control.Layer.BorderColor = UIColor.Blue.CGColor;
            Control.Layer.BorderWidth = 1;
        }
    }
}
