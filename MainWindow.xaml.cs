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
using System.Text.RegularExpressions;

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
            InitializeComponent();
            em = new Employee { Name = "None", Surname = "None", Payment = "None", Position = "None", YearOfBirth = "None" };
            this.DataContext = em;
            //try
            //{
                
            //}
            //catch (Exception ex)
            //{
            //    Error.Content = ex.Message;
            //}
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            Fin.Content = "Finish";
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckNameOK();
        }

        private bool CheckNameOK()
        {
            Regex regex = new Regex(@"[A-Z][a-z]*");
            if (regex.IsMatch(Name.Text))
            {
                NameErrorVisible = Visibility.Visible;
                return true;
            }
            else
            {
                NameErrorVisible = Visibility.Hidden;
                return false;
            }
        }

      private Visibility _NameErrorVisible;
        public Visibility NameErrorVisible
        {
            get { return _NameErrorVisible; }
            set
            {
                _NameErrorVisible = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("NameErrorVisible"));
            }
        }

        private void Surname_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckSurnameOK();
        }
        private bool CheckSurnameOK()
        {
            Regex regex = new Regex(@"[A-Z][a-z]*");
            if (regex.IsMatch(Surname.Text))
            {
                SurnameErrorVisible = Visibility.Visible;
                return true;
            }
            else
            {
                SurnameErrorVisible = Visibility.Hidden;
                return false;
            }
        }

        private Visibility _SurnameErrorVisible;
        public Visibility SurnameErrorVisible
        {
            get { return _SurnameErrorVisible; }
            set
            {
                _SurnameErrorVisible = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("SurnameErrorVisible"));
            }
        }
        private bool CheckYearOfBirthOK()
        {
            Regex regex = new Regex(@"[0-9]{4}");
            if (regex.IsMatch(YearOfBirth.Text))
            {
                YearOfBirthErrorVisible = Visibility.Visible;
                return true;
            }
            else
            {
                YearOfBirthErrorVisible = Visibility.Hidden;
                return false;
            }
        }
        private Visibility _YearOfBirthErrorVisible;
        public Visibility YearOfBirthErrorVisible
        {
            get { return _YearOfBirthErrorVisible; }
            set
            {
                _YearOfBirthErrorVisible = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("YearOfBirthErrorVisible"));
            }
        }

        private void YearOfBirth_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckYearOfBirthOK();
        }

        private void Payment_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckPaymentOK();
        }

        private bool CheckPaymentOK()
        {
            Regex regex = new Regex(@"[0-9]*");
            if (regex.IsMatch(Payment.Text))
            {
                PaymentErrorVisible = Visibility.Visible;
                return true;
            }
            else
            {
                PaymentErrorVisible = Visibility.Hidden;
                return false;
            }
        }
        private Visibility _PaymentErrorVisible;
        public Visibility PaymentErrorVisible
        {
            get { return _PaymentErrorVisible; }
            set
            {
                _PaymentErrorVisible = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PaymentErrorVisible"));
            }
        }

        private void Position_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckPositionOK();
        }
        private bool CheckPositionOK()
        {
            if (Position.Text.Length !=0)
            {
                PositionErrorVisible = Visibility.Visible;
                return true;
            }
            else
            {
                PositionErrorVisible = Visibility.Hidden;
                return false;
            }
        }
        private Visibility _PositionErrorVisible;
        public Visibility PositionErrorVisible
        {
            get { return _PositionErrorVisible; }
            set
            {
                _PositionErrorVisible = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("PositionErrorVisible"));
            }
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
        public static List<Employee> AllEmployee = new List<Employee>();
        public string Payment { get; set; }
         public string Position { get; set; }
         public string Education { get; set; }
       
    }
}

