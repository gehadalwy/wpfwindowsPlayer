using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
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
using System.IO;
using Microsoft.Win32;
using System.ComponentModel;
using System.Windows.Media.Animation;
using System.Windows.Shell;
using System.Windows.Media;
using Path = System.IO.Path;

namespace WindowsMediaPlayerProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] paths, files;
//        string titlename;
        
        DispatcherTimer timer;
        
        
        
        public MainWindow()
        {
            InitializeComponent();
            


            timer = new DispatcherTimer();
             timer.Interval = TimeSpan.FromMilliseconds(500);
             timer.Tick += new EventHandler(timer_tick);
       
        }
        public void ExtensionCheck()
        {
            if (lstbx.SelectedItem.ToString().Contains("mp3"))
            {
                TaskbarItemInfo.Overlay = new BitmapImage(new Uri("I:/gehad/iti/wpf/project/WindowsMediaPlayerProject/WindowsMediaPlayerProject/mp3.jpg"));
            }
            if (lstbx.SelectedItem.ToString().Contains("avi"))
            {
                TaskbarItemInfo.Overlay = new BitmapImage(new Uri("I:/gehad/iti/wpf/project/WindowsMediaPlayerProject/WindowsMediaPlayerProject/avi.jpg"));
            }
            if (lstbx.SelectedItem.ToString().Contains("wav"))
            {
                TaskbarItemInfo.Overlay = new BitmapImage(new Uri("I:/gehad/iti/wpf/project/WindowsMediaPlayerProject/WindowsMediaPlayerProject/wav.npg"));
            }
            if (lstbx.SelectedItem.ToString().Contains("mpeg"))
            {
                TaskbarItemInfo.Overlay = new BitmapImage(new Uri("I:/gehad/iti/wpf/project/WindowsMediaPlayerProject/WindowsMediaPlayerProject/mpeg.npg"));
            }
            if (lstbx.SelectedItem.ToString().Contains("wmv"))
            {
                TaskbarItemInfo.Overlay = new BitmapImage(new Uri("I:/gehad/iti/wpf/project/WindowsMediaPlayerProject/WindowsMediaPlayerProject/wmv.jpg"));
            }

        }
        private void timer_tick(object sender, EventArgs e)
        {
            if (aMedia.Source != null && aMedia.NaturalDuration.HasTimeSpan)
            {
                PB.Minimum = 0;

                PB.Maximum = aMedia.NaturalDuration.TimeSpan.TotalSeconds;
                 PB.Value = aMedia.Position.TotalSeconds;
                lbl2.Content = PB.Maximum - PB.Value;
            }
        }

    private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            aMedia.Play();
            this.Title = lstbx.SelectedItem.ToString();
            prg.ProgressValue = 1;
            ExtensionCheck();
             }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            aMedia.Pause();
           


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            aMedia.Stop();
            prg.ProgressValue = 0;
        }

        
        

        TimeSpan _position;
        private void aMedia_MediaOpened(object sender, RoutedEventArgs e)
        {

            _position = aMedia.NaturalDuration.TimeSpan;
            PB.Minimum = 0;
            PB.Maximum = _position.TotalSeconds;
            TimeSpan ts = aMedia.NaturalDuration.TimeSpan;
          

            timer.Start();
            lbl.Content =ts.TotalMinutes;

               // ts.TotalMinutes;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            aMedia.Volume = slider_vol.Value;
        }

        private void backwardbtn_Click(object sender, RoutedEventArgs e)
        {
            aMedia.Position -= TimeSpan.FromSeconds(10);
            if (aMedia.Position >= aMedia.NaturalDuration.TimeSpan)
            {
                aMedia.Position += TimeSpan.FromMilliseconds(100);
               
            }
        }
        
        private void forwardbtn_Click(object sender, RoutedEventArgs e)
        {
            aMedia.Position += TimeSpan.FromSeconds(10);
            if (aMedia.Position >= aMedia.NaturalDuration.TimeSpan)
            {
                aMedia.Position -= TimeSpan.FromMilliseconds(100);
            }
        }

        private void PB_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
           // aMedia.Position = TimeSpan.FromSeconds(PB.Value);

        }

        private void PB_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Duration duration = new Duration(TimeSpan.FromSeconds(1));
            aMedia.Position += TimeSpan.FromSeconds(10);
            DoubleAnimation d = new DoubleAnimation(PB.Value + 10, duration);
            PB.BeginAnimation(ProgressBar.ValueProperty, d);

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Stream checkStream = null;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;

            dlg.Filter = "All Supported File Types(*.mp3,*.wav,*.mpeg,*.wmv,*.avi)|*.mp3; *.wav; *.mpeg; *.wmv; *.avi";



            // Show open file dialog box    
            if ((bool)dlg.ShowDialog())
            {

                // check if something is selected   
                if ((checkStream = dlg.OpenFile()) != null)
                {
                    files = dlg.SafeFileNames;
                    paths = dlg.FileNames;

                    for (int i = 0; i < files.Length; i++)
                    {
                        lstbx.Items.Add(files[i]);
                        
                    }
                    dlg.FileName = lstbx.SelectedValuePath;
               
                }
            }
            aMedia.LoadedBehavior = MediaState.Manual;
            aMedia.UnloadedBehavior = MediaState.Manual;
            aMedia.Volume = (double)slider_vol.Value;
          }

        private void ThumbButtonInfo_Click(object sender, EventArgs e)
        {
            aMedia.Play();
            prg.ProgressValue = 1;
            ExtensionCheck();
        }

        private void ThumbButtonInfo_Click_1(object sender, EventArgs e)
        {
            aMedia.Pause();
            prg.ProgressValue = 0;
        }

        private void ThumbButtonInfo_Click_2(object sender, EventArgs e)
        {
            aMedia.Stop();
        }

        private void lstbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            aMedia.Source = new Uri(paths[lstbx.SelectedIndex]);
        }
       
    }
   
    }
