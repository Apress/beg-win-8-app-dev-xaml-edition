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
using Windows.UI.Core;
using Windows.Devices.Sensors;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AccelerometerSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Accelerometer _accelerometer;

        public MainPage()
        {
            this.InitializeComponent();
            _accelerometer = Accelerometer.GetDefault();
            _accelerometer.ReadingChanged += OnAccelerometerReadingChanged;
        }

        private void OnAccelerometerReadingChanged(Accelerometer sender, AccelerometerReadingChangedEventArgs args)
        {
            Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    accelerometerHistory.Items.Add(
                        string.Format("X:{0}, Y: {1}, Z:{2}"
                        , args.Reading.AccelerationX
                        , args.Reading.AccelerationY
                        , args.Reading.AccelerationZ)
                        );
                });
        }
    }
}
