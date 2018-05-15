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
        
        string fileName = "";
        string newFileName = "";

        string saveText="";
        string thisText = "";

        

        public MainWindow()
        {
            InitializeComponent();
        }

        // 打開原有文檔
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (saveText != thisText)
                if (MessageBox.Show("Do you want to Save?", "Save or Not", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Save();
                    Open();
                }
                else
                {
                    Open();
                }
            else
            {
                Open();
            }


        }
        void Save()
        {
            Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                System.IO.File.WriteAllText(dlg.FileName, Textarea.Text);
                fileName = dlg.FileName;
                saveText = thisText; ;
                Title.Text = dlg.SafeFileName + ".txt";
            }
        }


        void Open()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                Textarea.Text = System.IO.File.ReadAllText(dlg.FileName);
                fileName = dlg.FileName;
                saveText = Textarea.Text;
                Title.Text = dlg.SafeFileName + ".txt";
            }
        }

        // 儲存文件
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (fileName == newFileName)
            {
                Save();
            }
            else
            {
                System.IO.File.WriteAllText(fileName, Textarea.Text);
                saveText = thisText;
            }
        }

        // 另存新檔
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dig = new Microsoft.Win32.SaveFileDialog();

            // 显示视窗
            Nullable<bool> result = dig.ShowDialog();
            if(result ==true)
            {
                // 写入文本中
                System.IO.File.WriteAllText(dig.FileName, Textarea.Text);
            }
        }

        // 關閉按鈕的設置
        private void CloseButton_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }


        // 更改主體顏色為黑色
        private void ChangeBlack_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textarea.Background = Brushes.Gray;
            RightBox.Fill = Brushes.Black ;
            OpenBtn.Background = Brushes.Black;
            SaveasBtn.Background = Brushes.Black;
            SaveBtn.Background = Brushes.Black;
            OpenBtn.BorderBrush = Brushes.Black;
            SaveasBtn.BorderBrush = Brushes.Black;
            SaveBtn.BorderBrush = Brushes.Black;
            SmallSize.Background = Brushes.Black;
            ModelSize.Background = Brushes.Black ;
            HugeSize.Background = Brushes.Black;
            SmallSize.BorderBrush = Brushes.Black ;
            ModelSize.BorderBrush= Brushes.Black ;
            HugeSize.BorderBrush= Brushes.Black ;
        }

        // 更換主題顏色為黃色
        private void ChangeYellow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            //
Textarea.Background= Brushes.LightGray;
            RightBox.Fill = Brushes.Black;
            OpenBtn.Background = Brushes.Black;
            SaveasBtn.Background = Brushes.Black;
            SaveBtn.Background = Brushes.Black;
            OpenBtn.BorderBrush = Brushes.Black;
            SaveasBtn.BorderBrush = Brushes.Black;
            SaveBtn.BorderBrush = Brushes.Black;
            SmallSize.Background = Brushes.Black;
            ModelSize.Background = Brushes.Black;
            HugeSize.Background = Brushes.Black;
            SmallSize.BorderBrush = Brushes.Black;
            ModelSize.BorderBrush= Brushes.Black;
            HugeSize.BorderBrush= Brushes.Black;
        }
       

        // 窗體的移動
        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        // 字體大小的修改
        private void SmallSize_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 15;
        }

        private void HugeSize_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 25;
        }

        private void ModelSize_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 20;
        }

        private void BigBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
           
        }
    }
}
