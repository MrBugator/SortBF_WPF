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
using System.Threading;
using System.IO;
using Microsoft.Win32;
using SortBigFileLib;
namespace SortBF_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Thread th_gen;
        Thread Updater;
        Thread mergeSort;
        public MainWindow()
        {
            InitializeComponent();
        }
        class pathAndLength
        {
            public string path;
            public ulong length;
            public pathAndLength(string p, ulong l)
            {
                path = p;
                length = l;
            }
        }
        private void generateInt64file(object pathAndL)
        {
            pathAndLength pathl = pathAndL as pathAndLength;
            string pathOfFileGen = pathl.path;
            ulong length = pathl.length;
            StreamWriter sr = new StreamWriter(pathOfFileGen);
            Random r = new Random(124124);

            for (ulong i = 0; i < length; i++)
            {
                Application.Current.Dispatcher.Invoke(
                new Action(() => 
                {
                    statusgen.Text = (i+1) + " / " + length;
                }));

                sr.WriteLine((long)((2 * r.NextDouble() - 1) * long.MaxValue));
            }

            sr.Close();
        }
        private void UpdateStatus(object data)
        {
            SortBF sort = data as SortBF;
            string status = "";
            string status_iter = "";
            while(true)
            {
                if(sort.GetStatus() != status)
                {
                    status = sort.GetStatus();
                    Application.Current.Dispatcher.Invoke(
                    new Action(() =>
                    {
                        TextBlock_status.Text = status;
                    }));
                }
                if(sort.GetStatus_Iter() != status_iter)
                {
                    status_iter = sort.GetStatus_Iter();
                    Application.Current.Dispatcher.Invoke(
                    new Action(() =>
                    {
                        TextBlock_statusiter.Text = status_iter;
                    }));
                }
                if (status == "Завершено.")
                    break;
                Thread.Sleep(50);
            }
        }
        private void StartSort(object data)
        {
            SortBF sort = data as SortBF;
            sort.Sort();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            th_gen = new Thread(generateInt64file);
            if (GenLength.Text == "")
            {
                MessageBox.Show("Количество строк в генерации не указано!");
                return;
            }
            ulong parseGenLength = 0;
            if (!ulong.TryParse(GenLength.Text, out parseGenLength) || parseGenLength == 0)
            {
                MessageBox.Show("В стркоке некорректное целое число/не число!");
                return;
            }
            if(GenPath.Text=="")
            {
                MessageBox.Show("Адрес генерации не был указан!");
                return;
            }
            th_gen.Start(new pathAndLength(GenPath.Text, parseGenLength));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            bool res = (bool)saveDialog.ShowDialog();
            if (res == false)
                return;
            GenPath.Text = saveDialog.FileName;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            OpenFileDialog saveDialog = new OpenFileDialog();
            bool res = (bool)saveDialog.ShowDialog();
            if (res == false)
                return;
            FirstSortFile.Text = saveDialog.FileName;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            OpenFileDialog saveDialog = new OpenFileDialog();
            bool res = (bool)saveDialog.ShowDialog();
            if (res == false)
                return;
            SecondSortFile.Text = saveDialog.FileName;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Updater = new Thread(UpdateStatus);
            mergeSort = new Thread(StartSort);
            if (FirstSortFile.Text == "")
            {
                MessageBox.Show("Адрес первого файла не указан!");
                return;
            }
            int parseMaxLine = 0;
            if (!int.TryParse(maxLine.Text, out parseMaxLine) || (parseMaxLine<8 || parseMaxLine>200000))
            {
                MessageBox.Show("В стркоке некорректное целое число/не число/выход за допустимый диапазон!");
                return;
            }
            if (FirstSortFile.Text == "")
            {
                MessageBox.Show("Адрес второго файла не указан!");
                return;
            }
            if (NewFile.Text == "")
            {
                MessageBox.Show("Адрес второго файла не указан!");
                return;
            }
            SortBF sortBF = new SortBF(FirstSortFile.Text, SecondSortFile.Text, NewFile.Text, parseMaxLine);
            Updater.Start(sortBF);
            mergeSort.Start(sortBF);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            bool res = (bool)saveDialog.ShowDialog();
            if (res == false)
                return;
            NewFile.Text = saveDialog.FileName;
        }
    }
}
