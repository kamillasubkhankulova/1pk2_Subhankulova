using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.Text.Json;
using System.IO;


namespace Task_39_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<string> { "Яблоки", "Хлеб", "Молоко", "Яйца", "Морковь", "Сыр" };
            productsList.ItemsSource = products;
        }

        private void Button_Products_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string product = productsTextBox.Text.Trim();
                if (!string.IsNullOrWhiteSpace(product))
                {
                    if (!products.Contains(product))
                    {
                        products.Add(product);
                        productsTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Такой продукт уже есть в списке",
                                       "Предупреждение",
                                       MessageBoxButton.OK,
                                       MessageBoxImage.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Введите название продукта",
                                   "Ошибка",
                                   MessageBoxButton.OK,
                                   MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении продукта: {ex.Message}",
                               "Ошибка",
                               MessageBoxButton.OK,
                               MessageBoxImage.Error);
            }
        }

        private void SaveFileButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*",
                    DefaultExt = ".txt",
                    Title = "Сохранить список покупок",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                };

                if (saveFileDialog.ShowDialog() == true)
                {
                    File.WriteAllLines(saveFileDialog.FileName, products);

                    MessageBox.Show("Список покупок успешно сохранен!",
                                   "Успех",
                                   MessageBoxButton.OK,
                                   MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении: {ex.Message}",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
    }
}