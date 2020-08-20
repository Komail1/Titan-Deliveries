using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Titan_Deliveries
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void SplashScreen_Initialized(object sender, EventArgs e)
        {
            int delay = 2000;

            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            string[] AnimeDirectories = new string[16] { " ", "/iconies/Splashload3.png", "/iconies/Splashload4.png", "/iconies/Splashload5.png", "/iconies/6plashload2.png", "/iconies/Splashload7.png", "/iconies/Splashload8.png", "/iconies/Splashload9.png", "/iconies/Splashload10.png", "/iconies/Splashload11.png", "/iconies/Splashload12.png", "/iconies/Splashload13.png", "/iconies/Splashload14.png", "/iconies/Splashload15.png", "/iconies/Splashload16.png", "/iconies/SplashloadStart.png" };


            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload2.png", UriKind.Relative));
            delee(myBrush);


            myBrush.ImageSource =
                       new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload3.png", UriKind.Relative));
            delee2(myBrush);


           // myBrush.ImageSource =
                       new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload4.png", UriKind.Relative));
            //delee(myBrush);


           // myBrush.ImageSource =
                        new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload5.png", UriKind.Relative));
            //delee(myBrush);


           // myBrush.ImageSource =
                    new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload6.png", UriKind.Relative));
            //delee(myBrush);








            async void delee(ImageBrush myBrush)
            {
                await Task.Delay(delay);
                Loading.Fill = myBrush;
                this.Show();
            }

            async void delee2(ImageBrush myBrush)
            {
                await Task.Delay(delay);
                Loading.Fill = myBrush;
                this.Show();
            }



        }
    }
}
