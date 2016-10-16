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

using Windows.Media.Capture;
using Windows.Storage;
using Windows.UI.Xaml.Media.Imaging;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CameraSample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            CameraCaptureUI captureManager = new CameraCaptureUI();
            captureManager.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Png;
            var photo = await captureManager.CaptureFileAsync(CameraCaptureUIMode.Photo);
            if (photo != null)
            {
                var fileStream = await photo.OpenReadAsync();
                var bitmap = new BitmapImage();
                bitmap.SetSource(fileStream);
                cameraCapture.Source = bitmap;
                fileStream.Dispose();
            }
        }
    }
}
