﻿using System;
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
using Experiment2.Core;

namespace Experiment2.View.Pages.PageTask
{
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
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
            else
            {
                Address address = new()
                {
                    Index = Convert.ToInt32(TbIndex.Text),
                    Country = TbCountry.Text,
                    City = TbCity.Text,
                    Street = TbStreet.Text,
                    House = TbHouse.Text,
                    Apartment = TbApartment.Text
                };

                MessageBox.Show($"Почтовый индекс - {address.Index}\n" +
                                $"Страна - {address.Country}\n" +
                                $"Город - {address.City}\n" +
                                $"Улица - {address.Street}\n" +
                                $"Дом - {address.House}\n" +
                                $"Квартира - {address.Apartment}",
                                "Задание 1",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);

                ClearFields();
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

        private void ClearFields()
        {
            TbIndex.Text = string.Empty;
            TbCountry.Text = string.Empty;
            TbCity.Text = string.Empty;
            TbStreet.Text = string.Empty;
            TbHouse.Text = string.Empty;
            TbApartment.Text = string.Empty;
        }

        private void TbStreet_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Tbi_TextChanged(object sender, TextChangedEventArgs e)
        {

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


    }
        
} 
    

