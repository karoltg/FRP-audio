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

namespace FRP_audioplayer
{
	/// <summary>
	/// Logika interakcji dla klasy MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		AudioPlay first, second;
		LoadFiles files = new LoadFiles();
		

		public MainWindow()
		{
			InitializeComponent();
			files.loadBackground();
		}

		

		private void Play2(object sender, RoutedEventArgs e)
		{
			second = new AudioPlay("Red Hot Chili Peppers - Californication.mp3");
			second.Play();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Play1(object sender, RoutedEventArgs e)
		{
			first = new AudioPlay("lekcja 01.mp3");
			first.Play();
		}
	}
}
