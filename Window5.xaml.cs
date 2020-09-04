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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        int counter = 0;




        [DllImport("User32.dll")]  //importing user32 class for cursor functions
        private static extern bool SetCursorPos(int X, int Y);




        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy,
                      int dwData, int dwExtraInfo);
        [Flags]
        public enum MouseEventFlags
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }




        public Window5()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void HomeButt_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
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

        







     

        



        

       




        private void AddressButt_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PaymentButt_Click(object sender, RoutedEventArgs e)
        {
            Window4 walashickhramawalamakhtama = new Window4();
            walashickhramawalamakhtama.Show();
            this.Hide();
        }

        private void TrackButt_Click(object sender, RoutedEventArgs e)
        {
            Window3 stopwhining = new Window3();
            stopwhining.Show();
            this.Hide();
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

        private void TrackButt_Click(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
