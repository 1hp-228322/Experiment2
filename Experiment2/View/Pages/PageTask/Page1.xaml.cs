using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using Experiment2.View;
using Experiment2;

namespace Experiment2.View.Pages.PageTask
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

    }

    public class Address
    {
        private int _index;
        private string? _country;
        private string? _city;
        private string? _street;
        private string? _house;
        private string? _apartment;

        public int Index
        {
            get => _index;
            set => _index = value;
        }

        public string? Country
        {
            get => _country;
            set => _country = value;
        }

        public string? City
        {
            get => _city;
            set => _city = value;
        }

        public string? Street
        {
            get => _street;
            set => _street = value;
        }

        public string? House
        {
            get => _house;
            set => _house = value;
        }

        public string? Apartment
        {
            get => _apartment;
            set => _apartment = value;
        }

        private void BtnGetData_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TbIndex.Text) ||
                string.IsNullOrEmpty(TbCountry.Text) ||
                string.IsNullOrEmpty(TbCity.Text) ||
                string.IsNullOrEmpty(TbStreet.Text) ||
                string.IsNullOrEmpty(TbHouse.Text) ||
                string.IsNullOrEmpty(TbApartment.Text))
            {
                MessageBox.Show("Ошибка ввода данных",
                                "Задание 1",
                                MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }


