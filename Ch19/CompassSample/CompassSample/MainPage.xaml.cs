using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Windows.Devices.Sensors;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CompassSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Compass _compass;

        public MainPage()
        {
            this.InitializeComponent();
            _compass = Compass.GetDefault();
            _compass.ReadingChanged += OnCompassReadingChanged;
        }

        private void OnCompassReadingChanged(Compass sender, CompassReadingChangedEventArgs args)
        {
            Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    txtHeading.Text = args.Reading.HeadingMagneticNorth.ToString();
                });
        }
    }
}
