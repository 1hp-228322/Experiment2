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
using System.Windows;
using System.Windows.Controls;
using Experiment2.Core;
using Experiment2.View.Pages;

namespace CourseWorkApp.View.Pages.PageTask
{
    public partial class Page4 : Page
    {
        #region Исходные данные
        private int[,] _sourceArray = new int[5, 4]; 
        private int n, m, t; 
        #endregion

        public Page4()
        {
            InitializeComponent();
            InitializeArray(); 
        }

        #region Инициализация массива
        private void InitializeArray()
        {
            Random random = new Random();
            TbSourceArray.Text = ""; 

            for (n = 0; n < 5; n++)
            {
                for (m = 0; m < 4; m++)
                {
                    _sourceArray[n, m] = random.Next(10, 100); 
                    TbSourceArray.Text += $"{_sourceArray[n, m]}\t"; 
                }
                TbSourceArray.Text += "\n";
            }
        }
        #endregion

        #region Обработка нажатия кнопки "Отсортировать массив"
        private void BtnSortArray_Click(object sender, RoutedEventArgs e)
        {
            SpSortedArray.Visibility = Visibility.Visible; 
            TbSortedArray.Text = ""; 

            m = 4; 
            n = 5; 

            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (_sourceArray[i, m - 1] > _sourceArray[j, m - 1])
                    {
                        
                        for (int k = 0; k < m; k++)
                        {
                            t = _sourceArray[i, k];
                            _sourceArray[i, k] = _sourceArray[j, k];
                            _sourceArray[j, k] = t;
                        }
                    }
                }
            }

            
            for (n = 0; n < 5; n++)
            {
                for (m = 0; m < 4; m++)
                {
                    TbSortedArray.Text += $"{_sourceArray[n, m]}\t"; 
                }
                TbSortedArray.Text += "\n";
            }
        }
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
        #endregion
    }
}
