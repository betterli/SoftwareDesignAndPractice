using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            _Model = new MyModel();
            this.DataContext = _Model;
        }
        private MyModel _Model;
        private void OnShowData_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(_Model.Data);
        }

        private void OnSubmit_Click(object sender, RoutedEventArgs e)
        {
            _Model.ClearData();
        }
        private void OnOpen_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
        private void OnOpenImage_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != true) return;
            String FileName2 = dialog.FileName;
            //    = new BitmapImage(new Uri(FileName2));
        }

    public class DelegateCommand
    {
        private Action p;

        public DelegateCommand(Action p)
        {
            this.p = p;
        }
    }
}