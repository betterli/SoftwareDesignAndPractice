using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;

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
           
        }
    }
}