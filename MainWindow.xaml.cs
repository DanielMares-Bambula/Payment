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
            
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Employee employee = new Employee(EducationCombo.Text, Position.Text, Convert.ToInt16(Payment.Text), Name.Text, Surname.Text, Convert.ToInt16(DateOfBirth.Text));
            Fin.Content = "Finish";
        }
    }
    class Person
    {
           string name;
           string surname;
           int yearOfBirth;
        public Person(string nameC, string surnameC, int dateC) 
        {
            name = nameC;
            surname = surnameC;
            yearOfBirth = dateC;
        }
    }
    class Employee : Person
    {     
        int payment;
        string position;
        string education;
        public Employee(string educationE, string positionE , int paymentE, string nameC, string surnameC, int dateC) : base(nameC, surnameC, dateC) 
        {
            payment = paymentE;
            education = educationE;
            position = positionE;
        }
    }
}
