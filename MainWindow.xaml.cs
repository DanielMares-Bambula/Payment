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
using System.ComponentModel;

namespace Payment
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        Employee em;
        public MainWindow()
        {
            try
            {
                InitializeComponent();
                em = new Employee {Name = "None", Surname = "None", Payment = "None", Position = "None", YearOfBirth = "None"};
                this.DataContext = em;
            }
            catch (Exception ex)
            {
                Error.Content = ex.Message;
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {           
            Fin.Content = "Finish";
        }
    }
    class Person
    {
         public string Name { get; set; }
         public string Surname { get; set; }
         public string YearOfBirth { get; set; }      
    }
    class Employee : Person
    {     
         public string Payment { get; set; }
         public string Position { get; set; }
         public string Education { get; set; }
       
    }
}

