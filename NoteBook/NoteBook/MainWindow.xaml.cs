﻿using System;
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
            this.Close();
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
        }

        //更改主體顏色為黑色
        private void ChangeBlack_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
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

        //更換主題顏色為黃色
        private void ChangeYellow_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textarea.Background = Brushes.LightYellow;
            RightBox.Fill = Brushes.BurlyWood;
            OpenBtn.Background = Brushes.BurlyWood;
            SaveasBtn.Background = Brushes.BurlyWood;
            SaveBtn.Background = Brushes.BurlyWood;
            SaveBtn.BorderBrush = Brushes.BurlyWood;
            OpenBtn.BorderBrush = Brushes.BurlyWood;
            SaveasBtn.BorderBrush = Brushes.BurlyWood;
            SmallSize.Background = Brushes.BurlyWood;
            ModelSize.Background = Brushes.BurlyWood;
            HugeSize.Background = Brushes.BurlyWood;
            SmallSize.BorderBrush = Brushes.BurlyWood;
            ModelSize.BorderBrush= Brushes.BurlyWood;
            HugeSize.BorderBrush= Brushes.BurlyWood;
        }

        private void SmallSize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textarea.FontSize = 10;
        }

        private void ModelSize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void HugeSize_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Textarea.FontSize = 20;
        }

        private void ModelSize_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void SmallSize_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 15;
        }

        private void HugeSize_Click(object sender, RoutedEventArgs e)
        {
            Textarea.FontSize = 25;
        }
    }
}
