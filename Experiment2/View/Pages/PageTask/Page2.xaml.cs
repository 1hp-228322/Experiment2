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
    public partial class Page2 : Page
    {
        #region Исходные данные
        private int[] _firstArray = new int[10];
        private int[] _secondArray = new int[10];
        private int[] _newArray = new int[10];
        #endregion

        public Page2()
        {
            InitializeComponent();
            InitializeArrays();
        }

        #region Инициализация массивов
        private void InitializeArrays()
        {
            Random random = new Random();
            for (int i = 0; i < _firstArray.Length; i++)
            {
                _firstArray[i] = random.Next(10, 100);
                TbFirstArray.Text += $" {_firstArray[i]}";
            }
            for (int i = 0; i < _secondArray.Length; i++)
            {
                _secondArray[i] = random.Next(10, 100);
                TbSecondArray.Text += $" {_secondArray[i]}";
            }
        }
        #endregion

        #region Обработка нажатия кнопки "Получить новый массив"
        private void BtnGetNewArray_Click(object sender, RoutedEventArgs e)
        {
            SpNewArray.Visibility = Visibility.Visible; 
            TbNewArray.Text = ""; 

            for (int i = 0; i < _newArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    _newArray[i] = _firstArray[i + 1]; 
                }
                else
                {
                    _newArray[i] = _secondArray[i - 1];
                }

                TbNewArray.Text += $" {_newArray[i]}";
            }
        }
        #endregion
    }
}
