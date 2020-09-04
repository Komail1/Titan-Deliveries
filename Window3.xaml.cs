using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.IO;
using System.Collections;
using System.Runtime.InteropServices;

namespace Titan_Deliveries
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {


        int counter = 0;
        int delay = 2;



        [DllImport("User32.dll")]  //importing user32 class for cursor functions
        private static extern bool SetCursorPos(int X, int Y);




        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy,
                      int dwData, int dwExtraInfo);
        [Flags]
        public enum MouseEventFlags
        {//srzh
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }





        public Window3()
        {
            InitializeComponent();
        }

        

        private void fbbutt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Our actual projects and startups include:\n\nTITAN SOLUTIONS: Featuring all kinds of electronics repairs, software/hardware development, literary services and much more! Contact us at raza28feb@gmail.com or call anytime +92 0335 0378468.\n\nTITAN ARTWORKS: Dealing in largescale multilayer stencil-based artworks on magnitudes never seen before. Check us out at https://www.facebook.com/TitanStencilArts and https://www.instagram.com/titanartworks/ \n\nTITAN BALLISTICS: We make things the blow up on impact! Dealing in advanced spud cannon designs for that unique hobbyist, check us out at https://www.instagram.com/titanballisticsworks/ \n\nKeep hustling and don't stop. Ever. Be a Titan <3");

        }

        private void insta_Butt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Our actual projects and startups include:\n\nTITAN SOLUTIONS: Featuring all kinds of electronics repairs, software/hardware development, literary services and much more! Contact us at raza28feb@gmail.com or call anytime +92 0335 0378468.\n\nTITAN ARTWORKS: Dealing in largescale multilayer stencil-based artworks on magnitudes never seen before. Check us out at https://www.facebook.com/TitanStencilArts and https://www.instagram.com/titanartworks/ \n\nTITAN BALLISTICS: We make things the blow up on impact! Dealing in advanced spud cannon designs for that unique hobbyist, check us out at https://www.instagram.com/titanballisticsworks/ \n\nKeep hustling and don't stop. Ever. Be a Titan <3");

        }

        private void Gmail_Butt_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Our actual projects and startups include:\n\nTITAN SOLUTIONS: Featuring all kinds of electronics repairs, software/hardware development, literary services and much more! Contact us at raza28feb@gmail.com or call anytime +92 0335 0378468.\n\nTITAN ARTWORKS: Dealing in largescale multilayer stencil-based artworks on magnitudes never seen before. Check us out at https://www.facebook.com/TitanStencilArts and https://www.instagram.com/titanartworks/ \n\nTITAN BALLISTICS: We make things the blow up on impact! Dealing in advanced spud cannon designs for that unique hobbyist, check us out at https://www.instagram.com/titanballisticsworks/ \n\nKeep hustling and don't stop. Ever. Be a Titan <3");

        }

       






       








     

        public async Task TestCorrect1()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {//srhz

                await Task.Delay(500);




                SetCursorPos(882, 713); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);






            });

        }

      

      


        private void animbuddy_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (counter == 0) 
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L2.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 1)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;
                //srhz
                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L3.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 2)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L4.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 3)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L5.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();//srhz
            }

            else if (counter == 4)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L6.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 5)
            {//srhz
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L7.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 6)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;
                //srhz
                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L8.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 7)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L9.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 8)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L10.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();
                //sr
                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 9)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L11.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 10)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L12.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();//hz

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 11)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L13.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 12)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L14.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 12)
            {//shzr
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L14.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 13)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L15.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 14)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L16.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 15)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;
                //zrhs
                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L17.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 16)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L18.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 16)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L18.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 17)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L19.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 18)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L20.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();//rhzs

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 19)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L21.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 20)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L22.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();//hsrz

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 21)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L23.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = counter + 1;
                TestCorrect1();
            }

            else if (counter == 22)
            {
                string a = System.IO.Directory.GetCurrentDirectory();
                string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L24.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();

                counter = 0;

            }


        }




        private void AddressButt_Copy_Click(object sender, RoutedEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();//srhz
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

                ImageBrush myBrush = new ImageBrush();


                myBrush.ImageSource =
                   new BitmapImage(new Uri(projectDirectory + "/iconies/L1.png", UriKind.Relative));

                mappy.Background = myBrush;
                this.Show();
            
            TestCorrect1();
        }





        private void PaymentButt_Click(object sender, RoutedEventArgs e)
        {
            Window4 walashickhramawalamakhtama = new Window4();
            walashickhramawalamakhtama.Show();
            this.Hide();
        }

        private void TrackButt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuButt_Click(object sender, RoutedEventArgs e)
        {
            Window2 winnythepooh = new Window2();
            winnythepooh.Show();
            this.Hide();
        }

        private void HomeButt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();

            App.Current.MainWindow.Visibility = Visibility.Visible;
        }



        private void d1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Deal has been confirmed and will arrive to you by our delivery rider soon! Enjoy! :)");
        }

        private void AddressButt_Click(object sender, RoutedEventArgs e)
        {
            Window5 WindowToMySoul = new Window5();
            WindowToMySoul.Show();
            this.Hide();
        }
    }
}
