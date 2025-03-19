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

using System;
using Experiment2.Core;
using Experiment2.View.Pages;

namespace CourseWorkApp.View.Pages.PageTask
{
    public partial class Page5 : Page
    {
        #region Исходные данные
        private int n = 5; 
        private int[,]? _sourceArray; 
        #endregion

        public Page5()
        {
            InitializeComponent();
            InitializeArray(); 
        }

        #region Инициализация массива
        private void InitializeArray()
        {
            _sourceArray = new int[n, n];
            Random random = new Random();
            TbSourceArray.Text = ""; 

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    _sourceArray[i, j] = random.Next(10, 100);
                    TbSourceArray.Text += $"{_sourceArray[i, j]}\t"; 
                }
                TbSourceArray.Text += "\n";
            }
        }
        #endregion

        #region Обработка нажатия кнопки "Модифицировать массив"
        private void BtnModified_Click(object sender, RoutedEventArgs e)
        {
            SpModifiedArray.Visibility = Visibility.Visible;
            TbModifiedArray.Text = ""; 

           
            for (int i = 0; i < n; i++)
            {
                (_sourceArray[3, i], _sourceArray[4, i]) = (_sourceArray[4, i], _sourceArray[3, i]);
            }

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    TbModifiedArray.Text += $"{_sourceArray[i, j]}\t"; 
                }
                TbModifiedArray.Text += "\n";
            }
        }
        #endregion

        private void BtnLogout_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?",
                                "Системное сообщение",
                                MessageBoxButton.YesNo,
                                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                ConnectionCore.CoreFrame?.Navigate(new MainPage());
            }
        }
    }
}
