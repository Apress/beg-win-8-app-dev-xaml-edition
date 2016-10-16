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

namespace InclinometerSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Inclinometer _inclinometer;

        public MainPage()
        {
            this.InitializeComponent();
            _inclinometer = Inclinometer.GetDefault();
            _inclinometer.ReadingChanged += OnInclinometerReadingChanged;
        }

        private void OnInclinometerReadingChanged(Inclinometer sender, InclinometerReadingChangedEventArgs args)
        {
            Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    txtPitch.Text = args.Reading.PitchDegrees.ToString();
                    txtRoll.Text = args.Reading.RollDegrees.ToString();
                    txtYaw.Text = args.Reading.YawDegrees.ToString();
                });
        }
    }
}
