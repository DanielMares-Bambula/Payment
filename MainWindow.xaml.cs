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

namespace Payment
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person p = new Person();
            DataContext = p;

        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee(EducationCombo.Text, Position.Text, Convert.ToInt16(Payment.Text), Name.Text, Surname.Text, Convert.ToInt16(DateOfBirth.Text));
            Fin.Content = "Finish";
        }
    }
    class Person
    {
           string Name { get; set; }
           string Surname { get; set; }
           int YearOfBirth { get; set; }
        public Person(string nameC, string surnameC, int dateC) 
        {
            Name = nameC;
            Surname = surnameC;
            YearOfBirth = dateC;
        }
    }
    class Employee : Person
    {     
        int Payment { get; set; }
        string Position { get; set; }
        string Education { get; set; }
        public Employee(string educationE, string positionE , int paymentE, string nameC, string surnameC, int dateC) : base(nameC, surnameC, dateC) 
        {
            Payment = paymentE;
            Education = educationE;
            Position = positionE;
        }
    }
}

