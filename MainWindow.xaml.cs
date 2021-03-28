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
    }
    class Person
    {
        string name;
        string surname;
        string date;
        public Person(string nameC, string surnameC, string dateC) 
        {
            nameC = name;
            surnameC = surname;
            dateC = date;
        }
        //string Name { get; set; }
        //string Surname { get; set;}
        ////var dat = new DateTime();
    }
    class Employe : Person
    {
        int payment;

    }
}
