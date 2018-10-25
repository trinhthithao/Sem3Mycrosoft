using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WeatherAppDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            collection = new ObservableCollection<List>();
            this.DataContext = this;
        }

        public ObservableCollection<List> collection { get; set; }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
           
               //string icon = string.Format("ms-appx://Assets/Weather/{0}.png", forcast.weather[0].icon);

                //ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
                //TempTextBlock.Text = ((double)myWeather.main.temp).ToString();
                //DescriptionTextBlock.Text = myWeather.weather[0].description;
                //LocationTextBlock.Text = myWeather.name;
            
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                var position = await locationData.getPosition();
                var lat = position.Coordinate.Latitude;
                var lon = position.Coordinate.Longitude;

                RootObject forcast = await API.GetWeather(lat, lon);
                for (int i = 0; i < 5; i++)
                {
                    collection.Add(forcast.list[i]);
                }
                foreCastGridView.ItemsSource = collection;
            }
            catch(Exception ex)
            {
                ex.GetHashCode();
            }


        }
    }
}
