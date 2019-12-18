using System;
using System.Collections.Generic;
using System.IO;
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

namespace StudentePeerUnGiorno
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string fileName = "nomi, cognomi e date.txt";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbAgree_Checked(object sender, RoutedEventArgs e)
        {
            btnPrint.IsEnabled = true;
        }

        private void cbAgree_Unchecked(object sender, RoutedEventArgs e)
        {
            btnPrint.IsEnabled = false;
        }

        private void btnGreet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nome = txtName.Text;
                string cognome = txtCognome.Text;
                string date = dpData.SelectedDate.Value.ToString("d/M/yyyy");
                DateTime today = new DateTime();
                today = DateTime.Today;
                string oggi = today.ToString("d/M/yyyy");
                MessageBox.Show($"Hello {nome} {cognome}! Sei nato il {date}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (StreamWriter w = new StreamWriter(fileName, true))
                {
                    string nome = txtName.Text;
                    string cognome = txtCognome.Text;
                    string date = dpData.SelectedDate.Value.ToString("d/M/yyyy");
                    w.WriteLine($"Hello {nome} {cognome}! Sei nato il {date}");
                }
            }
            catch
            {

            }
        }
    }
}
