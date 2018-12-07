using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using NAudio;
using Avalon.Windows.Dialogs;
using System.Windows.Controls.Primitives;

namespace FRP_audioplayer
{
	/// <summary>
	/// Logika interakcji dla klasy MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		AudioPlay playBackground, playEnvironment;
		LoadFiles files = new LoadFiles();

		//FolderBrowserDialog dialog;
		//dialog = new FolderBrowserDialog();
		//dialog.RootType = RootType.Path;
		//dialog.RootPath = System.IO.Directory.GetCurrentDirectory();

		//dialog.ShowDialog();
		Image image = new Image();


		public MainWindow()
		{
			InitializeComponent();
			files.loadBackground();
			files.loadEnvironment();
			Play1.IsEnabled = false;
			Play2.IsEnabled = false;



			for (int i = 0; i < files.background.Count; i++)
				BackgroundList.Items.Add(files.background[i].fileName);

			for (int i = 0; i < files.environment.Count; i++)
				EnvironmentList.Items.Add(files.environment[i].fileName);

			playBackground = new AudioPlay();
			playEnvironment = new AudioPlay();

            //this.Background_Volume.Value = playBackground.getVolume();
            //this.Environment_Volume.Value = playEnvironment.getVolume();
            


		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}

		private void BackgroundList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			playBackground.setAudioData(files.background[BackgroundList.SelectedIndex].filePath);
			playBackground.Play();

			if (Play1.IsEnabled == false)
			{
				Play1.IsEnabled = true;
				Play1.Content = "Stop";
			}
           
		}

		private void EnvironmentList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			playEnvironment.setAudioData(files.environment[EnvironmentList.SelectedIndex].filePath);
			playEnvironment.Play();

            if (Play2.IsEnabled == false)
            {
                Play2.IsEnabled = true;
                Play2.Content = "Stop";
            }
        }

		private void Play1_Click(object sender, RoutedEventArgs e)
        {
			//Play2.Visibility = Visibility.Hidden;
            if (Play1.IsEnabled == true && Play1.Content.Equals("Stop"))
            {
                Play1.Content = "Play";
                playBackground.Pause();
            }
            else if(Play1.IsEnabled == true && Play1.Content.Equals("Play"))
            {
                Play1.Content = "Stop";
                playBackground.Play();
            }

        }

        private void Slider_ValueChanged_Background_Volume(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            playBackground.setVolume((int)Background_Volume.Value);
        }

        private void Slider_ValueChanged_Environment_Volume(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            playEnvironment.setVolume((int)Environment_Volume.Value);
        }

        private void Play2_Click(object sender, RoutedEventArgs e)
		{
            if (Play2.IsEnabled == true && Play2.Content.Equals("Stop"))
            {
                Play2.Content = "Play";
                playEnvironment.Pause();
            }
            else if (Play2.IsEnabled == true && Play2.Content.Equals("Play"))
            {
                Play2.Content = "Stop";
                playEnvironment.Play();
            }
        }

	}
}
