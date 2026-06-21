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

using System.Windows;

namespace WPF_TodoApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            string task = TaskInput.Text.Trim();

            if (string.IsNullOrEmpty(task))
            {
                MessageBox.Show("Введите задачу!");
                return;
            }

            TaskList.Items.Add(task);
            TaskInput.Clear();
        }

        
        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem == null)
            {
                MessageBox.Show("Выберите задачу для удаления!");
                return;
            }

            TaskList.Items.Remove(TaskList.SelectedItem);
        }
    }
}