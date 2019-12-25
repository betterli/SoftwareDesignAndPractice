using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
	/// <summary>
	/// Window1.xaml 的交互逻辑
	/// </summary>
	public partial class Window1 : Window
	{
		public Window1()
		{
			InitializeComponent();

		}

		public object Util { get; private set; }

		private void OnOpen_Click(object sender, RoutedEventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.ShowDialog();
			string path = openFileDialog.FileName;
			file_name.Text = path;
			if(encodingBox.SelectedItem == utf8)
				email.Text = File.ReadAllText(path, Encoding.UTF8);
			else if (encodingBox.SelectedItem == ascii)
				email.Text = File.ReadAllText(path, Encoding.ASCII);
		}
		private void OnSubmit_Click(object sender, RoutedEventArgs e)
		{
			
		}
		private void CheckEmail()
		{
			string reg = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";
			Regex r = new Regex(reg);
			
		}


	}
}
