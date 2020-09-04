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
using System.Collections;
using System.Runtime.InteropServices; // NEED THESE SERVICES FOR USING DLLIMPORT

namespace Titan_Deliveries
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        int counter = 0;
        bool runonce = true;
        bool closer = false;

        [DllImport("User32.dll")]  //importing user32 class for cursor functions
        private static extern bool SetCursorPos(int X, int Y);
        
        
        
        
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy,
                      int dwData, int dwExtraInfo);//srhz
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





        public Window1()
        {
            InitializeComponent();

           
        }



        






        public async Task TestCorrect1()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {//srhz

                await Task.Delay(100);

                
                
                SetCursorPos(591,236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect2();
            });
            
        }

        public async Task TestCorrect2()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {
                
                await Task.Delay(100);



                SetCursorPos(606, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
                //srhz

                TestCorrect3();
            });

        }

        public async Task TestCorrect3()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(612, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
                //srhz

                TestCorrect4();
            });

        }

        public async Task TestCorrect4()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(622, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);
                //srhz

                TestCorrect5();
            });

        }

        public async Task TestCorrect5()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(635, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect6();
            });

        }

        public async Task TestCorrect6()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(648, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect7();
            });

        }

        public async Task TestCorrect7()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(660, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect8();
            });

        }

        public async Task TestCorrect8()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(670, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect9();
            });

        }

        public async Task TestCorrect9()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(690, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect10();
            });

        }

        public async Task TestCorrect10()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(700, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect11();
            });

        }

        public async Task TestCorrect11()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(720, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect12();
            });

        }

        public async Task TestCorrect12()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(735, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect13();
            });

        }

        public async Task TestCorrect13()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(750, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect14();
            });

        }

        public async Task TestCorrect14()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);



                SetCursorPos(760, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect15();
            });

        }

        public async Task TestCorrect15()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {

                await Task.Delay(100);

                
                

                SetCursorPos(775, 236); //THATS IT. THAT MOVES THE Cursor
                mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                TestCorrect16();
            });

        }

        public async Task TestCorrect16()
        {
            await Task.Run(async () => //Task.Run automatically unwraps nested Task types!
            {//srhz

                await Task.Delay(100);

                

                if (counter >= 2)
                {
                    closer = true;
                    SetCursorPos(785, 236); //THATS IT. THAT MOVES THE Cursor
                    mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                    mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);

                }
                else 
                {
                    counter = counter + 1;

                    SetCursorPos(785, 236); //THATS IT. THAT MOVES THE Cursor
                    mouse_event((int)(MouseEventFlags.LEFTDOWN), 0, 0, 0, 0);
                    mouse_event((int)(MouseEventFlags.LEFTUP), 0, 0, 0, 0);


                    TestCorrect1();

                }

            });

        }





        private void Loading_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (runonce == true)
            {
                runonce = false;
                TestCorrect1();
            }
        }



        private void shift1_MouseDown_1(object sender, MouseButtonEventArgs e)
        {//sr       //hz
            //MessageBox.Show("TMKC");

            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload2.png", UriKind.Relative));

            

            ImageBrush myBrush2 = new ImageBrush();
            myBrush2.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/mascot1.png", UriKind.Relative));

            MascotAnim.Fill = myBrush2;
            Loading.Fill = myBrush;



            this.Show();
        }




        private void shift2_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload3.png", UriKind.Relative));

            Loading.Fill = myBrush;
            this.Show();
        }//hz
        //sr
        private void shift3_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =//srhz
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload4.png", UriKind.Relative));

            Loading.Fill = myBrush;

            ImageBrush myBrush2 = new ImageBrush();
            myBrush2.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/mascot2.png", UriKind.Relative));

            MascotAnim.Fill = myBrush2;
            Loading.Fill = myBrush;




            this.Show();
        }

        private void shift4_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload5.png", UriKind.Relative));

            Loading.Fill = myBrush;
            this.Show();
        }

        private void shift5_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload6.png", UriKind.Relative));

            Loading.Fill = myBrush;

            ImageBrush myBrush2 = new ImageBrush();
            myBrush2.ImageSource =//srhz
                      new BitmapImage(new Uri(projectDirectory + "/iconies/mascot1.png", UriKind.Relative));

            MascotAnim.Fill = myBrush2;
            Loading.Fill = myBrush;



            this.Show();
        }

        private void shift6_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload7.png", UriKind.Relative));

            Loading.Fill = myBrush;
            this.Show();
        }

        private void shift7_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload8.png", UriKind.Relative));

            Loading.Fill = myBrush;

            ImageBrush myBrush2 = new ImageBrush();
            myBrush2.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/mascot2.png", UriKind.Relative));

            MascotAnim.Fill = myBrush2;
            Loading.Fill = myBrush;



            this.Show();
        }

        private void shift8_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =//shzr
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload9.png", UriKind.Relative));

            Loading.Fill = myBrush;
            this.Show();
        }

        private void shift9_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload10.png", UriKind.Relative));

            Loading.Fill = myBrush;

            ImageBrush myBrush2 = new ImageBrush();
            myBrush2.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/mascot1.png", UriKind.Relative));

            MascotAnim.Fill = myBrush2;
            Loading.Fill = myBrush;



            this.Show();
        }

        private void shift10_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =//zrhs
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload11.png", UriKind.Relative));

            Loading.Fill = myBrush;
            this.Show();
        }

        private void shift11_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload12.png", UriKind.Relative));

            Loading.Fill = myBrush;

            ImageBrush myBrush2 = new ImageBrush();
            myBrush2.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/mascot2.png", UriKind.Relative));

            MascotAnim.Fill = myBrush2;
            Loading.Fill = myBrush;



            this.Show();
        }

        private void shift12_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload13.png", UriKind.Relative));

            Loading.Fill = myBrush;
            this.Show();
        }

        private void shift13_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =//srhz
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload14.png", UriKind.Relative));

            Loading.Fill = myBrush;

            ImageBrush myBrush2 = new ImageBrush();
            myBrush2.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/mascot1.png", UriKind.Relative));

            MascotAnim.Fill = myBrush2;
            Loading.Fill = myBrush;



            this.Show();
        }

        private void shift14_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload15.png", UriKind.Relative));

            Loading.Fill = myBrush;
            this.Show();
        }

        private void shift15_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/Splashload16.png", UriKind.Relative));

            Loading.Fill = myBrush;

            ImageBrush myBrush2 = new ImageBrush();
            myBrush2.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/mascot2.png", UriKind.Relative));

            MascotAnim.Fill = myBrush2;
            Loading.Fill = myBrush;



            this.Show();



        }

        private void shift16_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            string a = System.IO.Directory.GetCurrentDirectory();
            string projectDirectory = Directory.GetParent(a).Parent.FullName;

            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource =
                      new BitmapImage(new Uri(projectDirectory + "/iconies/SplashloadStart.png", UriKind.Relative));

            Loading.Fill = myBrush;
            this.Show();

            if(closer == true) 
            {


                this.Hide();

                App.Current.MainWindow.Visibility = Visibility.Visible;


            }
            
                        
        }
    
        
    
    }
}
