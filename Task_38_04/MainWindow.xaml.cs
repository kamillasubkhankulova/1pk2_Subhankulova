using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
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
using Task_38_04.Images;

namespace Task_38_04
{
#pragma warning disable
    public partial class MainWindow : Window
    {
        private readonly ListStudents _studentGroup = new ListStudents();

        public MainWindow()
        {
            InitializeComponent();
            genderComboBox.SelectedIndex = 0;
            studentListBox.ItemsSource = _studentGroup.Students;
        }

        private void addStudentButton_Click(object sender, RoutedEventArgs e)
        {
            if (!Validate(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                Students student = new Students(
                    surname.Text.Trim(),
                    name.Text.Trim(),
                    patronymic.Text.Trim(),
                    group.Text.Trim(),
                    (GenderStudents)genderComboBox.SelectedIndex,
                    birthDatePicker.SelectedDate ?? DateTime.Now);

                _studentGroup.AddStudent(student);
                studentListBox.Items.Refresh();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении студента: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void clearStudentButton_Click(object sender, RoutedEventArgs e)
        {
            ClearFields();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                _studentGroup.Load();
                studentListBox.ItemsSource = _studentGroup.Students;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            try
            {
                _studentGroup.Save();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}", "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void deleteStudentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (studentListBox.SelectedItem is Students selectedStudent)
            {
                try
                {
                    _studentGroup.RemoveStudent(selectedStudent);
                    studentListBox.Items.Refresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при удалении студента: {ex.Message}", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void showInfoMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShowStudentInfo();
        }

        private void studentListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            ShowStudentInfo();
        }

        private bool Validate(out string error)
        {
            error = string.Empty;
            StringBuilder errorBuilder = new StringBuilder();

            if (string.IsNullOrWhiteSpace(surname.Text))
                errorBuilder.AppendLine("Фамилия не может быть пустой");

            if (string.IsNullOrWhiteSpace(name.Text))
                errorBuilder.AppendLine("Имя не может быть пустым");

            if (string.IsNullOrWhiteSpace(group.Text))
                errorBuilder.AppendLine("Группа не может быть пустой");

            if (birthDatePicker.SelectedDate == null)
                errorBuilder.AppendLine("Укажите дату рождения");
            else if (birthDatePicker.SelectedDate > DateTime.Now)
                errorBuilder.AppendLine("Дата рождения не может быть в будущем");

            error = errorBuilder.ToString();
            return string.IsNullOrEmpty(error);
        }

        private void ClearFields()
        {
            surname.Clear();
            name.Clear();
            patronymic.Clear();
            group.Clear();
            birthDatePicker.SelectedDate = DateTime.Now;
            genderComboBox.SelectedIndex = 0;
        }

        private void ShowStudentInfo()
        {
            if (studentListBox.SelectedItem is Students selectedStudent)
            {
                MessageBox.Show(
                    $"ФИО: {selectedStudent.Surname} {selectedStudent.Name} {selectedStudent.Patronymic}\n" +
                    $"Группа: {selectedStudent.Group}\n" +
                    $"Пол: {selectedStudent.StringGenderStudent()}\n" +
                    $"Дата рождения: {selectedStudent.BirthDate:dd.MM.yyyy}",
                    "Информация о студенте",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
        }
    }
}