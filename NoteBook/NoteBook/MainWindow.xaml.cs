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

namespace NoteBook
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.IO.File.WriteAllText(@"C:\git\NoteBook\Save1.txt", Textarea.Text);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.IO.File.ReadAllText(@"C:\git\NoteBook\Save1.txt");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            //显示视窗
            Nullable<bool> result = dig.ShowDialog();
            if(result ==true)
            {
                //写入文本中
                System.IO.File.WriteAllText(dig.FileName, Textarea.Text);
            }
        }

        private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        //停用關閉按鈕
        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }


    }
}
