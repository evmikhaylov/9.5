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

namespace _9._5
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}


		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string SplitTxt = SplitTxtBox.Text;

			string[] words = SplitTxt.Split(' ');

			SplitList.Items.Clear();

			foreach (string word in words)
			{
				SplitList.Items.Add(word);
			}
		}

		private void ReshuffleBtn_Click(object sender, RoutedEventArgs e)
		{
			
			string ReshuffleTxt = ReshuffleTxtBox.Text;

			string[] words = ReshuffleTxt.Split(' ');

			Array.Reverse(words);

			string ResultReshuffle = string.Join(" ", words);

			ReshuffleLabel.Content = ResultReshuffle;
		}
	}
}
