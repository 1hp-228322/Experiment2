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


namespace CourseWorkApp.View.Pages.PageTask
{
    public partial class Page3 : Page
    {
        #region Исходные данные
        private int[]? _sourceArray;
        private int[]? _newArray;
        #endregion

        public Page3()
        {
            InitializeComponent();
            InitializeArray(); 
        }

        #region Инициализация массива
        private void InitializeArray()
        {
            Random random = new Random();
            _sourceArray = Enumerable.Range(0, 8).Select(g => random.Next(10, 100)).ToArray();
            for (int i = 0; i < _sourceArray.Length; i++)
            {
                TbSourceArray.Text += $" {_sourceArray[i]}";
            }
        }
        #endregion

        #region Обработка нажатия кнопки "Получить новый массив"
        private void BtnGetNewArray_Click(object sender, RoutedEventArgs e)
        {
            SpNewArray.Visibility = Visibility.Visible; 
            TbNewArray.Text = ""; 

            _newArray = _sourceArray?.Select(g => g % 10).ToArray(); 
            for (int i = 0; i < _newArray?.Length; i++)
            {
                TbNewArray.Text += $" {_newArray[i]}"; 
            }
        }
        #endregion
    }
}
